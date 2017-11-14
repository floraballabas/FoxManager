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
        private StudentService StudentService;

        public StudentController(StudentService studentService)
        {
            StudentService = studentService;
        }

        [HttpPost]
        public IActionResult LoginHandler(Student studentFromForm)
        {
            if (StudentService.AuthenticateStudent(studentFromForm.StudentName))
            {
                return LocalRedirect("/student/" + studentFromForm.StudentName);
            }

            return LocalRedirect("/");
        }

        [HttpGet]
        [Route("/student/{studentName}")]
        public IActionResult Student(string studentName)
        {
            var student = StudentService.GetStudentInfo(studentName);
            var projects = StudentService.GetStudentProjects(studentName);
            return View(student);
        }
    }
}
