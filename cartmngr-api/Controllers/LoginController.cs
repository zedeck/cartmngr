using cartmngr_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cartmngr_api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger; 
        }

        //Returns JWT token after a successful signin
        [HttpGet(Name = "login")]
        public IActionResult login()
        {
            return View(); // return new string("testingToken");
        }

        //Returns JWT token after a successful signin
        //[HttpPost]
        //public string SignUp(Signup signup)
        //{
        //    return "Welcome " + signup.userName;
        //}
    }
}
