using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxManager.Services;
using FoxManager.Models;

namespace FoxManager.Controllers
{
    [Route("/user")]
    public class UserController : Controller
    {
        private UserService UserService;

        public UserController(UserService userService)
        {
            UserService = userService;
        }

        [HttpPost]
        public IActionResult LoginHandler(Student userFromForm)
        {
            if (UserService.AuthenticateUser(userFromForm.StudentName))
            {
                return LocalRedirect("/user/" + userFromForm.StudentName);
            }

            return LocalRedirect("/");
        }

        [HttpGet]
        [Route("/user/{userName}")]
        public IActionResult Profile(string userName)
        {
            var user = UserService.GetUserInfo(userName);
            return View(user);
        }
    }
}
