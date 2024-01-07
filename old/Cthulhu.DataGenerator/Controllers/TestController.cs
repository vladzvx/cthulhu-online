using Microsoft.AspNetCore.Mvc;

namespace Cthulhu.DataGenerator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        public TestController()
        {

        }

        [HttpGet]
        public string Get()
        {
            return "ok";
        }
    }
}