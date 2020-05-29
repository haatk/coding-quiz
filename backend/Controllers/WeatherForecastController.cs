using Microsoft.AspNetCore.Mvc;

namespace CodingQuiz.Controllers
{
    [ApiController]
    [Route("initial")]
    public class InitialController : ControllerBase
    {
        [HttpGet]
        public void Get()
        {
        }
    }
}
