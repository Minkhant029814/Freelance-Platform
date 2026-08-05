using Freelance_Platform.Connection;
using Freelance_Platform.DTO;
using Freelance_Platform.Interfaces;
using Freelance_Platform.model;
using Freelance_Platform.Repositories;
using Freelance_Platform.Session;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.Service
{
    internal class ProjectService
    {

        private readonly IProjectRepository _projectRepo;

        public ProjectService(): this(new ProjectRepository()) { }
        public ProjectService(IProjectRepository projectRepo)
        {
            _projectRepo = projectRepo ?? throw new ArgumentException(nameof(projectRepo));
        }


        public bool PostProject(Project project,int clientId)
        {
            if (project == null) throw new ArgumentException(nameof(project));
            return _projectRepo.PostProject(project,clientId);

        }

        public List<Project> GetAllProjectsListById()
        {
            return _projectRepo.AllProjectsByClient(Convert.ToInt32(UserSession.ClientId));
        }

        public List<Project> GetAllProjects()
        {
            return _projectRepo.AllProject();
        }



        public List<Project> GetPlanningProjects()
        {
            return _projectRepo.GetPlanningProjects(UserSession.ClientId);
        }

        public List<AssignedProjectDTO> GetProjectsAssigned()
        {
            return _projectRepo.GetProjectsWithAssigned(UserSession.ClientId);
        }

        public List<AssignedProjectDTO> GetForSubmittedReview()
        {
            return _projectRepo.GetForSubmittedReview(UserSession.ClientId);
        }

        public List<AssignedProjectDTO> GetCompletedProjects()
        {
            return _projectRepo.GetCompletedProjects(UserSession.ClientId);
        }

        public bool CalculateProjectProgressRate(int projectId)
        {
            return _projectRepo.CalculateProjectProgressRate(projectId);
        }
    }
}
