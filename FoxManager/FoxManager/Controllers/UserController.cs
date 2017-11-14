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
        public IActionResult LoginHandler(Student studentFromForm)
        {
            if (UserService.AuthenticateUser(studentFromForm.StudentName))
            {
                return LocalRedirect("/user/" + studentFromForm.StudentName);
            }

            return LocalRedirect("/");
        }

        [HttpGet]
        [Route("/user/{userName}")]
        public IActionResult Profile(string userName)
        {
            var user = UserService.GetUserInfo(userName);
            var projects = UserService.GetUserProjects(userName);
            return View(user);
        }
    }
}
