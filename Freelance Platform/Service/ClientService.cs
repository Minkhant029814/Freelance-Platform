using Freelance_Platform.model;
using Freelance_Platform.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.Service
{
    internal class ClientService
    {
        private readonly ClientRepository clientRepo = new ClientRepository();


        public bool CreateProfile(int uid,string email,string phone,string address,string profile)
        {
            return clientRepo.CreateProfile(uid,email,phone,address,profile);
        }

        public Client GetClientDetails(int clientId)
        {
            return clientRepo.GetClientDetails(clientId);
        }

        public bool UpdateProfile(Client client)
        {
            return clientRepo.UpdateProfile(client);
        }

        public bool AcceptFreelancers(int bidId,int projectId)
        {
            return clientRepo.AcceptFreelancer(bidId, projectId);
        }

        public bool RejectFreelancer(int bidId)
        {
            return clientRepo.RejectFreelancer(bidId);
        }

        //Approve & Complete Project
        public bool ApproveAndCompleteProject(int projectId)
        {
            return clientRepo.ApproveAndCompleteProject(projectId);
        }

        //Rating Freelancer
        public bool RatingFreelancer( Review review)
        {
            return clientRepo.RatingFreelancer(  review);
        }
    }
}
