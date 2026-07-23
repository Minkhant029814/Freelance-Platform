using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.DTO
{
    public class CompletedProjectReviewDTO
    {
        public string ProjectTitle { get; set; }

        public decimal ProjectBudget { get; set; }

        public string ProjectStatus { get; set; }

        public  string ClientName { get; set; }
        
        public int Rating { get; set; }

        public string Comment { get; set; }

        public DateTime ProjectEndDate { get; set; }
    }
}
