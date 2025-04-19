using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserService _service;

        public AuthController(UserService service)
        {
            _service = service;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Password))
            {
                return BadRequest("Vui lòng nhập đầy đủ thông tin.");
            }

            var existingUser = _service.GetUserByUsername(request.Username);
            if (existingUser != null)
            {
                return Conflict("Tài khoản đã tồn tại.");
            }

            var newUser = new Users
            {
                Username = request.Username,
                Password = request.Password // Có thể mã hóa nếu muốn
            };

            _service.SaveUser(newUser);
            return Ok("Tạo tài khoản thành công!");
        }
    }
}
