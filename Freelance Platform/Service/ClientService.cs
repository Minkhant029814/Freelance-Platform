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
    }
}
