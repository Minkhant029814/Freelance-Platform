using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.model
{
    public class Milestone
    {
        public int MilestoneId { get; set; }
        public int ProjectId { get; set; }
        public int FreelancerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public int Progress { get; set; }

        public int OverAllProgress { get; set; }
        public string Status { get; set; } // PENDING, IN_PROGRESS, COMPLETED
    }
}
