using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.API.Contracts;
using BookStore.API.Dtos;
using BookStore.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class AuthorsController : Controller
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorRepository authorRepository, ILoggerService loggerService, IMapper mapper)
        {
            _mapper = mapper;
            _logger = loggerService;
            _authorRepository = authorRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAuthors()
        {
            try
            {
                _logger.LogInfo("GetAuthors");
                var authors = await _authorRepository.FindAll();
                if (authors == null || authors.Count == 0)
                {
                    return NotFound();
                }
                var response = _mapper.Map<IList<AuthorDto>>(authors);
                
                return Ok(response);

            } catch (Exception _ex)
            {
                return InternalError($"Error getting authors\n{_ex.Message}\n {_ex.InnerException}");
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAuthor(int id)
        {
            try
            {
                _logger.LogInfo($"GetAuthor {id}");
                var author = await _authorRepository.FindById(id);
                if (author == null)
                {
                    _logger.LogWarn($"Author with Id: {id} not found");
                    return NotFound();
                }
                var response = _mapper.Map<AuthorDto>(author);

                return Ok(response);
            } catch (Exception _ex)
            {
                return InternalError($"Error getting authorId: {id}\n{_ex.Message}\n{_ex.InnerException}");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created )]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody]AuthorForCreateDto author)
        {
            try
            {
                if (author == null)
                {
                    _logger.LogWarn("Empty request was submitted");
                    return BadRequest(ModelState);
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogWarn("Invalid data received");
                    return BadRequest(ModelState);
                }
                var authorForCreate = _mapper.Map<Author>(author);
                var IsSuccess = await _authorRepository.Create(authorForCreate);
                if (!IsSuccess)
                {
                    _logger.LogError("Author Creation Failed");
                    return  InternalError("Author Creation Failed");
                }
                _logger.LogInfo("Author Created");
                return Created("Create", new { author });

            } catch (Exception _ex)
            {
                return InternalError($"{_ex.Message}\n{_ex.InnerException}");
            }
        }

        private ObjectResult InternalError(string message)
        {
            _logger.LogError(message);
            return StatusCode(500, "Something went wrong, please contact an Administrator");
        }

    }
}
