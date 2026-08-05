using Freelance_Platform.Connection;
using Freelance_Platform.DTO;
using Freelance_Platform.Interfaces;
using Freelance_Platform.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;


namespace Freelance_Platform.Repositories
{
    internal class FreelancerRepository : IFreelancerRepository
    {
        private readonly dbConnect dbConn = new dbConnect();

        public FreelancerRepository() { }

        //public bool CreateProfile(Freelancer freelancer, string profile, int userId)
        //{
        //    using (MySqlConnection conn = dbConn.GetConnection())
        //    {
        //        conn.Open();
        //        using (MySqlTransaction trans = conn.BeginTransaction())
        //        {
        //            try
        //            {
        //                string queryFreelancer = @"INSERT INTO freelancers (UserId, Expertise, HourlyRate) 
        //                                   VALUES (@UserId, @Expertise, @HourlyRate);";

        //                using (MySqlCommand cmd = new MySqlCommand(queryFreelancer, conn, trans))
        //                {
        //                    cmd.Parameters.AddWithValue("@UserId", userId);
        //                    cmd.Parameters.AddWithValue("@Expertise", freelancer.Expertise ?? (object)DBNull.Value);
        //                    cmd.Parameters.AddWithValue("@HourlyRate", freelancer.HourlyRate);
        //                    cmd.ExecuteNonQuery();
        //                }

        //                long lastId;
        //                using (MySqlCommand cmdId = new MySqlCommand("SELECT LAST_INSERT_ID();", conn, trans))
        //                {
        //                    lastId = Convert.ToInt64(cmdId.ExecuteScalar());
        //                }

        //                string queryPortfolio = @"INSERT INTO portfolios (FreelancerId, OwnerName, ProfilePic, ProfessionalTitle, Biography, ContactEmail, ExternalLinks) 
        //                                  VALUES (@fid, @OwnerName, @pic, @Title, @Bio, @contact, @link);";

        //                using (MySqlCommand cmd = new MySqlCommand(queryPortfolio, conn, trans))
        //                {
        //                    cmd.Parameters.AddWithValue("@fid", lastId);
        //                    cmd.Parameters.AddWithValue("@OwnerName", freelancer.Portfolio?.OwnerName ?? (object)DBNull.Value);
        //                    cmd.Parameters.AddWithValue("@pic", profile ?? (object)DBNull.Value);
        //                    cmd.Parameters.AddWithValue("@Title", freelancer.Portfolio?.ProfessionalTitle ?? (object)DBNull.Value);
        //                    cmd.Parameters.AddWithValue("@Bio", freelancer.Portfolio?.Biography ?? (object)DBNull.Value);
        //                    cmd.Parameters.AddWithValue("@contact", freelancer.Portfolio?.ContactEmail ?? (object)DBNull.Value);
        //                    cmd.Parameters.AddWithValue("@link", freelancer.Portfolio?.ExternalLink ?? (object)DBNull.Value);
        //                    cmd.ExecuteNonQuery();
        //                }

        //                var projects = freelancer.Portfolio?.Projects ?? new List<Project>();
        //                foreach (var project in projects)
        //                {
        //                    string freelancer_pastWorkQuery = "INSERT INTO freelancer_pastworks (freelancerId,ProjectTitle,ProjectDescription) VALUES (@fid,@pTitle,@pDesc);";
        //                    using (MySqlCommand cmd = new MySqlCommand(freelancer_pastWorkQuery, conn, trans))
        //                    {
        //                        cmd.Parameters.AddWithValue("@fid", lastId);
        //                        cmd.Parameters.AddWithValue("@pTitle", project.ProjectTitle ?? (object)DBNull.Value);
        //                        cmd.Parameters.AddWithValue("@pDesc", project.Description ?? (object)DBNull.Value);
        //                        cmd.ExecuteNonQuery();
        //                    }
        //                }

        //                foreach (var skill in freelancer.Skills ?? Enumerable.Empty<string>())
        //                {
        //                    string querySkill = "INSERT INTO freelancer_skills (FreelancerId, SkillName) VALUES (@fid, @SkillName);";
        //                    using (MySqlCommand cmd = new MySqlCommand(querySkill, conn, trans))
        //                    {
        //                        cmd.Parameters.AddWithValue("@fid", lastId);
        //                        cmd.Parameters.AddWithValue("@SkillName", skill ?? string.Empty);
        //                        cmd.ExecuteNonQuery();
        //                    }
        //                }

        //                trans.Commit();
        //                return true;
        //            }
        //            catch (Exception ex)
        //            {
        //                try { trans.Rollback(); } catch { /* ignore rollback errors */ }
        //                Debug.WriteLine($"CreateProfile failed: {ex}");
        //                return false;
        //            }
        //        }
        //    }
        //}

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
                            cmd.Parameters.AddWithValue("@Expertise", freelancer.Expertise ?? (object)DBNull.Value);
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
                            cmd.Parameters.AddWithValue("@OwnerName", freelancer.Portfolio?.OwnerName ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@pic", profile ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@Title", freelancer.Portfolio?.ProfessionalTitle ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@Bio", freelancer.Portfolio?.Biography ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@contact", freelancer.Portfolio?.ContactEmail ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@link", freelancer.Portfolio?.ExternalLink ?? (object)DBNull.Value);
                            cmd.ExecuteNonQuery();
                        }

                        string delWorks = "DELETE FROM freelancer_pastworks WHERE freelancerId = @fid;";
                        string delSkills = "DELETE FROM freelancer_skills WHERE FreelancerId = @fid;";

                        using (MySqlCommand cmd = new MySqlCommand(delWorks, conn, trans)) { cmd.Parameters.AddWithValue("@fid", freelancer.FreelancerId); cmd.ExecuteNonQuery(); }
                        using (MySqlCommand cmd = new MySqlCommand(delSkills, conn, trans)) { cmd.Parameters.AddWithValue("@fid", freelancer.FreelancerId); cmd.ExecuteNonQuery(); }

                        foreach (var project in freelancer.Portfolio?.Projects ?? Enumerable.Empty<Project>())
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

                        foreach (var skill in freelancer.Skills ?? Enumerable.Empty<string>())
                        {
                            string insSkill = "INSERT INTO freelancer_skills (FreelancerId, SkillName) VALUES (@fid, @SkillName);";
                            using (MySqlCommand cmd = new MySqlCommand(insSkill, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@fid", freelancer.FreelancerId);
                                cmd.Parameters.AddWithValue("@SkillName", skill ?? string.Empty);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        try { trans.Rollback(); } catch { }
                        Debug.WriteLine($"UpdateProfile failed: {ex}");
                        return false;
                    }
                }
            }
        }

        public Freelancer DashboardInfo(int freelancerId)
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

            MySqlParameter[] para = { new MySqlParameter("@freeId", freelancerId) };
            DataTable dTable = dbConn.GetData(freelancerQuery, para);

            if (dTable != null && dTable.Rows.Count > 0)
            {
                DataRow row = dTable.Rows[0];

                var f = new Freelancer
                {
                    Portfolio = new Portfolio(),
                    Skills = new List<string>(),
                    Reviews = new List<ReviewDTO>(),
                    Expertise = row["Expertise"]?.ToString() ?? string.Empty,
                    HourlyRate = row["HourlyRate"] != DBNull.Value ? Convert.ToDecimal(row["HourlyRate"]) : 0m
                };

                f.Portfolio.OwnerName = row["OwnerName"]?.ToString() ?? string.Empty;
                f.Portfolio.ProfessionalTitle = row["ProfessionalTitle"]?.ToString() ?? string.Empty;
                f.Portfolio.Biography = row["Biography"]?.ToString() ?? string.Empty;
                f.Portfolio.ContactEmail = row["ContactEmail"]?.ToString() ?? string.Empty;
                f.Portfolio.Profile = row["ProfilePic"]?.ToString() ?? string.Empty;

                string skillsRaw = row["SkillsList"]?.ToString();
                f.Skills = string.IsNullOrEmpty(skillsRaw) ? new List<string>() : skillsRaw.Split(',').Select(s => s.Trim()).ToList();

                string titlesRaw = row["PastProjectTitles"]?.ToString();
                string descsRaw = row["PastProjectDescriptions"]?.ToString();

                f.Portfolio.Projects = new List<Project>();
                if (!string.IsNullOrEmpty(titlesRaw))
                {
                    var titles = titlesRaw.Split(new string[] { "||" }, StringSplitOptions.None);
                    var descs = descsRaw?.Split(new string[] { "||" }, StringSplitOptions.None) ?? new string[0];

                    f.Portfolio.Projects = titles.Select((t, i) => new Project
                    {
                        ProjectTitle = t.Trim(),
                        Description = i < descs.Length ? descs[i].Trim() : string.Empty
                    }).ToList();
                }

                return f;
            }

            return null;
        }

        public List<FreelancerCardDTO> GetFreelancerCards(string searchTerm = "")
        {
            string query = /* same query as before */ @"
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

            var parameters = new List<MySqlParameter>();

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
            var freelancers = new List<FreelancerCardDTO>();

            if (dt == null) return freelancers;

            foreach (DataRow row in dt.Rows)
            {
                var card = new FreelancerCardDTO
                {
                    FreelancerId = row["FreelancerId"] != DBNull.Value ? Convert.ToInt32(row["FreelancerId"]) : 0,
                    OwnerName = row["OwnerName"]?.ToString() ?? string.Empty,
                    ProfessionalTitle = row["ProfessionalTitle"]?.ToString() ?? string.Empty,
                    Expertise = row["Expertise"]?.ToString() ?? string.Empty,
                    HourlyRate = row["HourlyRate"] != DBNull.Value ? Convert.ToDecimal(row["HourlyRate"]) : 0m,
                    ProfilePic = row["ProfilePic"]?.ToString() ?? string.Empty,
                    Biography = row["Biography"]?.ToString() ?? string.Empty,
                    AverageRating = row["AverageRating"] != DBNull.Value ? Convert.ToSingle(row["AverageRating"]) : 0f,
                    ReviewCount = row["ReviewCount"] != DBNull.Value ? Convert.ToInt32(row["ReviewCount"]) : 0
                };

                string skills = row["Skills"]?.ToString();
                card.Skills = string.IsNullOrWhiteSpace(skills) ? new List<string>() : skills.Split(',').Select(x => x.Trim()).ToList();

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
            var parameters = new List<MySqlParameter>();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += " AND (ProjectTitle LIKE @search OR Description LIKE @search)";
                parameters.Add(new MySqlParameter("@search", "%" + searchTerm + "%"));
            }

            DataTable dt = dbConn.GetData(query, parameters.ToArray());
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
                    EndDate = row["EndDate"] != DBNull.Value ? Convert.ToDateTime(row["EndDate"]) : DateTime.MinValue,
                    CurrentStatus = row["Status"]?.ToString() ?? string.Empty
                };
                projects.Add(p);
            }

            return projects;
        }

        public List<ProjectStatusDTO> GetBiddingProjectsByStatus(string status, int freelancerId)
        {
            string query = @"SELECT 
    b.Status AS BiddingStatus,
    p.ProjectId,
    p.ProjectTitle,
    p.Budget AS ProjectBudget,
    u.Username AS ClientName,
    b.RejectedDate AS RejectedDate
FROM biddings b
INNER JOIN projects p ON b.ProjectId = p.ProjectId
INNER JOIN clients c ON p.ClientId = c.ClientId
INNER JOIN users u ON c.UserId = u.UserId
WHERE b.Status = @status AND b.FreelancerId = @freelancerId;";

            MySqlParameter[] para = { new MySqlParameter("@freelancerId", freelancerId), new MySqlParameter("@status", status) };
            DataTable dt = dbConn.GetData(query, para);
            var projects = new List<ProjectStatusDTO>();
            if (dt == null) return projects;

            foreach (DataRow row in dt.Rows)
            {
                projects.Add(new ProjectStatusDTO
                {
                    ProjectId = row["ProjectId"] != DBNull.Value ? Convert.ToInt32(row["ProjectId"]) : 0,
                    BiddingStatus = row["BiddingStatus"]?.ToString() ?? string.Empty,
                    ProjectTitle = row["ProjectTitle"]?.ToString() ?? string.Empty,
                    ProjectBudget = row["ProjectBudget"] != DBNull.Value ? Convert.ToDecimal(row["ProjectBudget"]) : 0m,
                    BiddingDate = row["RejectedDate"] != DBNull.Value ? Convert.ToDateTime(row["RejectedDate"]) : DateTime.MinValue,
                    ClientName = row["ClientName"]?.ToString() ?? string.Empty
                });
            }

            return projects;
        }

        public List<ProjectStatusDTO> GetAcceptedProjects(int freelancerId)
        {
            string query = @"SELECT 
    b.Status AS BiddingStatus,
    p.ProjectId,
    p.ProjectTitle,
    p.Budget AS ProjectBudget,
    u.Username AS ClientName,
    b.AcceptedDate AS AcceptedDate
FROM biddings b
INNER JOIN projects p ON b.ProjectId = p.ProjectId
INNER JOIN clients c ON p.ClientId = c.ClientId
INNER JOIN users u ON c.UserId = u.UserId
WHERE b.Status = 'Accepted' AND p.Status = 'IN_PROGRESS' AND b.FreelancerId = @freelancerId;";

            MySqlParameter[] para = { new MySqlParameter("@freelancerId", freelancerId) };
            DataTable dt = dbConn.GetData(query, para);
            var projects = new List<ProjectStatusDTO>();
            if (dt == null) return projects;

            foreach (DataRow row in dt.Rows)
            {
                projects.Add(new ProjectStatusDTO
                {
                    ProjectId = row["ProjectId"] != DBNull.Value ? Convert.ToInt32(row["ProjectId"]) : 0,
                    BiddingStatus = row["BiddingStatus"]?.ToString() ?? string.Empty,
                    ProjectTitle = row["ProjectTitle"]?.ToString() ?? string.Empty,
                    ProjectBudget = row["ProjectBudget"] != DBNull.Value ? Convert.ToDecimal(row["ProjectBudget"]) : 0m,
                    BiddingDate = row["AcceptedDate"] != DBNull.Value ? Convert.ToDateTime(row["AcceptedDate"]) : DateTime.MinValue,
                    ClientName = row["ClientName"]?.ToString() ?? string.Empty
                });
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
                        new MySqlParameter("@title", m.Title ?? (object)DBNull.Value),
                        new MySqlParameter("@desc", m.Description ?? (object)DBNull.Value),
                        new MySqlParameter("@weight", m.Weight),
                        new MySqlParameter("@prog", m.Progress),
                        new MySqlParameter("@status", m.Status ?? (object)DBNull.Value)
                    };

                    bool success = dbConn.ExecuteCommand(query, para);
                    if (!success) return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"SetMileStones failed: {ex}");
                return false;
            }
        }

        public bool HasMileStone(int projectId)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM milestones WHERE ProjectId = @pid";
                MySqlParameter[] ps = { new MySqlParameter("@pid", projectId) };

                object result = dbConn.GetScaler(query, ps);
                int count = result != null ? Convert.ToInt32(result) : 0;

                return count > 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"HasMileStone failed: {ex}");
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
                    new MySqlParameter("@milestoneId", milestoneId),
                    new MySqlParameter("@progress", newProgress),
                    new MySqlParameter("@status", newStatus ?? (object)DBNull.Value)
                };

                return dbConn.ExecuteCommand(query, ps);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"UpdateMileStoneProgress failed: {ex}");
                return false;
            }
        }

        public bool SubmitCompletedProjects(int projectId)
        {
            try
            {
                string query = "UPDATE projects SET Status = 'ON_HOLD', SubmittedDate = NOW() WHERE ProjectId = @pid";
                MySqlParameter[] ps = { new MySqlParameter("@pid", projectId) };
                return dbConn.ExecuteCommand(query, ps);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"SubmitCompletedProjects failed: {ex}");
                return false;
            }
        }

        public List<CompletedProjectReviewDTO> ViewCompletedProject(int freelancerId)
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
WHERE r.FreelancerId = @freelancerId
ORDER BY p.CompletedDate DESC;";

            MySqlParameter[] ps = { new MySqlParameter("@freelancerId", freelancerId) };
            DataTable dt = dbConn.GetData(query, ps);
            var completedProjects = new List<CompletedProjectReviewDTO>();
            if (dt == null) return completedProjects;

            foreach (DataRow row in dt.Rows)
            {
                completedProjects.Add(new CompletedProjectReviewDTO
                {
                    ProjectTitle = row["ProjectTitle"]?.ToString() ?? string.Empty,
                    ProjectStatus = row["Status"]?.ToString() ?? string.Empty,
                    CompletedDate = row["CompletedDate"] != DBNull.Value ? Convert.ToDateTime(row["CompletedDate"]) : DateTime.MinValue,
                    ProjectBudget = row["Budget"] != DBNull.Value ? Convert.ToDecimal(row["Budget"]) : 0m,
                    Rating = row["Rating"] != DBNull.Value ? Convert.ToInt32(row["Rating"]) : 0,
                    ClientName = row["ClientName"]?.ToString() ?? string.Empty,
                    Comment = row["Comment"]?.ToString() ?? string.Empty
                });
            }

            return completedProjects;
        }
    }
}