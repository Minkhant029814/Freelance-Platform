using Freelance_Platform.Interfaces;
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
        private readonly IClientRepository _clientRepo;

        public ClientService() :this (new ClientRepository())
        {

        }

        public ClientService(IClientRepository clientRepo)
        {
            _clientRepo = clientRepo ?? throw new ArgumentException(nameof(clientRepo));
        }

        public bool CreateProfile(int uid,string email,string phone,string address,string profile)
        {
            return _clientRepo.CreateProfile(uid,email,phone,address,profile);
        }

        public Client GetClientDetails(int clientId)
        {
            return _clientRepo.GetClientDetails(clientId);
        }

        
        public bool UpdateProfile(Client client, int userId)
        {
            if (client == null) throw new ArgumentException(nameof(client));
            return _clientRepo.UpdateProfile(client,userId);
        }

        public bool AcceptFreelancers(int bidId,int projectId)
        {
            return _clientRepo.AcceptFreelancer(bidId, projectId);
        }

        public bool RejectFreelancer(int bidId)
        {
            return _clientRepo.RejectFreelancer(bidId);
        }

        //Approve & Complete Project
        public bool ApproveAndCompleteProject(int projectId)
        {
            return _clientRepo.ApproveAndCompleteProject(projectId);
        }

        //Rating Freelancer
        public bool RatingFreelancer( Review review)
        {
            return _clientRepo.RatingFreelancer(  review);
        }
    }
}
