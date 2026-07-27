using Freelance_Platform.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.Interfaces
{
    internal interface IClientRepository
    {
        bool CreateProfile(int uid, string email, string phone, string address, string profile);
        Client GetClientDetails(int clientId);
        bool UpdateProfile(Client client, int userId);
        bool AcceptFreelancer(int bidId, int projectId);
        bool RejectFreelancer(int bidId);
        bool ApproveAndCompleteProject(int projectId);
        bool RatingFreelancer(Review review);
    }
}
