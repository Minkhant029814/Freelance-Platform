using Freelance_Platform.DTO;
using Freelance_Platform.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.Interfaces
{
    internal interface IProjectRepository
    {
        bool PostProject(Project project,int clientId);
        List<Project> AllProjectsByClient(int clientId);
        List<Project> AllProject();
        List<Project> GetPlanningProjects(int clientId);
        List<AssignedProjectDTO> GetProjectsWithAssigned(int clientId);
        List<AssignedProjectDTO> GetForSubmittedReview(int clientId);
        List<AssignedProjectDTO> GetCompletedProjects(int clientId);
        bool CalculateProjectProgressRate(int projectId);
    }
}
