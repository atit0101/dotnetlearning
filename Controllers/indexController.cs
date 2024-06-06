using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        
        [HttpGet("hello")]
        public IActionResult H5ello()
        {
            Console.WriteLine("Hello");
            return Ok("Hello");
        }

    }

    [Route("api/[controller]")]
    public class Index1Controller : ControllerBase
    {
        [HttpGet("hello1")]
        public IActionResult Hello1()
        {
            return Ok("Hello");
        }

    }
}