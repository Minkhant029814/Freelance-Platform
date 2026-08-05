

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

       

       
    }
}
