using Freelance_Platform.DTO;
using Freelance_Platform.Interfaces;
using Freelance_Platform.model;
using Freelance_Platform.Repositories;
using Freelance_Platform.Session;
using System.Collections.Generic;


namespace Freelance_Platform.Service
{
    internal class FreelancerService
    {
        private readonly IFreelancerRepository _freelancerRepo;

        public FreelancerService() : this(new FreelancerRepository()) { }

        public FreelancerService(IFreelancerRepository freelancerRepo)
        {
            _freelancerRepo = freelancerRepo ?? throw new System.ArgumentNullException(nameof(freelancerRepo));
        }

        public bool CreateProfile(Freelancer freelancer, string profile)
        {
            if (freelancer == null) throw new System.ArgumentNullException(nameof(freelancer));
            return _freelancerRepo.CreateProfile(freelancer, profile);
        }

        public Freelancer DashboardInfo()
        {
            return _freelancerRepo.DashboardInfo(UserSession.FreelancerId);
        }

        public bool UpdateProfile(Freelancer freelancer, string profile)
        {
            return _freelancerRepo.UpdateProfile(freelancer, profile);
        }

        public List<FreelancerCardDTO> GetFreelancerCards(string search = "")
        {
            return _freelancerRepo.GetFreelancerCards(search);
        }

        public Freelancer FreelancerDetails(int freelancerId)
        {
            return _freelancerRepo.FreelancerDetails(freelancerId);
        }

        public List<Project> BrowseProjects(string search)
        {
            return _freelancerRepo.BrowseProjects(search);
        }

        public List<ProjectStatusDTO> GetBiddingProjectsByStatus(string status)
        {
            return _freelancerRepo.GetBiddingProjectsByStatus(status, UserSession.FreelancerId);
        }

        public List<ProjectStatusDTO> GetAcceptedProjects()
        {
            return _freelancerRepo.GetAcceptedProjects(UserSession.FreelancerId);
        }

        public bool SetMileStones(int projectId, int FreelancerId, List<Milestone> ms)
        {
            return _freelancerRepo.SetMileStones(projectId, FreelancerId, ms);
        }

        public bool HasMileStones(int projectId)
        {
            return _freelancerRepo.HasMileStone(projectId);
        }

        public List<ProjectWithMilestonesDTO> GetProjectsWithMilestones(int freelancerId)
        {
            return _freelancerRepo.GetProjectWithMileStone(freelancerId);
        }

        public bool UpdateMileStoneProgress(int milestoneId, int newProgress, string newStatus)
        {
            return _freelancerRepo.UpdateMileStoneProgress(milestoneId, newProgress, newStatus);
        }

        public bool SubmitCompletedProjects(int projectId)
        {
            return _freelancerRepo.SubmitCompletedProjects(projectId);
        }

        public List<CompletedProjectReviewDTO> ViewCompletedProject()
        {
            return _freelancerRepo.ViewCompletedProject(UserSession.FreelancerId);
        }
    }
}