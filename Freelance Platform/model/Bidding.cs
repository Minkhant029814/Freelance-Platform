using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.model
{
    internal class Bidding
    {
        public int BiddingId { get; set; }
        public int ProjectId { get; set; }

        public int FreelancerId { get; set; }
        public int ClientId { get; set; }

        public decimal BidAmount { get; set; }
        public DateTime SubmissionDate { get; set; }
    }
}
