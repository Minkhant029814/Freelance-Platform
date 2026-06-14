using System;
using System.Collections.Generic;

namespace Freelance_Platform.model
{
    internal class Freelancer : User
    {
        
        public int FreelancerId { get; set; }
        public decimal HourlyRate { get; set; } 
        public string Expertise { get; set; } 

       

        public List<string> Skills { get; set; } 

       
        public Portfolio Portfolio { get; set; }

        
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

       
        public override void CreateProfile()
        {
           
            Console.WriteLine("Creating Profile with Database Transaction...");
        }

        public void BrowseProjects(List<Project> projects)
        {
            foreach (var p in projects)
            {
                Console.WriteLine(p.ProjectTitle);
            }
        }

        public void SubmitProposal(Bidding Bid)
        {
            Console.WriteLine("Bid Submitted");
        }

        public void ManageProject()
        {
            Console.WriteLine("Managing Projects");
        }
    }
}