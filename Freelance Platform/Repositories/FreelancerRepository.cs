using Freelance_Platform.Connection;
using Freelance_Platform.model;
using Freelance_Platform.Session;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

                        foreach (var project in projects )
                        {
                            string freelancer_pastWorkQuery = "Insert into freelancer_pastworks (freelancerId,ProjectTitle,ProjectDescription) values (@fid,@pTitle,@pDesc);";

                            using (MySqlCommand cmd = new MySqlCommand(freelancer_pastWorkQuery, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@fid", lastId);
                                cmd.Parameters.AddWithValue("@pTitle", project.ProjectTitle ?? (object)DBNull.Value);
                                cmd.Parameters.AddWithValue("@pDesc", project.Description ?? (object) DBNull.Value);
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

      

       
    }
}
