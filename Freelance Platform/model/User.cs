using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Freelance_Platform.model
{
    public  class User
    {
        
        public string Username { get; set; }
        public string Password { get; set; }

        public string Type { get; set; }

        public User(string username,string password,string type)
        {
            Username = username;
            Password = password;
            Type = type;
        }

       

        public virtual void Register()
        {

        }

        public virtual void Login()
        {

        }

        public virtual void CreateProfile()
        {

        }
    }
}
