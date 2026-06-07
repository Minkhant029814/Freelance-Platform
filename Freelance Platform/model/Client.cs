using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.model
{
    internal class Client : User
    {
        public int ClientId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        
        public string Address { get; set; }
        public Client(string username, string password) : base(username, password)
        {

        }

        public override void CreateProfile()
        {
            throw new NotImplementedException();
        }

        public void ViewFreelanceProfile()
        {
            Console.WriteLine("Vewing freelancer profile..");
        }

        public void PostProject (Project project)
        {
            Console.WriteLine("Project posted...");
        }

        public void LeaveReview()
        {
            Console.WriteLine("Review Submitted..");
        }
    }
}
