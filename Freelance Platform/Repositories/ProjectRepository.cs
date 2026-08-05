using Freelance_Platform.Connection;
using Freelance_Platform.DTO;
using Freelance_Platform.Interfaces;
using Freelance_Platform.model;
using Freelance_Platform.Session;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;



namespace Freelance_Platform.Repositories
{
    internal class ProjectRepository : IProjectRepository
    {
        private readonly dbConnect dbconnect = new dbConnect();

        public bool PostProject(Project project,int clientId)
        {
            if (project == null) throw new ArgumentNullException(nameof(project));

            try
            {
                string query = "INSERT INTO projects (ClientId,ProjectTitle,Description,Budget,StartDate,EndDate,Status) " +
                               "VALUES (@clientId,@title,@desc,@budget,@startDate,@endDate,'PLANNING')";
                MySqlParameter[] ps =
                {
                    new MySqlParameter("@clientId",clientId),
                    new MySqlParameter("@title", project.ProjectTitle),
                    new MySqlParameter("@desc", project.Description),
                    new MySqlParameter("@budget", project.BaselineBudget),
                    new MySqlParameter("@startDate", project.StartDate),
                    new MySqlParameter("@endDate", project.EndDate),
                };

                return dbconnect.ExecuteCommand(query, ps);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"PostProject failed: {ex}");
                return false;
            }
        }

        public List<Project> AllProjectsByClient(int clientId)
        {
            string query = "SELECT ProjectTitle,Description,Budget,EndDate,Status FROM projects WHERE ClientId = @clientId";
            MySqlParameter[] ps = { new MySqlParameter("@clientId", clientId) };

            DataTable dt = dbconnect.GetData(query, ps);
            var projects = new List<Project>();

            if (dt == null) return projects;

            foreach (DataRow row in dt.Rows)
            {
                var p = new Project
                {
                    ProjectTitle = row["ProjectTitle"]?.ToString() ?? string.Empty,
                    Description = row["Description"]?.ToString() ?? string.Empty,
                    BaselineBudget = row["Budget"] != DBNull.Value ? Convert.ToDecimal(row["Budget"]) : 0m,
                    EndDate = row["EndDate"] != DBNull.Value ? Convert.ToDateTime(row["EndDate"]) : DateTime.MinValue,
                    CurrentStatus = row["Status"]?.ToString() ?? string.Empty
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
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    var projects = new List<Project>();

                    foreach (DataRow row in dt.Rows)
                    {
                        var p = new Project
                        {
                            ProjectId = row["ProjectId"] != DBNull.Value ? Convert.ToInt32(row["ProjectId"]) : 0,
                            
                            ProjectTitle = row["ProjectTitle"]?.ToString() ?? string.Empty,
                            Description = row["Description"]?.ToString() ?? string.Empty,
                            BaselineBudget = row["Budget"] != DBNull.Value ? Convert.ToDecimal(row["Budget"]) : 0m,
                            EndDate = row["EndDate"] != DBNull.Value ? Convert.ToDateTime(row["EndDate"]) : DateTime.MinValue,
                            CurrentStatus = row["Status"]?.ToString() ?? string.Empty
                        };
                        projects.Add(p);
                    }

                    return projects;
                }
            }
        }

        public List<Project> GetPlanningProjects(int clientId)
        {
            string query = @"
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

            MySqlParameter[] para = { new MySqlParameter("@clientId", clientId) };
            DataTable dt = dbconnect.GetData(query, para);
            var projects = new List<Project>();

            if (dt == null) return projects;

            foreach (DataRow row in dt.Rows)
            {
                var p = new Project
                {
                    ProjectId = row["ProjectId"] != DBNull.Value ? Convert.ToInt32(row["ProjectId"]) : 0,
                    ProjectTitle = row["ProjectTitle"]?.ToString() ?? string.Empty,
                    Description = row["Description"]?.ToString() ?? string.Empty,
                    BaselineBudget = row["Budget"] != DBNull.Value ? Convert.ToDecimal(row["Budget"]) : 0m,
                    StartDate = row["StartDate"] != DBNull.Value ? Convert.ToDateTime(row["StartDate"]) : DateTime.MinValue,
                    CurrentStatus = row["Status"]?.ToString() ?? string.Empty,
                    BidCount = row["BidCount"] != DBNull.Value ? Convert.ToInt32(row["BidCount"]) : 0
                };

                projects.Add(p);
            }

            return projects;
        }

        public List<AssignedProjectDTO> GetProjectsWithAssigned(int clientId)
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

            MySqlParameter[] ps = { new MySqlParameter("@clientId", clientId) };
            DataTable dt = dbconnect.GetData(query, ps);
            var projects = new List<AssignedProjectDTO>();

            if (dt == null) return projects;

            foreach (DataRow row in dt.Rows)
            {
                var p = new AssignedProjectDTO
                {
                    Project = new Project(),
                    Freelancer = new Freelancer(),
                    Review = new Review()
                };

                p.Freelancer.HourlyRate = row["HourlyRate"] != DBNull.Value ? Convert.ToDecimal(row["HourlyRate"]) : 0m;
                p.Freelancer.Portfolio = p.Freelancer.Portfolio ?? new Portfolio();
                p.Freelancer.Portfolio.OwnerName = row["FreelancerName"]?.ToString() ?? string.Empty;
                p.Freelancer.Portfolio.ProfessionalTitle = row["ProfessionalTitle"]?.ToString() ?? string.Empty;
                p.Freelancer.Portfolio.Profile = row["ProfilePic"]?.ToString() ?? string.Empty;

                p.Project.EndDate = row["EndDate"] != DBNull.Value ? Convert.ToDateTime(row["EndDate"]) : DateTime.MinValue;
                p.Project.ProjectTitle = row["ProjectTitle"]?.ToString() ?? string.Empty;
                p.Project.Description = row["Description"]?.ToString() ?? string.Empty;
                p.Project.BaselineBudget = row["Budget"] != DBNull.Value ? Convert.ToDecimal(row["Budget"]) : 0m;
                p.Project.OverAllProgress = row["OverAllProgress"] != DBNull.Value ? Convert.ToInt32(row["OverAllProgress"]) : 0;
                p.Project.CurrentStatus = row["Status"]?.ToString() ?? string.Empty;

                projects.Add(p);
            }

            return projects;
        }

        public List<AssignedProjectDTO> GetForSubmittedReview(int clientId)
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

            MySqlParameter[] ps = { new MySqlParameter("@clientId", clientId) };
            DataTable dt = dbconnect.GetData(query, ps);
            var projects = new List<AssignedProjectDTO>();

            if (dt == null) return projects;

            foreach (DataRow row in dt.Rows)
            {
                var p = new AssignedProjectDTO
                {
                    Project = new Project(),
                    Freelancer = new Freelancer(),
                    Review = new Review()
                };

                p.Freelancer.HourlyRate = row["HourlyRate"] != DBNull.Value ? Convert.ToDecimal(row["HourlyRate"]) : 0m;
                p.Freelancer.Portfolio = p.Freelancer.Portfolio ?? new Portfolio();
                p.Freelancer.Portfolio.OwnerName = row["FreelancerName"]?.ToString() ?? string.Empty;
                p.Freelancer.Portfolio.ProfessionalTitle = row["ProfessionalTitle"]?.ToString() ?? string.Empty;
                p.Freelancer.Portfolio.Profile = row["ProfilePic"]?.ToString() ?? string.Empty;

                p.Project.SubmittedDate = row["SubmittedDate"] != DBNull.Value ? Convert.ToDateTime(row["SubmittedDate"]) : DateTime.MinValue;
                p.Project.ProjectId = row["ProjectId"] != DBNull.Value ? Convert.ToInt32(row["ProjectId"]) : 0;
                p.Project.ProjectTitle = row["ProjectTitle"]?.ToString() ?? string.Empty;
                p.Project.Description = row["Description"]?.ToString() ?? string.Empty;
                p.Project.BaselineBudget = row["Budget"] != DBNull.Value ? Convert.ToDecimal(row["Budget"]) : 0m;
                p.Project.OverAllProgress = row["OverAllProgress"] != DBNull.Value ? Convert.ToInt32(row["OverAllProgress"]) : 0;
                p.Project.CurrentStatus = row["Status"]?.ToString() ?? string.Empty;

                projects.Add(p);
            }

            return projects;
        }

        public List<AssignedProjectDTO> GetCompletedProjects(int clientId)
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

            MySqlParameter[] ps = { new MySqlParameter("@clientId", clientId) };
            DataTable dt = dbconnect.GetData(query, ps);
            var projects = new List<AssignedProjectDTO>();

            if (dt == null) return projects;

            foreach (DataRow row in dt.Rows)
            {
                var p = new AssignedProjectDTO
                {
                    Project = new Project(),
                    Freelancer = new Freelancer(),
                    Review = new Review()
                };

                // Freelancer Info
                p.Freelancer.FreelancerId = row["FreelancerId"] != DBNull.Value ? Convert.ToInt32(row["FreelancerId"]) : 0;
                p.Freelancer.HourlyRate = row["HourlyRate"] != DBNull.Value ? Convert.ToDecimal(row["HourlyRate"]) : 0m;
                p.Freelancer.Portfolio = p.Freelancer.Portfolio ?? new Portfolio();
                p.Freelancer.Portfolio.OwnerName = row["FreelancerName"]?.ToString() ?? string.Empty;
                p.Freelancer.Portfolio.ProfessionalTitle = row["ProfessionalTitle"]?.ToString() ?? string.Empty;
                p.Freelancer.Portfolio.Profile = row["ProfilePic"]?.ToString() ?? string.Empty;

                // Project Info
                p.Project.ProjectId = row["ProjectId"] != DBNull.Value ? Convert.ToInt32(row["ProjectId"]) : 0;
                p.Project.ProjectTitle = row["ProjectTitle"]?.ToString() ?? string.Empty;
                p.Project.Description = row["Description"]?.ToString() ?? string.Empty;
                p.Project.BaselineBudget = row["Budget"] != DBNull.Value ? Convert.ToDecimal(row["Budget"]) : 0m;
                p.Project.CurrentStatus = row["Status"]?.ToString() ?? string.Empty;

                p.Project.CompletedDate = row["CompletedDate"] != DBNull.Value ? Convert.ToDateTime(row["CompletedDate"]) : DateTime.MinValue;

                if (row["ReviewId"] != DBNull.Value)
                {
                    p.Review.ReviewId = Convert.ToInt32(row["ReviewId"]);
                    p.Review.Rating = row["Rating"] != DBNull.Value ? Convert.ToSingle(row["Rating"]) : 0f;
                    p.Review.Comment = row["Comment"]?.ToString() ?? string.Empty;
                }
                else
                {
                    p.Review.ReviewId = 0;
                }

                projects.Add(p);
            }

            return projects;
        }

        public bool CalculateProjectProgressRate(int projectId)
        {
            try
            {
                string getMilestonesQuery = "SELECT Weight, Progress FROM milestones WHERE ProjectId = @pId";
                MySqlParameter[] pParams = { new MySqlParameter("@pId", projectId) };
                DataTable dt = dbconnect.GetData(getMilestonesQuery, pParams);

                double totalWeightedProgress = 0;
                double totalWeight = 0;

                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        double weight = row["Weight"] != DBNull.Value ? Convert.ToDouble(row["Weight"]) : 0;
                        double progress = row["Progress"] != DBNull.Value ? Convert.ToDouble(row["Progress"]) : 0;

                        totalWeightedProgress += (progress * weight);
                        totalWeight += weight;
                    }
                }

                int overallProgress = 0;
                if (totalWeight > 0)
                {
                    overallProgress = (int)(totalWeightedProgress / totalWeight);
                }

                // Update column name to match DTO/property (OverAllProgress)
                string updateProjectQuery = "UPDATE projects SET OverAllProgress = @overall WHERE ProjectId = @pId";
                MySqlParameter[] projParams = {
                    new MySqlParameter("@overall", overallProgress),
                    new MySqlParameter("@pId", projectId)
                };

                return dbconnect.ExecuteCommand(updateProjectQuery, projParams);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"CalculateProjectProgressRate failed: {ex}");
                return false;
            }
        }
    }
}