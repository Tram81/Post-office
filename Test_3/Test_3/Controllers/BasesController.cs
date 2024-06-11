using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;
using prj3.Models;
using System.Threading.Tasks;
using Test_3.Models;
using Test_3.Repository;
using Test_3.Services;

namespace Test_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthService _authService;

        public AccountController(IUserRepository userRepository, IAuthService authService)
        {
            _userRepository = userRepository;
            _authService = authService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            if (user == null || string.IsNullOrEmpty(user.User) || string.IsNullOrEmpty(user.Password))
            {
                return BadRequest("Invalid user data.");
            }

            var existingUser = await _userRepository.GetUserByUsername(user.Username);
            if (existingUser != null)
            {
                return BadRequest("User already exists.");
            }

            // Trong ứng dụng thực tế, hãy băm mật khẩu trước khi lưu
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            await _userRepository.CreateUser(user);
            return Ok("User registered successfully.");
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] User login)
        {
            if (login == null || string.IsNullOrEmpty(login.Username) || string.IsNullOrEmpty(login.Password))
            {
                return BadRequest("Invalid login data.");
            }

            var user = await _userRepository.GetUserByUsername(login.Username);
            if (user == null || !BCrypt.Net.BCrypt.Verify(login.Password, user.Password)) // Trong ứng dụng thực tế, hãy xác minh mật khẩu băm
            {
                return Unauthorized("Invalid username or password.");
            }

            var token = _authService.GenerateJwtToken(user);
            return Ok(new { token });
        }
    }
}
