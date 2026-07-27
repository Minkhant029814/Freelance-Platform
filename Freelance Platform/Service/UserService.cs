using Freelance_Platform.Interfaces;
using Freelance_Platform.model;
using Freelance_Platform.Repositories;
using Freelance_Platform.Session;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.Service
{

    internal class UserService
    {
        private readonly IUserRepository _userReop;

        public UserService() : this(new UserRepository()) { }

        public UserService(IUserRepository userRepo)
        {
            _userReop = userRepo ?? throw new ArgumentException(nameof(userRepo));
        }
        public int Register(User user)
        {

            if (user == null) throw new ArgumentException(nameof(user));
            return _userReop.Register(user);
        }

        public bool Login(string name, string pass)
        {

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(pass))
            {
                return false;
            }
            try
            {
                var (userId, userType, username) = _userReop.Authenticate(name, pass);
                if(userId == 0)
                {
                    return false;
                }
                UserSession.UserId = userId;
                UserSession.Username = username;
                UserSession.UserType = userType;
                UserSession.IsLoggedIn = true;

                if (string.Equals(userType, "Freelancer", StringComparison.OrdinalIgnoreCase))
                {
                    var fid = _userReop.GetFreelancerId(userId);
                    if (fid.HasValue) UserSession.FreelancerId = fid.Value;
                } else if (string.Equals(userType, "Client", StringComparison.OrdinalIgnoreCase))
                {
                    var cid = _userReop.GetClientId(userId);
                    if (cid.HasValue) UserSession.ClientId = cid.Value;
                }
                return true;
            } 
            catch (Exception ex)
            {

                Debug.WriteLine($"Login Failed :{ex.Message}");
                return false;
            }
        }

       


    }
}
