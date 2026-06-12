using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.model
{
    internal class Project
    {
        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }
        public string Description { get; set; }
        public decimal BaselineBudget { get; set; }

        public DateTime StartDate { get; set; }


        public string CurrentStatus { get; set; }
        public DateTime EndDate { get; set; }
    }
}
