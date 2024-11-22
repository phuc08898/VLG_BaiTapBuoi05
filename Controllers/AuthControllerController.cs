using Microsoft.AspNetCore.Mvc;
using VLG_BaiTapBuoi05.Models;
using VLG_BaiTapBuoi05.Data;
using System.Linq;

namespace VLG_BaiTapBuoi05.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Kiểm tra dữ liệu đầu vào
            if (request == null || string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
            {
                return BadRequest("Username or password is missing.");
            }

            // Tìm người dùng trong MockData
            var user = MockData.Users.FirstOrDefault(u => u.Username == request.Username);

            if (user == null || user.PasswordHash != request.Password)
            {
                return Unauthorized("Invalid credentials.");
            }

            // Nếu thông tin đăng nhập đúng, trả về thông báo thành công
            return Ok(new { message = "Login successful", UserId = user.Id });
        }

        // Phương thức đăng xuất
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // Xóa token người dùng khỏi cookie hoặc header
            // Nếu bạn đang sử dụng cookie hoặc session để lưu trữ token, bạn có thể xóa nó ở đây.
            Response.Cookies.Delete("jwt_token");  // Xóa token lưu trong cookie
            HttpContext.Response.Headers.Remove("Authorization"); // Nếu token nằm trong header

            // Trả về thông báo đăng xuất thành công
            return Ok(new { message = "Logout successful" });
        }
    }   
}
