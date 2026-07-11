using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.DTO
{
    public class FreelancerBidDTO
    {
        public int ProjectId { get; set; }

        public int BidId { get; set; }
        public string OwnerName { get; set; }

        public string ProfilePic { get; set; }
        public string ProfessionalTitle { get; set; }

        // Biddings Table ကနေလာမယ့် Data များ
        public decimal BidAmount { get; set; }
        public string Message { get; set; }
       
    }
}
