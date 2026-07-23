using Freelance_Platform.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.DTO
{
    public class ProjectWithMilestonesDTO
    {
        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }
        public DateTime ProjectEndDate { get; set; }
        public string ClientName { get; set; }

        public int OverAllProgress { get; set; }

        public List<Milestone> Milestones { get; set; } = new List<Milestone>();
    }
}
