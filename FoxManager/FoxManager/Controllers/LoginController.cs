using Microsoft.AspNetCore.Mvc;
using FoxManager.Repositories;

namespace FoxManager.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}