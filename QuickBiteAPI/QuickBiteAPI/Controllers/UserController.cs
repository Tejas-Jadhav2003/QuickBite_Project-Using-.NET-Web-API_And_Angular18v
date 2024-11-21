using Microsoft.AspNetCore.Mvc;
using QuickBiteAPI.Models;
using QuickBiteAPI.Repository;

namespace QuickBiteAPI.Controllers
{
    [Route("Api/[Controller]/[Action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> getAllUser()
        {
            return Ok(_user.getUsers());
        }

        [HttpPost]
        public async Task<ActionResult> addUsers()
        {
            return Created();
        }
    }
}
