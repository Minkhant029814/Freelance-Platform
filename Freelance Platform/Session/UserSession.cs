using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.Session
{
    internal static class UserSession
    {
        // --- Basic Info ---
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string UserType { get; set; } 
        public static bool IsLoggedIn { get; set; }

        
        // --- Changeable value based on role ---
        public static int FreelancerId { get; set; }
        public static int ClientId { get; set; }

       


        // --- Logout  Method ---
        public static void Logout()
        {
            UserId = 0;
            Username = null;
            UserType = null;
            IsLoggedIn = false;
            FreelancerId = 0;
            ClientId = 0;

        }
    }
}
