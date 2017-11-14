using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxManager.Services;
using FoxManager.Models;

namespace FoxManager.Controllers
{
    [Route("/student")]
    public class StudentController : Controller
    {
        private StudentService UserService;

        public StudentController(StudentService userService)
        {
            UserService = userService;
        }

        [HttpPost]
        public IActionResult LoginHandler(Student studentFromForm)
        {
            if (UserService.AuthenticateStudent(studentFromForm.StudentName))
            {
                return LocalRedirect("/student/" + studentFromForm.StudentName);
            }

            return LocalRedirect("/");
        }

        [HttpGet]
        [Route("/student/{studentName}")]
        public IActionResult Profile(string studentName)
        {
            var user = UserService.GetStudentInfo(studentName);
            var projects = UserService.GetStudentProjects(studentName);
            return View(user);
        }
    }
}
