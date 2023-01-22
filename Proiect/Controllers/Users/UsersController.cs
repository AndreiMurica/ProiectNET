using Microsoft.AspNetCore.Mvc;
using Proiect.Helper.Attributes;
using Proiect.Models.DTOs.UserDto;
using Proiect.Models.Enums;
using Proiect.Models.User;
using Proiect.Services.UserServices;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Proiect.Controllers.Users
{
        [Route("api/[controller]")]
        [ApiController]
        public class UsersController : ControllerBase
        {
            private IUserService _userService;

            public UsersController(IUserService userService)
            {
                _userService = userService;
            }

            [HttpPost("create-user")]
            public async Task<IActionResult> CreateUser(UserRequestDTO user)
            {
                var userToCreate = new User
                {
                    Username = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Role = Role.User,
                    Email = user.Email,
                    PasswordHash = BCryptNet.HashPassword(user.Password)
                };

                await _userService.Create(userToCreate);
                return Ok();
            }

            [HttpPost("create-admin")]
            public async Task<IActionResult> CreateAdmin(UserRequestDTO user)
            {
                var userToCreate = new User
                {
                    Username = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Role = Role.Admin,
                    Email = user.Email,
                    PasswordHash = BCryptNet.HashPassword(user.Password)
                };

                await _userService.Create(userToCreate);
                return Ok();
            }

            [HttpPost("authenticate")]
            public async Task<IActionResult> Authenticate(UserRequestLoginDTO user)
            {
                var response = _userService.Atuhentificate(user);
                if (response == null)
                {
                    return BadRequest("Username or password is invalid!");
                }
                return Ok();
            }

            
            [HttpGet("admin")]
            public  IActionResult GetAllAdmin()
            {
                var users =  _userService.GetAllUsers();
                return Ok(users);
            }

            [HttpGet("user")]
            public IActionResult Findaa(string username)
             {
                var user = _userService.Find(username);
                return Ok();
            }
            }
}
