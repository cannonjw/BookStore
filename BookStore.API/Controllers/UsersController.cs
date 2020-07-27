using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.API.Contracts;
using BookStore.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILoggerService _logger;
        private readonly IConfiguration _config;
        public UsersController(SignInManager<IdentityUser> signInManager, 
                                UserManager<IdentityUser> userManager,
                                ILoggerService logger,
                                IConfiguration config)
        {
            _logger = logger;
            _config = config;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [Route("register")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] UserDto userDto)
        {
            var location = GetControllerActionNames();
            try
            {
                var user = new IdentityUser {
                    Email = userDto.EmailAddress,
                    UserName = userDto.EmailAddress
                };
                var result = await _userManager.CreateAsync(user, userDto.Password);
                if (!result.Succeeded)
                {
                    foreach(var error in result.Errors)
                    {
                        _logger.LogError($"{location}: {error.Code} {error.Description}");
                    }
                    return InternalError($"{location}: {userDto.EmailAddress} Registration Failed.");
                }
                return Ok(new { result.Succeeded });
            } catch (Exception _ex)
            {
                return InternalError($"{location}: {_ex.Message} - {_ex.InnerException}");
            }
        }

        [Route("login")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserDto userDto)
        {
            var location = GetControllerActionNames();
            try
            {
                _logger.LogInfo($"{location}: Login Attempt from user {userDto.EmailAddress} ");
                var result = await _signInManager.PasswordSignInAsync(userDto.EmailAddress, userDto.Password, false, false);

                if (result.Succeeded)
                {
                    _logger.LogInfo($"{location}: {userDto.EmailAddress} Successfully Authenticated");
                    var user = await _userManager.FindByEmailAsync(userDto.EmailAddress);
                    _logger.LogInfo($"{location}: Generating Token");
                    var tokenString = await GenerateJSONWebToken(user);
                    // return Ok(user);
                    return Ok(new { token = tokenString });
                }
                _logger.LogInfo($"{location}: {userDto.EmailAddress} Not Authenticated");
                return Unauthorized(userDto);
            }
            catch (Exception e)
            {
                return InternalError($"{location}: {e.Message} - {e.InnerException}");
            }
        }

        private async Task<string> GenerateJSONWebToken(IdentityUser user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id),
            };
            var roles = await _userManager.GetRolesAsync(user);
            claims.AddRange(roles.Select(r => new Claim(ClaimsIdentity.DefaultRoleClaimType, r)));

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                claims,
                null,
                expires: DateTime.Now.AddHours(5),
                signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
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