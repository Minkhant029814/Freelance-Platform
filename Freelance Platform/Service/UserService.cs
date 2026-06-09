using Freelance_Platform.model;
using Freelance_Platform.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.Service
{

    internal class UserService
    {
        private readonly UserRepository userRepo= new UserRepository();

        public int Register(User user)
        {

            int result = userRepo.Register(user);
            return result;
        }

        public bool Login(string name,string pass)
        {

            return userRepo.Login(name,pass);
        }

       


    }
}
