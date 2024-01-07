using Microsoft.AspNetCore.Mvc;

namespace Cthulhu.Service.Controllers
{
    public class TestResponseModel
    {
        public string Text { get; set; } = string.Empty;
    }

    public class TestRequestModel
    {
        public string Text { get; set; } = string.Empty;
    }

    [Route("[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public async Task<string> GetOk()
        {
            await Task.Delay(1);
            return "ok!";
        }

        [HttpPost]
        public async Task<TestResponseModel> GetModel(TestRequestModel request)
        {
            await Task.Delay(1);
            return new TestResponseModel() { Text = request.Text };
        }
    }
}
