using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.model
{
    internal class UserFactory
    {
        public static User CreateUser(string type,string username,string password)
        {
            if(type.ToLower() == "freelancer")
            {
                return new Freelancer(username, password,type);
            }
            return new Client(username, password,type);
        }

            
    }
}
