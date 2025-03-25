using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace user_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new List<object>
            {
                new { Id = 1, Name = "John Doe" },
                new { Id = 2, Name = "Jane Doe" }
            };

            return Ok(users);
        }
    }
}
