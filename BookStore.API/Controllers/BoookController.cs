using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.API.Contracts;
using BookStore.API.Dtos;
using BookStore.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class BooksController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        private readonly ILoggerService _logger;
        public BooksController(IBookRepository bookRepository, IMapper mapper, ILoggerService logger)
        {
            _logger = logger;
            _mapper = mapper;
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var location = GetControllerActionNames();
            try
            {
                _logger.LogInfo($" {location}\nGet Books");
                var books = await _bookRepository.FindAll();
                if (books == null || books.Count == 0)
                {
                    _logger.LogWarn($" {location} \n No Books Found");
                    return NotFound();
                }
                var response = _mapper.Map<IList<BookDto>>(books);
                
                return Ok(response);
            } catch (Exception _ex)
            {
                return InternalError($"\b{location}\n{_ex.Message}\n{_ex.InnerException}");
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetBook(int id)
        {
            var location = GetControllerActionNames();
            try
            {
                _logger.LogInfo($" {location}: Attempted call for id: {id}");
                var book = await _bookRepository.FindById(id);
                if (book == null)
                {
                    _logger.LogWarn($" {location}: Book with Id: {id} failed.");
                    return NotFound($" {location}: Book with Id: {id} failed.");
                }
                var response = _mapper.Map<BookDto>(book);
                return Ok(response);
            } catch (Exception _ex)
            {
                return InternalError($"\b{location}\n{_ex.Message}\n{_ex.InnerException}");
            }
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(StatusCodes.Status201Created )]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> CreateBook([FromBody]BookForCreateDto bookForCreateDto)
        {
            var location = GetControllerActionNames();
            try
            {
                _logger.LogInfo($" {location}: Creating Book");
                if (bookForCreateDto == null)
                {
                    _logger.LogWarn($" {location}: Empty Request was submitted");
                    return BadRequest(ModelState);
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogWarn($" {location}: Data was incomplete");
                    return BadRequest(ModelState);
                }
                var book = _mapper.Map<Book>(bookForCreateDto);
                var IsSuccess = await _bookRepository.Create(book);
                if (!IsSuccess)
                {
                   return InternalError($" {location}: Creation Failed");
                    
                }
                return Created("Create", new { book });
            } catch (Exception _ex)
            {
                return InternalError($"{_ex.Message}\n{_ex.InnerException}");
            }
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(StatusCodes.Status204NoContent )]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> UpdateBook(int id,[FromBody]BookForUpdateDto bookForUpdateDto)
        {
            var location = GetControllerActionNames();
            try
            {
                _logger.LogInfo($" {location}: Update Book");
                if (id < 1 || bookForUpdateDto == null || id != bookForUpdateDto.Id)
                {
                    _logger.LogWarn($" {location}: Empty Request was submitted");
                    return BadRequest(ModelState);
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogWarn($" {location}: Data was incomplete");
                    return BadRequest(ModelState);
                }
                if (! await _bookRepository.isExist(id))
                {
                    _logger.LogWarn($" {location}: Book does not exist");
                    return NotFound($" {location}: Book does not exist");
                }
                var book = _mapper.Map<Book>(bookForUpdateDto);
                var IsSuccess = await _bookRepository.Update(book);
                if (!IsSuccess)
                {
                   return InternalError($" {location}: Update Failed for Record Id: {id}");
                }
                return NoContent();
            } catch (Exception _ex)
            {
                return InternalError($"{_ex.Message}\n{_ex.InnerException}");
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(StatusCodes.Status204NoContent )]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            var location = GetControllerActionNames();
            try
            {
                _logger.LogInfo($" {location}: Starting Delete {id}");
                if (id < 1)
                {
                    _logger.LogWarn($" {location}: You must supply an Id");
                    return BadRequest();
                }
                var book = await _bookRepository.FindById(id);
                if (book == null)
                {
                    _logger.LogWarn($" {location}: Book is not found for Id: {id}");
                    return NotFound($" {location}: Book is not found for Id: {id}");
                }
                var IsSuccess = await _bookRepository.Delete(book);
                if (!IsSuccess)
                {
                    _logger.LogWarn($" {location}: Delete failed");
                    return InternalError("Delete failed.  Please see Administrator");
                }
                _logger.LogInfo($" {location}: Delete Success!");
                return NoContent();
            } catch (Exception _ex)
            {
                return InternalError($"{_ex.Message}\n{_ex.InnerException}");
            }
        }

        private string GetControllerActionNames() {
            var controller = ControllerContext.ActionDescriptor.ControllerName;
            var action = ControllerContext.ActionDescriptor.ActionName;
            return $"{controller} - {action}";
        }
        private ObjectResult InternalError(string message)
        {
            _logger.LogError(message);
            return StatusCode(500, "Something went wrong, please contact an Administrator");
        }


    }
}