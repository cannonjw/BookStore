using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.API.Contracts;
using BookStore.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILoggerService _logger;
        public UsersController(SignInManager<IdentityUser> signInManager, 
                                UserManager<IdentityUser> userManager,
                                ILoggerService logger)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserDto userDto)
        {
            try
            {
                var location = GetControllerActionNames();
                _logger.LogInfo($" {location} User {userDto.Username} Attempting to login");
                var result = await _signInManager.PasswordSignInAsync(userDto.Username, userDto.Password, false, false);
                if (result.Succeeded)
                {
                    _logger.LogInfo($" {location} User {userDto.Username} login was successful");
                    var user = await _userManager.FindByNameAsync(userDto.Username);
                    return Ok(user);
                }
                _logger.LogWarn($" {location} User {userDto.Username} login failed");

                return Unauthorized(userDto);

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