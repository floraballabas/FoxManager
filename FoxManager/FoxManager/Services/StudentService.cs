using FoxManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxManager.Models;

namespace FoxManager.Services
{
    public class StudentService
    {
        private StudentRepository StudentRepository;

        public StudentService(StudentRepository studentRepository)
        {
            StudentRepository = studentRepository;
        }

        public bool AuthenticateStudent(string name)
        {
            return StudentRepository.CheckStudentExist(name);
        }

        public Student GetStudentInfo(string name)
        {
            return StudentRepository.GetStudentInfo(name);
        }

        public List<Project> GetStudentProjects(string name)
        {
            return StudentRepository.GetStudentProjectList(name);
        }
    }
}