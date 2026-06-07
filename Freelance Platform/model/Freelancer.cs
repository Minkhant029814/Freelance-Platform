using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.model
{
    internal class Freelancer : User
    {
        public int FreelancerId { get; set; }
        public List<string> Skills { get; set; }
        public string Expertise { get; set; }
        public List<string> PastWork { get; set; }
        public Portfolio Portfolio { get; set; }
        
        public Freelancer(string username,string password):base(username, password)
        {
            Skills = new List<string>();
            PastWork = new List<string>();
        }
        public override void CreateProfile()
        {
            Console.WriteLine("some thins");
        }

        public void BrowseProjects(List<Project> projects)
        {
            foreach(var p in projects)
            {
                Console.WriteLine(p.ProjectTitle);
            }
        }

        public void SubmitProposal(Bidding Bid)
        {
            Console.WriteLine("Bid Subbmitted");
        }

        public void ManageProject()
        {
            Console.WriteLine("Managine Projects");
        }
    }
}
