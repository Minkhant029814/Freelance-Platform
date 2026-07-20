using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.DTO
{
    public class AcceptedProjectDTO
    {
        public string BiddingStatus { get; set; }
        public string ProjectTitle { get; set; }
        public decimal ProjectBudget { get; set; }
        public string ClientName { get; set; }
        public DateTime BiddingDate { get; set; }
    }
}
