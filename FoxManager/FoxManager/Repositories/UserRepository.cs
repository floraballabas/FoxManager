using FoxManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxManager.Models;

namespace FoxManager.Repositories
{
    public class UserRepository
    {
        FoxManagerContext FoxManagerContext;

        public UserRepository(FoxManagerContext foxManagerContext)
        {
            FoxManagerContext = foxManagerContext;
        }

        public bool CheckUserExist(string name)
        {
            var user = FoxManagerContext.Students.FirstOrDefault(x => x.StudentName.Equals(name));
            return user != null ? true : false;
        }

        public Student GetUserInfo(string name)
        {
            return FoxManagerContext.Students.FirstOrDefault(y => y.StudentName.Equals(name));
        }

        public List<Project> GetUserProjectList(string name)
        {
            return FoxManagerContext.Projects.Where(p => p.Student.StudentName.Equals(name))
                .ToList();
        }
    }
}