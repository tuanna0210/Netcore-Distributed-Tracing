using Microsoft.AspNetCore.Mvc;

namespace ServiceB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WelcomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Welcome from Service B!";
        }
    }
}
