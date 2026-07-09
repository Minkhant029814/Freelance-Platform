using Freelance_Platform.model;
using Freelance_Platform.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.Service
{
    public class BidService
    {
        private readonly BidRepository bidRepository = new BidRepository();

        public bool BidSubmit(Bidding bid)
        {
            return bidRepository.SubmitBid(bid);
        }

        public bool CancelSubmit(int projectId,int freelancerId)
        {
            return bidRepository.CancelBid(projectId, freelancerId);
        }

        public bool HasUserBidded(int projectId,int freelancerId)
        {
            return bidRepository.HasUserBidded(projectId, freelancerId);
        }
    }
}
