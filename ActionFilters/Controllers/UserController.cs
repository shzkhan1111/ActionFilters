using ActionFilters.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActionFilters.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("")]
        public IActionResult GetUser([FromBody] GetUserRequest request)
        {
            var user = new
            {
                Id = request.UserId,
                Name = "Shahzaib Ahmed",
                Email = "shahzaib@ahmed.com"
            };

            return Ok(user);
        }

        [HttpPost("resetPassword")]
        public IActionResult ResetPassword([FromBody] ResetPasswordRequest request)
        {
            if (request.UserId <= 0)
            {
                return BadRequest("UserId must be greater than 0");
            }
            if (string.IsNullOrWhiteSpace(request.NewPassword))
            {
                return BadRequest("NewPassword is required");
            }
            if (request.UserId != 1)
            {
                return NotFound("User not found");
            }
            return Ok(new { Message = "Password reset successful" });

        }

    }


}
