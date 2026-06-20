using Freelance_Platform.model;
using Freelance_Platform.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.Service
{
    internal class FreelancerService
    {
        private readonly FreelancerRepository freelanerRepo = new FreelancerRepository();

        public FreelancerService()
        {

        }

        public bool CreateProfile(Freelancer freelancer,string profile)
        {
            return freelanerRepo.CreateProfile(freelancer,profile);
        }


        public Freelancer DashboardInfo()
        {
            return freelanerRepo.DashboardInfo();
        }

        public bool UpdateProfile(Freelancer freelancer,string profile)
        {
            return freelanerRepo.UpdateProfile(freelancer,profile);
        }
       
    }
}
