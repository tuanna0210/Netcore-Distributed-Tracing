using Microsoft.AspNetCore.Mvc;

namespace ServiceA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WelcomeController(IHttpClientFactory clientFactory) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            var client = clientFactory.CreateClient("ServiceB");
            var serviceBResponse = await client.GetStringAsync("api/welcome");
            return "Welcome from Service A!" + "\n" + serviceBResponse;
        }
    }
}
