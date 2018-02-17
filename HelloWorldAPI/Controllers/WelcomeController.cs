using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAPI.Controllers
{
    [Route("api/[controller]")]
    public class WelcomeController : Controller
    {
        // GET api/welcome
        [HttpGet]
        public string GetWelcomeMessage()
        {
            return "Hello World!";
        }
           
    }
 
}
