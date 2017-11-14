using FoxManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxManager.Models;

namespace FoxManager.Repositories
{
    public class StudentRepository
    {
        FoxManagerContext FoxManagerContext;

        public StudentRepository(FoxManagerContext foxManagerContext)
        {
            FoxManagerContext = foxManagerContext;
        }

        public bool CheckStudentExist(string name)
        {
            var user = FoxManagerContext.Students.FirstOrDefault(x => x.StudentName.Equals(name));
            return user != null ? true : false;
        }

        public Student GetStudentInfo(string name)
        {
            return FoxManagerContext.Students.FirstOrDefault(y => y.StudentName.Equals(name));
        }

        public List<Project> GetStudentProjectList(string name)
        {
            return FoxManagerContext.Projects.Where(p => p.Student.StudentName.Equals(name))
                .ToList();
        }
    }
}