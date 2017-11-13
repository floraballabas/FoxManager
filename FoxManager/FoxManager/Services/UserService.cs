using FoxManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxManager.Models;

namespace FoxManager.Services
{
    public class UserService
    {
        private UserRepository UserRepository;

        public UserService(UserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public bool AuthenticateUser(string name)
        {
            return UserRepository.CheckUserExist(name);
        }

        public Student GetUserInfo(string name)
        {
            return UserRepository.GetUserInfo(name);
        }
    }
}