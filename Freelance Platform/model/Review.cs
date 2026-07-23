using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.model
{
    internal class Review
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
