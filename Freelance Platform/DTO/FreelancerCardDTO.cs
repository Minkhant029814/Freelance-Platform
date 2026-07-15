using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.DTO
{
    public class FreelancerCardDTO
    {
        public int FreelancerId { get; set; }

        public string OwnerName { get; set; }

        public string ProfessionalTitle { get; set; }

        public string Expertise { get; set; }

        public decimal HourlyRate { get; set; }

        public string ProfilePic { get; set; }

        public string Biography { get; set; }

        public List<string> Skills { get; set; } = new List<string>();
    }
}
