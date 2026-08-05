using Freelance_Platform.DTO;

using System.Collections.Generic;

namespace Freelance_Platform.model
{
    public  class Freelancer : User
    {
        
        public int FreelancerId { get; set; }
        public decimal HourlyRate { get; set; } 
        public string Expertise { get; set; } 

       
       

        public List<string> Skills { get; set; } 

       
        public Portfolio Portfolio { get; set; }

        public float AverageRating { get; set; }

        public int TotalReviews { get; set; }

        public List<ReviewDTO> Reviews { get; set; }


        public Freelancer() : base("", "", "")
        {
            Skills = new List<string>();
            Portfolio = new Portfolio();
        }

        
        public Freelancer(string username, string password, string type) : base(username, password, type)
        {
            Skills = new List<string>();
            Portfolio = new Portfolio();
        }

       
        
    }
}