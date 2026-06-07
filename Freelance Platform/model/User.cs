using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Freelance_Platform.model
{
    internal abstract class User
    {
        
        public string Username { get; set; }
        public string Password { get; set; }

        protected User(string username,string password)
        {
            Username = username;
            Password = password;
        }

        public bool ValidatePassword(string password)
        {
            if(password.Length <8 || password.Length > 12)
            {
                return false;
            }
            bool hasUpper = Regex.IsMatch(password, "[A-Z]");
            bool hasLower = Regex.IsMatch(password, "[a-z]");

            return hasUpper && hasLower;
        }

        public virtual void Register()
        {

        }

        public virtual void Login()
        {

        }

        public abstract void CreateProfile();
    }
}
