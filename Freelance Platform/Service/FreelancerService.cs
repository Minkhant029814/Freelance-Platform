using Freelance_Platform.DTO;
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

        public List<FreelancerCardDTO> GetFreelancerCards(string search = "")
        {
            return freelanerRepo.GetFreelancerCards(search);
        }

        public Freelancer FreelancerDetails(int freelancerId)
        {
            return freelanerRepo.FreelancerDetails(freelancerId);
        }

        public List<Project> BrowseProjects(string search)
        {
            return freelanerRepo.BrowseProjects(search);
        }

        public List<ProjectStatusDTO> GetBiddingProjectsByStatus(string status)
        {
            return freelanerRepo.GetBiddingProjectsByStatus(status);
        }

        //public List<ProjectStatusDTO> GetPendingProjects()
        //{
        //    return freelanerRepo.GetPendingProjects();
        //}

        public bool SetMileStones(int projectId,int FreelancerId,List<Milestone> ms)
        {
            return freelanerRepo.SetMileStones(projectId, FreelancerId, ms);
        }

        public List<ProjectWithMilestonesDTO> GetProjectsWithMilestones(int freelancerId)
        {
            return freelanerRepo.GetProjectWithMileStone(freelancerId);
        }

        public bool UpdateMileStoneProgress(int milestoneId,int newProgress,string newStatus)
        {
            return freelanerRepo.UpdateMileStoneProgress(milestoneId,newProgress,newStatus);
        }

        public bool SubmitCompletedProjects(int projectId)
        {
            return freelanerRepo.SubmitCompletedProjects(projectId);
        }
    }
}
