using Microsoft.AspNetCore.Mvc;

namespace EuropAssistance.Portugal.DRSA.Missioning.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        // GET: api/<HealthCheckController>
        [HttpGet]
        public string Get()
        {
            return "I'm good! Thanks for asking!";
        }

    }
}
