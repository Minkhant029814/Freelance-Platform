using System;


namespace Freelance_Platform.model
{
    public class Project
    {
        public int ProjectId { get; set; }

       
        public string ProjectTitle { get; set; }
        public string Description { get; set; }
        public decimal BaselineBudget { get; set; }

     public int OverAllProgress { get; set; }
        public DateTime StartDate { get; set; }


        public DateTime SubmittedDate { get; set; }

        public DateTime CompletedDate { get; set; }
        public string CurrentStatus { get; set; }
        public DateTime EndDate { get; set; }

        public int BidCount { get; set; }
    }
}
