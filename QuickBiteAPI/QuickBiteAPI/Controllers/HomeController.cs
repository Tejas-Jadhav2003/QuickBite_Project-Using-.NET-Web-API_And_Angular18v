using Microsoft.AspNetCore.Mvc;

namespace QuickBiteAPI.Controllers
{
    [Route("Api/[Controller]/[Action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()  
        {
            return Ok("Hello from HoemController");
        }
    }
}
