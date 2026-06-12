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

        public List<Project> GetAllProjectsList()
        {
            List<Project> projectList = new List<Project>();

          
            DataTable dt = projectRepo.AllProject();

          
            foreach (DataRow row in dt.Rows)
            {
                Project p = new Project();
                p.ProjectTitle = row["ProjectTitle"].ToString();
                p.Description = row["Description"].ToString();

               
                p.BaselineBudget = row["Budget"] != DBNull.Value ? Convert.ToDecimal(row["Budget"]) : 0;
                p.EndDate = Convert.ToDateTime(row["EndDate"]);

               
                p.CurrentStatus = (string) row["Status"];

                projectList.Add(p);
            }

            return projectList;
        }
    }
}
