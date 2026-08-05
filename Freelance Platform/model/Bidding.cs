using System;


namespace Freelance_Platform.model
{
    public class Bidding
    {
        public int BiddingId { get; set; }
        public int ProjectId { get; set; }

        public int FreelancerId { get; set; }
        public int ClientId { get; set; }

        public decimal BidAmount { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public DateTime SubmissionDate { get; set; }
    }
}
