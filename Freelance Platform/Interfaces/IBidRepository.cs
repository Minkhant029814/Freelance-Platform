using Freelance_Platform.DTO;
using Freelance_Platform.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.Interfaces
{
    public interface IBidRepository
    {
        bool SubmitBid(Bidding bid);
        bool CancelBid(int projectId, int freelancerId);
        bool HasUserBidded(int projectId, int freelancerId);
        List<BidProjectModelDTO> GetBidProjects(int clientId);
        List<FreelancerBidDTO> GetFreelancerBids(int projectId);
    }
}
