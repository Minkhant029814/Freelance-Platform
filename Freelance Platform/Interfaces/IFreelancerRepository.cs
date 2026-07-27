using Freelance_Platform.DTO;
using Freelance_Platform.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.Interfaces
{
    internal interface IFreelancerRepository
    {
        bool CreateProfile(Freelancer freelancer, string profile, int userId);
        bool UpdateProfile(Freelancer freelancer, string profile);
        Freelancer DashboardInfo(int freelancerId);
        List<FreelancerCardDTO> GetFreelancerCards(string searchTerm = "");
        Freelancer FreelancerDetails(int freelancerId);
        List<Project> BrowseProjects(string searchTerm = "");
        List<ProjectStatusDTO> GetBiddingProjectsByStatus(string status, int freelancerId);
        List<ProjectStatusDTO> GetAcceptedProjects(int freelancerId);
        bool SetMileStones(int projectId, int freelancerId, List<Milestone> milestones);
        bool HasMileStone(int projectId);
        List<ProjectWithMilestonesDTO> GetProjectWithMileStone(int freelancerId);
        bool UpdateMileStoneProgress(int milestoneId, int newProgress, string newStatus);
        bool SubmitCompletedProjects(int projectId);
        List<CompletedProjectReviewDTO> ViewCompletedProject(int freelancerId);
    }
}
