using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sevices;
using Sevices.ViewModels.Users;

namespace Blogs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("Id")]
        public IActionResult GetUserById(int Id)
        {
            UserViewModel user = _userService.GetUserById(Id);
            if (user == null)
            {
                String message = "User không tồn tại";
                return BadRequest(message);
            }

            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create(CreateUserViewModel user)
        {
            if (user != null)
            {
                String message = "User không tồn tại";
                return BadRequest(message);
            }

            return Ok(user);
        }
    }
}
