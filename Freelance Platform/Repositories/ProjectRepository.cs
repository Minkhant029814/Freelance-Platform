using Freelance_Platform.Connection;
using Freelance_Platform.DTO;
using Freelance_Platform.model;
using Freelance_Platform.Session;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows;

namespace Freelance_Platform.Repositories
{
    internal class ProjectRepository
    {

        private readonly dbConnect dbconnect = new dbConnect();

       
        public bool PostProject(Project project)
        {

            try
            {

                string query = "Insert into projects (ClientId,ProjectTitle,Description,Budget,StartDate,EndDate,Status) values" +
                " (@clientId,@title,@desc,@budget,@startDate,@endDate,'PLANNING')";
                MySqlParameter[] ps =
                {
                new MySqlParameter("@clientId",UserSession.ClientId),
                new MySqlParameter("@title",project.ProjectTitle),
                new MySqlParameter("@desc",project.Description),
                new MySqlParameter("@budget",project.BaselineBudget),
                new MySqlParameter("@startDate",project.StartDate),
                new MySqlParameter("@endDate",project.EndDate),

            };

                return dbconnect.ExecuteCommand(query, ps);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public List<Project> AllProjectById()
        {
            string query = "Select ProjectTitle,Description,Budget,EndDate,Status from projects where ClientId = @clientId";

            MySqlParameter[] ps =
            {
                new MySqlParameter("@clientId",UserSession.ClientId)
            };

          DataTable dt =  dbconnect.GetData(query, ps);
            List<Project> projects = new List<Project>();

            foreach(DataRow row in dt.Rows)
            {
                Project p = new Project
                {
                    ProjectTitle = row["ProjectTitle"].ToString(),
                    Description = row["Description"].ToString(),
                    BaselineBudget = Convert.ToDecimal(row["Budget"]),
                    EndDate = Convert.ToDateTime(row["EndDate"]),
                    CurrentStatus = row["Status"].ToString(),
                };

                projects.Add(p);
                
            }

            return projects;
        }


       


        public List<Project> AllProject()
        {
            string query = "SELECT * FROM Projects WHERE STATUS IN ('PLANNING', 'ON_HOLD');";

            using (MySqlConnection conn = dbconnect.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
             
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                List<Project> projects = new List<Project>();

                foreach(DataRow row in dt.Rows)
                {
                    Project p = new Project
                    {
                        ProjectId = Convert.ToInt32(row["ProjectId"]),
                        ClientId = Convert.ToInt32(row["ClientId"]),
                        ProjectTitle = row["ProjectTitle"].ToString(),
                        Description = row["Description"].ToString(),
                        BaselineBudget = Convert.ToDecimal(row["Budget"]),
                        EndDate = Convert.ToDateTime(row["EndDate"]),
                        CurrentStatus = row["Status"].ToString()



                    };
                    projects.Add(p);

                };



                return projects;
            }


        }


        
        //Get project By Status
        public List<Project> GetPlanningProjects()
        {
            
              string   query = @"
                        SELECT 
        p.ProjectTitle, 
        p.ProjectId,
        p.Description, 
        p.Budget, 
        p.StartDate, 
        p.Status,
        COUNT(b.BidId) AS BidCount
    FROM projects p 
    LEFT JOIN biddings b ON p.ProjectId = b.ProjectId 
    WHERE p.ClientId = @clientId 
      AND p.Status = 'PLANNING'
    GROUP BY p.ProjectId";
            
            
            MySqlParameter[] para =
            {
                new MySqlParameter("@clientId",UserSession.ClientId),
               
            };
            DataTable dt = dbconnect.GetData(query, para);
            List<Project> projects = new List<Project>();

            foreach (DataRow row in dt.Rows)
            {
                Project p = new Project
                {
                    ProjectId = Convert.ToInt32(row["ProjectId"]),
                    ProjectTitle = row["ProjectTitle"].ToString(),
                    Description = row["Description"].ToString(),
                    BaselineBudget = Convert.ToDecimal(row["Budget"]),
                    StartDate = Convert.ToDateTime(row["StartDate"]),
                    CurrentStatus = row["Status"].ToString(),
                    BidCount = Convert.ToInt32(row["BidCount"])
                };

                projects.Add(p);

            }

            return projects;
        }

        //Get completed Project with assigned Freelancers

        public List<AssignedProjectDTO> GetProjectsWithAssigned()
        {
            string query = @"SELECT 
    p.ProjectId, 
    p.ProjectTitle, 
    p.Description, 
    p.Budget, 
    p.EndDate,
    p.Status,
    p.OverAllProgress,
    f.FreelancerId, 
    f.HourlyRate,
    po.OwnerName AS FreelancerName, 
    po.ProfilePic,
    po.ProfessionalTitle 
FROM projects p
INNER JOIN biddings b ON p.ProjectId = b.ProjectId
INNER JOIN freelancers f ON b.FreelancerId = f.FreelancerId
INNER JOIN portfolios po ON f.FreelancerId = po.FreelancerId
WHERE p.ClientId = @clientId AND p.Status = 'IN_PROGRESS' 
  AND b.Status = 'Accepted';";

            MySqlParameter[] ps =
            {
                new MySqlParameter("@clientId",UserSession.ClientId),
                
            };
            DataTable dt = dbconnect.GetData(query,ps );
            List<AssignedProjectDTO> projects = new List<AssignedProjectDTO>();

            foreach (DataRow row in dt.Rows)
            {
                AssignedProjectDTO p = new AssignedProjectDTO();
                p.Freelancer.HourlyRate = Convert.ToDecimal(row["HourlyRate"]);
                p.Freelancer.Portfolio.OwnerName = row["FreelancerName"].ToString();
                p.Freelancer.Portfolio.ProfessionalTitle = row["ProfessionalTitle"].ToString();
                p.Freelancer.Portfolio.Profile = row["ProfilePic"].ToString();
                
                p.Project.EndDate = Convert.ToDateTime(row["EndDate"]);
                p.Project.ProjectTitle = row["ProjectTitle"].ToString();
                p.Project.Description = row["Description"].ToString();
                p.Project.BaselineBudget = Convert.ToDecimal(row["Budget"]);
                p.Project.OverAllProgress = Convert.ToInt32(row["OverAllProgress"]);
                p.Project.CurrentStatus = row["Status"].ToString();
                projects.Add(p);

            }

            return projects;
        }


        public List<AssignedProjectDTO> GetForSubmittedReview()
        {
            string query = @"SELECT 
    p.ProjectId, 
    p.ProjectTitle, 
    p.Description, 
    p.Budget, 
    p.SubmittedDate,
    p.Status,
    p.OverAllProgress,
    f.FreelancerId, 
    f.HourlyRate,
    po.OwnerName AS FreelancerName, 
    po.ProfilePic,
    po.ProfessionalTitle 
FROM projects p
INNER JOIN biddings b ON p.ProjectId = b.ProjectId
INNER JOIN freelancers f ON b.FreelancerId = f.FreelancerId
INNER JOIN portfolios po ON f.FreelancerId = po.FreelancerId
WHERE p.ClientId = @clientId AND p.Status = 'ON_HOLD' 
  AND b.Status = 'Accepted';";

            MySqlParameter[] ps =
            {
                new MySqlParameter("@clientId",UserSession.ClientId),

            };
            DataTable dt = dbconnect.GetData(query, ps);
            List<AssignedProjectDTO> projects = new List<AssignedProjectDTO>();

            foreach (DataRow row in dt.Rows)
            {
                AssignedProjectDTO p = new AssignedProjectDTO();
                p.Freelancer.HourlyRate = Convert.ToDecimal(row["HourlyRate"]);
                p.Freelancer.Portfolio.OwnerName = row["FreelancerName"].ToString();
                p.Freelancer.Portfolio.ProfessionalTitle = row["ProfessionalTitle"].ToString();
                p.Freelancer.Portfolio.Profile = row["ProfilePic"].ToString();

                p.Project.SubmittedDate = Convert.ToDateTime(row["SubmittedDate"]);
                p.Project.ProjectId = Convert.ToInt32(row["ProjectId"]);
                p.Project.ProjectTitle = row["ProjectTitle"].ToString();
                p.Project.Description = row["Description"].ToString();
                p.Project.BaselineBudget = Convert.ToDecimal(row["Budget"]);
                p.Project.OverAllProgress = Convert.ToInt32(row["OverAllProgress"]);
                p.Project.CurrentStatus = row["Status"].ToString();
                projects.Add(p);

            }

            return projects;

        }

        //Get Completed Projects By Clients
        public List<AssignedProjectDTO> GetCompletedProjects()
        {
            string query = @"SELECT 
    p.ProjectId, 
    p.ProjectTitle, 
    p.Description, 
    p.Budget, 
    p.CompletedDate,
    p.Status,
    f.FreelancerId, 
    f.HourlyRate,
    po.OwnerName AS FreelancerName, 
    po.ProfilePic,
    po.ProfessionalTitle,
    r.ReviewId,
    r.Rating,
    r.Comment
FROM projects p
INNER JOIN biddings b ON p.ProjectId = b.ProjectId
INNER JOIN freelancers f ON b.FreelancerId = f.FreelancerId
INNER JOIN portfolios po ON f.FreelancerId = po.FreelancerId
LEFT JOIN reviews r ON p.ProjectId = r.ProjectId AND r.ClientId = @clientId
WHERE p.ClientId = @clientId AND p.Status = 'COMPLETED' 
  AND b.Status = 'Accepted'
ORDER BY p.CompletedDate DESC;";

            MySqlParameter[] ps =
            {
        new MySqlParameter("@clientId", UserSession.ClientId),
    };

            DataTable dt = dbconnect.GetData(query, ps);
            List<AssignedProjectDTO> projects = new List<AssignedProjectDTO>();

            foreach (DataRow row in dt.Rows)
            {
                AssignedProjectDTO p = new AssignedProjectDTO();

                // Freelancer Info
                p.Freelancer.FreelancerId = Convert.ToInt32(row["FreelancerId"]);
                p.Freelancer.HourlyRate = Convert.ToDecimal(row["HourlyRate"]);
                p.Freelancer.Portfolio.OwnerName = row["FreelancerName"].ToString();
                p.Freelancer.Portfolio.ProfessionalTitle = row["ProfessionalTitle"].ToString();
                p.Freelancer.Portfolio.Profile = row["ProfilePic"].ToString();

                // Project Info
               
                p.Project.ProjectId = Convert.ToInt32(row["ProjectId"]);
                p.Project.ProjectTitle = row["ProjectTitle"].ToString();
                p.Project.Description = row["Description"].ToString();
                p.Project.BaselineBudget = Convert.ToDecimal(row["Budget"]);
                p.Project.CurrentStatus = row["Status"].ToString();

                if (row["CompletedDate"] != DBNull.Value && row["CompletedDate"] != null)
                {
                    p.Project.CompletedDate = Convert.ToDateTime(row["CompletedDate"]);
                }
                else
                {
                    p.Project.CompletedDate = DateTime.MinValue; // Data မရှိသေးပါက Default တန်ဖိုးထားရန်
                }


                if (row["ReviewId"] != DBNull.Value)
                {
                    p.Review.ReviewId = Convert.ToInt32(row["ReviewId"]);
                    p.Review.Rating = Convert.ToSingle(row["Rating"]); 
                    p.Review.Comment = row["Comment"].ToString();
                }
                else
                {
                    p.Review.ReviewId = 0; 
                }

                projects.Add(p);
            }

            return projects;
        }

        //Calculation Progress Rate for onGoing (In_Progress) projects

        public bool CalculateProjectProgressRate(int projectId)
        {
            
            string getMilestonesQuery = "SELECT Weight, Progress FROM milestones WHERE ProjectId = @pId";
            MySqlParameter[] pParams = { new MySqlParameter("@pId", projectId) };
            DataTable dt = dbconnect.GetData(getMilestonesQuery, pParams);

            double totalWeightedProgress = 0;
            double totalWeight = 0;

            foreach (DataRow row in dt.Rows)
            {
                double weight = Convert.ToDouble(row["Weight"]);
                double progress = Convert.ToDouble(row["Progress"]);

                totalWeightedProgress += (progress * weight);
                totalWeight += weight;
            }

            int overallProgress = 0;
            if (totalWeight > 0)
            {
                overallProgress = (int)(totalWeightedProgress / totalWeight);
            }

           
            string updateProjectQuery = "UPDATE projects SET OverallProgress = @overall WHERE ProjectId = @pId";
            MySqlParameter[] projParams = {
        new MySqlParameter("@overall", overallProgress),
        new MySqlParameter("@pId", projectId)
    };

            return dbconnect.ExecuteCommand(updateProjectQuery, projParams);
        }

    }
}
