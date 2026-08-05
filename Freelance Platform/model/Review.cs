using System;


namespace Freelance_Platform.model
{
    public class Review
    {
        public int ReviewId { get; set; }

        public int ProjectId { get; set; }

        public int ClientId { get; set; }

        public int FreelancerId { get; set; }
        public string Comment { get; set; }
        public float Rating { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
