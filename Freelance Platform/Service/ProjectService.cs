using Freelance_Platform.Connection;
using Freelance_Platform.model;
using Freelance_Platform.Repositories;
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

        private readonly ProjectRepository projectRepo;

        public ProjectService()
        {
            this.projectRepo = new ProjectRepository();
        }


        public bool PostProject(Project project)
        {
            return projectRepo.PostProject(project);

        }

        public List<Project> GetAllProjectsListById()
        {
            return projectRepo.AllProjectById();
        }

        public List<Project> GetAllProjects()
        {
            return projectRepo.AllProject();
        }
    }
}
