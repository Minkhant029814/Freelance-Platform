using Freelance_Platform.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.DTO
{
    public class AssignedProjectDTO
    {
        public AssignedProjectDTO()
        {
            Freelancer = new Freelancer();
            Project = new Project();
            Review = new Review();
        }

       public Project Project { get; set; }
        public Freelancer Freelancer { get; set; }

        public Review Review { get; set; }


        
    }
}
