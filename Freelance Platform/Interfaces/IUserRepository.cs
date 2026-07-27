using Freelance_Platform.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.Interfaces
{
    internal interface IUserRepository
    {
        int Register(User user);

        
        (int userId, string userType, string username) Authenticate(string username, string password);

       
        int? GetFreelancerId(int userId);

        
        int? GetClientId(int userId);
    }
}
