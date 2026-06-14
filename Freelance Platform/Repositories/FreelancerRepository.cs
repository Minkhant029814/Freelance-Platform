using Freelance_Platform.Connection;
using Freelance_Platform.model;
using Freelance_Platform.Session;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                       
                        string queryPortfolio = @"INSERT INTO portfolios (FreelancerId, OwnerName, ProfilePic, ProfessionalTitle, Biography, ContactEmail, ExternalLinks, ProjectTitle, ProjectDescription) 
                                          VALUES (@fid, @OwnerName, @pic, @Title, @Bio, @contact, @link, @proTitle, @prodesc);";

                        using (MySqlCommand cmd = new MySqlCommand(queryPortfolio, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@fid", lastId);
                            cmd.Parameters.AddWithValue("@OwnerName", freelancer.Portfolio.OwnerName);
                            cmd.Parameters.AddWithValue("@pic", profile);
                            cmd.Parameters.AddWithValue("@Title", freelancer.Portfolio.ProfessionalTitle);
                            cmd.Parameters.AddWithValue("@Bio", freelancer.Portfolio.Biography);
                            cmd.Parameters.AddWithValue("@contact", freelancer.Portfolio.ContactEmail);
                            cmd.Parameters.AddWithValue("@link", freelancer.Portfolio.ExternalLink);
                            cmd.Parameters.AddWithValue("@proTitle", freelancer.Portfolio.project.ProjectTitle);
                            cmd.Parameters.AddWithValue("@prodesc", freelancer.Portfolio.project.Description);
                            cmd.ExecuteNonQuery();
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
    }
}
