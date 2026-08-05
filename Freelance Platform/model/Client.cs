

namespace Freelance_Platform.model
{
    internal class Client : User
    {
        public int ClientId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        
        public string Address { get; set; }

        public string ProfilePic { get; set; }
        public Client(string username, string password,string type) : base(username, password,type)
        {

        }

       
    }
}
