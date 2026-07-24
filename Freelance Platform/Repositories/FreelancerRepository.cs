using Freelance_Platform.Connection;
using Freelance_Platform.DTO;
using Freelance_Platform.model;
using Freelance_Platform.Session;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Freelance_Platform.Repositories
{
    internal class FreelancerRepository
    {

        private readonly dbConnect dbConn = new dbConnect();

        public FreelancerRepository()
        {

        }

        public bool CreateProfile(Freelancer freelancer, string profile)
        {
            using (MySqlConnection conn = dbConn.GetConnection())
            {
                conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {

                        string queryFreelancer = @"INSERT INTO freelancers (UserId, Expertise, HourlyRate) 
                                           VALUES (@UserId, @Expertise, @HourlyRate);";

                        using (MySqlCommand cmd = new MySqlCommand(queryFreelancer, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@UserId", freelancer.FreelancerId);
                            cmd.Parameters.AddWithValue("@Expertise", freelancer.Expertise);
                            cmd.Parameters.AddWithValue("@HourlyRate", freelancer.HourlyRate);
                            cmd.ExecuteNonQuery();
                        }


                        long lastId;
                        using (MySqlCommand cmdId = new MySqlCommand("SELECT LAST_INSERT_ID();", conn, trans))
                        {
                            lastId = Convert.ToInt64(cmdId.ExecuteScalar());
                        }


                        string queryPortfolio = @"INSERT INTO portfolios (FreelancerId, OwnerName, ProfilePic, ProfessionalTitle, Biography, ContactEmail, ExternalLinks) 
                                          VALUES (@fid, @OwnerName, @pic, @Title, @Bio, @contact, @link);";

                        using (MySqlCommand cmd = new MySqlCommand(queryPortfolio, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@fid", lastId);
                            cmd.Parameters.AddWithValue("@OwnerName", freelancer.Portfolio.OwnerName);
                            cmd.Parameters.AddWithValue("@pic", profile);
                            cmd.Parameters.AddWithValue("@Title", freelancer.Portfolio.ProfessionalTitle);
                            cmd.Parameters.AddWithValue("@Bio", freelancer.Portfolio.Biography);
                            cmd.Parameters.AddWithValue("@contact", freelancer.Portfolio.ContactEmail);
                            cmd.Parameters.AddWithValue("@link", freelancer.Portfolio.ExternalLink);

                            cmd.ExecuteNonQuery();
                        }

                        var projects = freelancer.Portfolio?.Projects ?? new List<Project>();

                        foreach (var project in projects)
                        {
                            string freelancer_pastWorkQuery = "Insert into freelancer_pastworks (freelancerId,ProjectTitle,ProjectDescription) values (@fid,@pTitle,@pDesc);";

                            using (MySqlCommand cmd = new MySqlCommand(freelancer_pastWorkQuery, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@fid", lastId);
                                cmd.Parameters.AddWithValue("@pTitle", project.ProjectTitle ?? (object)DBNull.Value);
                                cmd.Parameters.AddWithValue("@pDesc", project.Description ?? (object)DBNull.Value);
                                cmd.ExecuteNonQuery();
                            }

                        }


                        foreach (var skill in freelancer.Skills)
                        {
                            string querySkill = "INSERT INTO freelancer_skills (FreelancerId, SkillName) VALUES (@fid, @SkillName);";
                            using (MySqlCommand cmd = new MySqlCommand(querySkill, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@fid", lastId);
                                cmd.Parameters.AddWithValue("@SkillName", skill);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new Exception("Profile Creating Failed: " + ex.Message);
                    }
                }
            }
        }

        public bool UpdateProfile(Freelancer freelancer, string profile)
        {
            using (MySqlConnection conn = dbConn.GetConnection())
            {
                conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {

                        string queryFreelancer = @"UPDATE freelancers SET Expertise = @Expertise, HourlyRate = @HourlyRate 
                                          WHERE FreelancerId = @fid;";

                        using (MySqlCommand cmd = new MySqlCommand(queryFreelancer, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@fid", freelancer.FreelancerId);
                            cmd.Parameters.AddWithValue("@Expertise", freelancer.Expertise);
                            cmd.Parameters.AddWithValue("@HourlyRate", freelancer.HourlyRate);
                            cmd.ExecuteNonQuery();
                        }


                        string queryPortfolio = @"UPDATE portfolios SET OwnerName = @OwnerName, ProfilePic = @pic, 
                                        ProfessionalTitle = @Title, Biography = @Bio, 
                                        ContactEmail = @contact, ExternalLinks = @link 
                                        WHERE FreelancerId = @fid;";

                        using (MySqlCommand cmd = new MySqlCommand(queryPortfolio, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@fid", freelancer.FreelancerId);
                            cmd.Parameters.AddWithValue("@OwnerName", freelancer.Portfolio.OwnerName);
                            cmd.Parameters.AddWithValue("@pic", profile);
                            cmd.Parameters.AddWithValue("@Title", freelancer.Portfolio.ProfessionalTitle);
                            cmd.Parameters.AddWithValue("@Bio", freelancer.Portfolio.Biography);
                            cmd.Parameters.AddWithValue("@contact", freelancer.Portfolio.ContactEmail);
                            cmd.Parameters.AddWithValue("@link", freelancer.Portfolio.ExternalLink);
                            cmd.ExecuteNonQuery();
                        }


                        string delWorks = "DELETE FROM freelancer_pastworks WHERE freelancerId = @fid;";
                        string delSkills = "DELETE FROM freelancer_skills WHERE FreelancerId = @fid;";

                        using (MySqlCommand cmd = new MySqlCommand(delWorks, conn, trans)) { cmd.Parameters.AddWithValue("@fid", freelancer.FreelancerId); cmd.ExecuteNonQuery(); }
                        using (MySqlCommand cmd = new MySqlCommand(delSkills, conn, trans)) { cmd.Parameters.AddWithValue("@fid", freelancer.FreelancerId); cmd.ExecuteNonQuery(); }


                        foreach (var project in freelancer.Portfolio.Projects)
                        {
                            string insWork = "INSERT INTO freelancer_pastworks (freelancerId, ProjectTitle, ProjectDescription) VALUES (@fid, @pTitle, @pDesc);";
                            using (MySqlCommand cmd = new MySqlCommand(insWork, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@fid", freelancer.FreelancerId);
                                cmd.Parameters.AddWithValue("@pTitle", project.ProjectTitle ?? (object)DBNull.Value);
                                cmd.Parameters.AddWithValue("@pDesc", project.Description ?? (object)DBNull.Value);
                                cmd.ExecuteNonQuery();
                            }
                        }


                        foreach (var skill in freelancer.Skills)
                        {
                            string insSkill = "INSERT INTO freelancer_skills (FreelancerId, SkillName) VALUES (@fid, @SkillName);";
                            using (MySqlCommand cmd = new MySqlCommand(insSkill, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@fid", freelancer.FreelancerId);
                                cmd.Parameters.AddWithValue("@SkillName", skill);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new Exception("Profile Updating Failed: " + ex.Message);
                    }
                }
            }
        }
        public Freelancer DashboardInfo()
        {

            string freelancerQuery = @"SELECT f.Expertise, f.HourlyRate, p.OwnerName, p.ProfessionalTitle, p.ProfilePic,
       p.Biography, p.ContactEmail, p.ExternalLinks,
       GROUP_CONCAT(DISTINCT s.SkillName SEPARATOR ', ') AS SkillsList,
       GROUP_CONCAT(DISTINCT pw.ProjectTitle SEPARATOR '||') AS PastProjectTitles,
       GROUP_CONCAT(DISTINCT pw.ProjectDescription SEPARATOR '||') AS PastProjectDescriptions
    FROM freelancers f
    LEFT JOIN portfolios p ON f.FreelancerId = p.FreelancerId
    LEFT JOIN freelancer_skills s ON f.FreelancerId = s.FreelancerId
    LEFT JOIN freelancer_pastworks pw ON f.FreelancerId = pw.freelancerId
    WHERE f.FreelancerId = @freeId
    GROUP BY f.FreelancerId, f.Expertise, f.HourlyRate, p.OwnerName, p.ProfessionalTitle, 
         p.ProfilePic, p.Biography, p.ContactEmail, p.ExternalLinks;";
            MySqlParameter[] para =
            {
                new MySqlParameter("@freeId",UserSession.FreelancerId)
            };

            DataTable dTable = dbConn.GetData(freelancerQuery, para);

            if (dTable != null & dTable.Rows.Count > 0)
            {

                //Freelancer f = new Freelancer();
                Freelancer f = new Freelancer
                {
                    Expertise = dTable.Rows[0]["Expertise"].ToString(),
                    HourlyRate = (decimal)dTable.Rows[0]["HourlyRate"],

                };



                f.Portfolio.OwnerName = dTable.Rows[0]["OwnerName"].ToString();
                f.Portfolio.ProfessionalTitle = dTable.Rows[0]["ProfessionalTitle"].ToString();
                f.Portfolio.Biography = dTable.Rows[0]["Biography"].ToString();
                f.Portfolio.ContactEmail = dTable.Rows[0]["ContactEmail"].ToString();
                f.Portfolio.Profile = dTable.Rows[0]["ProfilePic"].ToString();

                string skillsRaw = dTable.Rows[0]["SkillsList"].ToString();
                f.Skills = string.IsNullOrEmpty(skillsRaw) ? new List<string>() : skillsRaw.Split(',').Select(s => s.Trim()).ToList();


                string titlesRaw = dTable.Rows[0]["PastProjectTitles"].ToString();

                string descsRaw = dTable.Rows[0]["PastProjectDescriptions"].ToString();

                if (!string.IsNullOrEmpty(titlesRaw))
                {
                    var titles = titlesRaw.Split(new string[] { "||" }, StringSplitOptions.None);
                    var descs = descsRaw.Split(new string[] { "||" }, StringSplitOptions.None);

                    //MessageBox.Show("Titles count: " + titles.Length + "\nDescs count: " + descs.Length);

                    f.Portfolio.Projects = titles.Select((t, i) => new Project
                    {
                        ProjectTitle = t.Trim(),
                        Description = descs[i].Trim()
                    }).ToList();
                }
                else
                {
                    f.Portfolio.Projects = new List<Project>();
                }

                return f;
            }

            return null;
        }


        public List<FreelancerCardDTO> GetFreelancerCards(string searchTerm = "")
        {
            string query = @"
SELECT
    f.FreelancerId,
    f.Expertise,
    f.HourlyRate,
    p.OwnerName,
    p.ProfessionalTitle,
    p.ProfilePic,
    LEFT(IFNULL(p.Biography,''), 120) AS Biography,
    GROUP_CONCAT(DISTINCT s.SkillName SEPARATOR ', ') AS Skills,
    IFNULL(rv.AverageRating, 0) AS AverageRating,
    IFNULL(rv.ReviewCount, 0) AS ReviewCount
FROM freelancers f
LEFT JOIN portfolios p
    ON f.FreelancerId = p.FreelancerId
LEFT JOIN freelancer_skills s
    ON f.FreelancerId = s.FreelancerId
LEFT JOIN (
    SELECT 
        FreelancerId, 
        ROUND(AVG(Rating), 1) AS AverageRating, 
        COUNT(ReviewId) AS ReviewCount
    FROM reviews
    GROUP BY FreelancerId
) rv ON f.FreelancerId = rv.FreelancerId";

            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query += @"
    WHERE
        p.OwnerName LIKE @Search
        OR p.ProfessionalTitle LIKE @Search
        OR f.Expertise LIKE @Search
        OR s.SkillName LIKE @Search";

                parameters.Add(new MySqlParameter("@Search", "%" + searchTerm + "%"));
            }

            query += @"
GROUP BY
    f.FreelancerId,
    f.Expertise,
    f.HourlyRate,
    p.OwnerName,
    p.ProfessionalTitle,
    p.ProfilePic,
    p.Biography,
    rv.AverageRating,
    rv.ReviewCount
ORDER BY p.OwnerName;";

            DataTable dt = dbConn.GetData(query, parameters.ToArray());

            List<FreelancerCardDTO> freelancers = new List<FreelancerCardDTO>();

            foreach (DataRow row in dt.Rows)
            {
                FreelancerCardDTO card = new FreelancerCardDTO
                {
                    FreelancerId = Convert.ToInt32(row["FreelancerId"]),
                    OwnerName = row["OwnerName"].ToString(),
                    ProfessionalTitle = row["ProfessionalTitle"].ToString(),
                    Expertise = row["Expertise"].ToString(),
                    HourlyRate = Convert.ToDecimal(row["HourlyRate"]),
                    ProfilePic = row["ProfilePic"].ToString(),
                    Biography = row["Biography"].ToString(),

                    
                    AverageRating = Convert.ToSingle(row["AverageRating"]),
                    ReviewCount = Convert.ToInt32(row["ReviewCount"])
                };

                string skills = row["Skills"].ToString();

                card.Skills = string.IsNullOrWhiteSpace(skills)
                    ? new List<string>()
                    : skills.Split(',')
                            .Select(x => x.Trim())
                            .ToList();

                freelancers.Add(card);
            }

            return freelancers;
        }

        public Freelancer FreelancerDetails(int freelancerId)
        {
            string freelancerQuery = @"
SELECT
    f.FreelancerId,
    f.Expertise,
    f.HourlyRate,

    p.OwnerName,
    p.ProfessionalTitle,
    p.ProfilePic,
    p.Biography,
    p.ContactEmail,
    p.ExternalLinks,

    COALESCE(rv.AverageRating, 0) AS AverageRating,
    COALESCE(rv.TotalReviews, 0) AS TotalReviews,

    sk.SkillsList,

    pw.PastProjectTitles,
    pw.PastProjectDescriptions,

    rev.ClientNames,
    rev.ReviewRatings,
    rev.ReviewComments,
    rev.ReviewDates

FROM freelancers f

LEFT JOIN portfolios p
    ON f.FreelancerId = p.FreelancerId

/************************** Skills ******************************/
LEFT JOIN
(
    SELECT
        FreelancerId,
        GROUP_CONCAT(SkillName SEPARATOR ', ') AS SkillsList
    FROM freelancer_skills
    GROUP BY FreelancerId
) sk
    ON f.FreelancerId = sk.FreelancerId

/************** Past Works ******************************/
LEFT JOIN
(
    SELECT
        FreelancerId,
        GROUP_CONCAT(ProjectTitle SEPARATOR '||') AS PastProjectTitles,
        GROUP_CONCAT(ProjectDescription SEPARATOR '||') AS PastProjectDescriptions
    FROM freelancer_pastworks
    GROUP BY FreelancerId
) pw
    ON f.FreelancerId = pw.FreelancerId

/*************************Rating Summary *************************/
LEFT JOIN
(
    SELECT
        FreelancerId,
        ROUND(AVG(Rating), 1) AS AverageRating,
        COUNT(*) AS TotalReviews
    FROM reviews
    GROUP BY FreelancerId
) rv
    ON f.FreelancerId = rv.FreelancerId

/************************* Reviews Details List *************************/
LEFT JOIN
(
    SELECT
        r.FreelancerId,
        GROUP_CONCAT(COALESCE(u.Username, 'Anonymous') SEPARATOR '||') AS ClientNames,
        GROUP_CONCAT(r.Rating SEPARATOR '||') AS ReviewRatings,
        GROUP_CONCAT(COALESCE(r.Comment, '') SEPARATOR '||') AS ReviewComments,
        GROUP_CONCAT(DATE_FORMAT(r.CreatedDate, '%Y-%m-%d %H:%i') SEPARATOR '||') AS ReviewDates
    FROM reviews r
    LEFT JOIN clients c ON r.ClientId = c.ClientId
    LEFT JOIN users u ON c.UserId = u.UserId
    GROUP BY r.FreelancerId
) rev
    ON f.FreelancerId = rev.FreelancerId

WHERE f.FreelancerId = @freeId;"; // အပြင်ဘက်ဆုံးမှာ တစ်နေရာတည်းသာ ထားရှိရန်

            MySqlParameter[] para =
            {
        new MySqlParameter("@freeId", freelancerId)
    };

            DataTable dTable = dbConn.GetData(freelancerQuery, para);

            if (dTable != null && dTable.Rows.Count > 0)
            {
                DataRow row = dTable.Rows[0];

                Freelancer freelancer = new Freelancer
                {
                    Expertise = row["Expertise"].ToString(),
                    HourlyRate = Convert.ToDecimal(row["HourlyRate"]),

                    AverageRating = Convert.ToSingle(row["AverageRating"]),
                    TotalReviews = Convert.ToInt32(row["TotalReviews"])
                };

                // Portfolio Mapping
                freelancer.Portfolio.OwnerName = row["OwnerName"].ToString();
                freelancer.Portfolio.ProfessionalTitle = row["ProfessionalTitle"].ToString();
                freelancer.Portfolio.Biography = row["Biography"].ToString();
                freelancer.Portfolio.ContactEmail = row["ContactEmail"].ToString();
                freelancer.Portfolio.Profile = row["ProfilePic"].ToString();
                freelancer.Portfolio.ExternalLink = row["ExternalLinks"].ToString();

                // Skills Mapping
                string skillsRaw = row["SkillsList"]?.ToString();
                freelancer.Skills = string.IsNullOrWhiteSpace(skillsRaw)
                    ? new List<string>()
                    : skillsRaw.Split(',')
                               .Select(s => s.Trim())
                               .ToList();

                // Past Works Mapping
                string titlesRaw = row["PastProjectTitles"]?.ToString();
                string descsRaw = row["PastProjectDescriptions"]?.ToString();

                freelancer.Portfolio.Projects = new List<Project>();

                if (!string.IsNullOrWhiteSpace(titlesRaw))
                {
                    string[] titles = titlesRaw.Split(new[] { "||" }, StringSplitOptions.None);
                    string[] descs = string.IsNullOrWhiteSpace(descsRaw)
                        ? new string[0]
                        : descsRaw.Split(new[] { "||" }, StringSplitOptions.None);

                    for (int i = 0; i < titles.Length; i++)
                    {
                        freelancer.Portfolio.Projects.Add(new Project
                        {
                            ProjectTitle = titles[i],
                            Description = (i < descs.Length) ? descs[i] : ""
                        });
                    }
                }

                // ==========================================
                // Reviews & Client Details Mapping
                // ==========================================
                string clientNamesRaw = row["ClientNames"]?.ToString();
                string reviewRatingsRaw = row["ReviewRatings"]?.ToString();
                string reviewCommentsRaw = row["ReviewComments"]?.ToString();
                string reviewDatesRaw = row["ReviewDates"]?.ToString();

                freelancer.Reviews = new List<ReviewDTO>();

                if (!string.IsNullOrWhiteSpace(clientNamesRaw))
                {
                    string[] clientNames = clientNamesRaw.Split(new[] { "||" }, StringSplitOptions.None);
                    string[] ratings = string.IsNullOrWhiteSpace(reviewRatingsRaw) ? new string[0] : reviewRatingsRaw.Split(new[] { "||" }, StringSplitOptions.None);
                    string[] comments = string.IsNullOrWhiteSpace(reviewCommentsRaw) ? new string[0] : reviewCommentsRaw.Split(new[] { "||" }, StringSplitOptions.None);
                    string[] dates = string.IsNullOrWhiteSpace(reviewDatesRaw) ? new string[0] : reviewDatesRaw.Split(new[] { "||" }, StringSplitOptions.None);

                    for (int i = 0; i < clientNames.Length; i++)
                    {
                        freelancer.Reviews.Add(new ReviewDTO
                        {
                            ClientName = clientNames[i],
                            Rating = i < ratings.Length ? Convert.ToSingle(ratings[i]) : 0f,
                            Comment = i < comments.Length ? comments[i] : "",
                            CommentDate = i < dates.Length ? Convert.ToDateTime(dates[i]) : DateTime.Now
                        });
                    }
                }

                return freelancer;
            }

            return null;
        }

        public List<Project> BrowseProjects(string searchTerm = "")
        {

            string query = "SELECT * FROM projects WHERE Status = 'PLANNING'";
            List<MySqlParameter> parameters = new List<MySqlParameter>();


            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += " AND (ProjectTitle LIKE @search OR Description LIKE @search)";
                parameters.Add(new MySqlParameter("@search", "%" + searchTerm + "%"));
            }


            DataTable dt = dbConn.GetData(query, parameters.ToArray());
            List<Project> projects = new List<Project>();

            foreach (DataRow row in dt.Rows)
            {
                Project p = new Project
                {
                    ProjectId = Convert.ToInt32(row["ProjectId"]),
                    ProjectTitle = row["ProjectTitle"].ToString(),
                    Description = row["Description"].ToString(),
                    BaselineBudget = Convert.ToDecimal(row["Budget"]),
                    EndDate = Convert.ToDateTime(row["EndDate"]),
                    CurrentStatus = row["Status"].ToString()
                };
                projects.Add(p);
            }

            return projects;
        }


        public List<ProjectStatusDTO> GetBiddingProjectsByStatus(string status)
        {
            string query = @"SELECT 
    b.Status AS BiddingStatus,
    p.ProjectId,
    p.ProjectTitle,
    p.Budget AS ProjectBudget,
    u.Username AS ClientName,
    b.SubmissionDate AS BiddingDate
FROM biddings b
INNER JOIN projects p ON b.ProjectId = p.ProjectId
INNER JOIN clients c ON p.ClientId = c.ClientId
INNER JOIN users u ON c.UserId = u.UserId
WHERE b.Status = @status AND b.FreelancerId = @freelancerId;";

            MySqlParameter[] para =
            {
                new MySqlParameter("@freelancerId",UserSession.FreelancerId),
                new MySqlParameter("@status",status),
            };

            DataTable dt = dbConn.GetData(query, para);
            List<ProjectStatusDTO> projects = new List<ProjectStatusDTO>();

            foreach (DataRow row in dt.Rows)
            {
                ProjectStatusDTO p = new ProjectStatusDTO
                {
                    ProjectId = Convert.ToInt32(row["ProjectId"]),
                    BiddingStatus = row["BiddingStatus"].ToString(),
                    ProjectTitle = row["ProjectTitle"].ToString(),
                    ProjectBudget = Convert.ToDecimal(row["ProjectBudget"]),
                    BiddingDate = Convert.ToDateTime(row["BiddingDate"]),
                    ClientName = row["ClientName"].ToString()
                };
                projects.Add(p);
            }

            return projects;

        }

        public List<ProjectStatusDTO> GetAcceptedProjects()
        {
            string query = @"SELECT 
    b.Status AS BiddingStatus,
    p.ProjectId,
    p.ProjectTitle,
    p.Budget AS ProjectBudget,
    u.Username AS ClientName,
    b.SubmissionDate AS BiddingDate
FROM biddings b
INNER JOIN projects p ON b.ProjectId = p.ProjectId
INNER JOIN clients c ON p.ClientId = c.ClientId
INNER JOIN users u ON c.UserId = u.UserId
WHERE b.Status = 'Accepted' AND p.Status = 'IN_PROGRESS' AND b.FreelancerId = @freelancerId;";

            MySqlParameter[] para =
            {
                new MySqlParameter("@freelancerId",UserSession.FreelancerId),
                
            };

            DataTable dt = dbConn.GetData(query, para);
            List<ProjectStatusDTO> projects = new List<ProjectStatusDTO>();

            foreach (DataRow row in dt.Rows)
            {
                ProjectStatusDTO p = new ProjectStatusDTO
                {
                    ProjectId = Convert.ToInt32(row["ProjectId"]),
                    BiddingStatus = row["BiddingStatus"].ToString(),
                    ProjectTitle = row["ProjectTitle"].ToString(),
                    ProjectBudget = Convert.ToDecimal(row["ProjectBudget"]),
                    BiddingDate = Convert.ToDateTime(row["BiddingDate"]),
                    ClientName = row["ClientName"].ToString()
                };
                projects.Add(p);
            }

            return projects;

        }



        public bool SetMileStones(int projectId, int freelancerId, List<Milestone> milestones)
        {
            try
            {
                foreach (var m in milestones)
                {
                    string query = "INSERT INTO milestones (ProjectId, FreelancerId, Title, Description, Weight, Progress, Status) " +
                                   "VALUES (@pid, @fid, @title, @desc, @weight, @prog, @status)";


                    MySqlParameter[] para = new MySqlParameter[]
                    {
                new MySqlParameter("@pid", projectId),
                new MySqlParameter("@fid", freelancerId),
                new MySqlParameter("@title", m.Title),
                new MySqlParameter("@desc", m.Description),
                new MySqlParameter("@weight", m.Weight),
                new MySqlParameter("@prog", m.Progress),
                new MySqlParameter("@status", m.Status)
                    };


                    bool success = dbConn.ExecuteCommand(query, para);

                    if (!success)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<ProjectWithMilestonesDTO> GetProjectWithMileStone(int freelancerId)
        {
            string query = @"SELECT
    p.ProjectId,
    p.ProjectTitle,
    p.EndDate AS projectEndDate,
    p.OverAllProgress,
    u.Username AS ClientName,

    m.MilestoneId,
    m.Title,
    m.Weight,
    m.Progress,
    m.Status

FROM milestones m

INNER JOIN projects p
    ON p.ProjectId = m.ProjectId

INNER JOIN clients c
    ON p.ClientId = c.ClientId

INNER JOIN users u
    ON c.UserId = u.UserId

WHERE m.FreelancerId = @freelancerId AND p.Status = 'IN_PROGRESS'

ORDER BY p.ProjectId,m.MilestoneId;";





            MySqlParameter[] ps =
            {
        new MySqlParameter("@freelancerId", freelancerId),
    };

            DataTable dt = dbConn.GetData(query, ps);


            Dictionary<int, ProjectWithMilestonesDTO> projectDict = new Dictionary<int, ProjectWithMilestonesDTO>();

            foreach (DataRow row in dt.Rows)
            {
                int projectId = Convert.ToInt32(row["ProjectId"]);


                if (!projectDict.ContainsKey(projectId))
                {
                    ProjectWithMilestonesDTO p = new ProjectWithMilestonesDTO
                    {
                        ProjectId = projectId,
                        ProjectTitle = row["projectTitle"].ToString(),
                        ProjectEndDate = Convert.ToDateTime(row["projectEndDate"]),
                        OverAllProgress = Convert.ToInt32(row["OverAllProgress"]),
                        ClientName = row["ClientName"].ToString(),
                        Milestones = new List<Milestone>()
                    };
                    projectDict.Add(projectId, p);
                }


                if (row["MilestoneId"] != DBNull.Value)
                {
                    Milestone milestone = new Milestone
                    {
                        MilestoneId = Convert.ToInt32(row["MilestoneId"]),
                        Title = row["Title"].ToString(),
                        Weight = Convert.ToInt32(row["Weight"]),
                        Progress = Convert.ToInt32(row["Progress"]),
                        Status = row["Status"].ToString()
                    };

                    projectDict[projectId].Milestones.Add(milestone);
                }
            }


            return new List<ProjectWithMilestonesDTO>(projectDict.Values);
        }

        public bool UpdateMileStoneProgress(int milestoneId, int newProgress, string newStatus)
        {
            try
            {
                string query = "UPDATE milestones SET Progress = @progress, Status = @status, UpdatedAt = NOW() WHERE MilestoneId = @milestoneId";

                MySqlParameter[] ps =
                {
               new  MySqlParameter("@milestoneId",milestoneId),
               new MySqlParameter("@progress",newProgress),
               new MySqlParameter("@status",newStatus)
            };

                return dbConn.ExecuteCommand(query, ps);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Submit completed Project
        public bool SubmitCompletedProjects(int projectId)
        {
            try
            {
                string query = "UPDATE projects SET Status = 'ON_HOLD', SubmittedDate = NOW() WHERE ProjectId = @pid";
                MySqlParameter[] ps =
                {
                    new MySqlParameter("@pid",projectId),
                };
                return dbConn.ExecuteCommand(query, ps);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        //Get Rating and Review for Completed Project By Freelancer
        public List<CompletedProjectReviewDTO> ViewCompletedProject()
        {
            string query = @"SELECT 
    p.Status ,
    p.CompletedDate ,
    p.ProjectTitle,
    p.Budget ,
    u.Username AS ClientName,
    r.Rating ,
    r.Comment
FROM projects p
JOIN clients c ON p.ClientId = c.ClientId
JOIN users u ON c.UserId = u.UserId
LEFT JOIN reviews r ON p.ProjectId = r.ProjectId
WHERE r.FreelancerId = @freelancerId;";

            MySqlParameter[] ps =
            {
                new MySqlParameter("@freelancerId",UserSession.FreelancerId),
            };

            DataTable dt = dbConn.GetData(query, ps);
            List<CompletedProjectReviewDTO> completedProjects = new List<CompletedProjectReviewDTO>();
            foreach(DataRow row in dt.Rows)
            {
                CompletedProjectReviewDTO p = new CompletedProjectReviewDTO
                {
                    ProjectTitle = row["ProjectTitle"].ToString(),
                    ProjectStatus = row["Status"].ToString(),
                    CompletedDate = Convert.ToDateTime(row["CompletedDate"]),
                    ProjectBudget = Convert.ToDecimal(row["Budget"]),
                    Rating = Convert.ToInt32(row["Rating"]),
                    ClientName = row["ClientName"].ToString(),
                    Comment = row["Comment"].ToString()
                };
                completedProjects.Add(p);
            }
            return completedProjects;
        }


    }
}
