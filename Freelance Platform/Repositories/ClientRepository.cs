using Freelance_Platform.Connection;
using Freelance_Platform.model;
using Freelance_Platform.Session;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Freelance_Platform.Repositories
{

    internal class ClientRepository
    {
        private readonly dbConnect db = new dbConnect();

        public bool CreateProfile(int uid,string email,string phone,string address, string profile)
        {

            try
            {
                string query = "INSERT INTO CLIENTS (UserId,Phone,Email,Address,ProfilePic) values (@uid,@phone,@email,@address,@profile)";
                MySqlParameter[] ps =
                    {
                new MySqlParameter("@uid",uid),
                new MySqlParameter("@phone",phone),
                new MySqlParameter("@email",email),
                new MySqlParameter("@address",address),
                new MySqlParameter("@profile",profile)
                };

                return db.ExecuteCommand(query, ps);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            return false;
        }

        public Client GetClientDetails(int clientId)
        {
            string query = @"SELECT 
                        c.ClientId,
                        u.UserType,
                        u.Username AS UserName,
                        c.Phone,
                        c.Email,
                        c.Address,
                        c.ProfilePic
                    FROM 
                        clients c
                    JOIN 
                        users u ON c.UserId = u.UserId
                    WHERE 
                        c.ClientId = @clientId";

            MySqlParameter[] ps = {
        new MySqlParameter("@clientId", clientId)
    };

            DataTable dt = db.GetData(query, ps);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                Client client = new Client(
                    username: row["UserName"].ToString(),
                    password: "",
                    type: row["UserType"].ToString()
                )
                {
                    ClientId = Convert.ToInt32(row["ClientId"]),
                    Phone = row["Phone"] != DBNull.Value ? row["Phone"].ToString() : string.Empty,
                    Email = row["Email"] != DBNull.Value ? row["Email"].ToString() : string.Empty,
                    Address = row["Address"] != DBNull.Value ? row["Address"].ToString() : string.Empty,
                  
                     ProfilePic = row["ProfilePic"] != DBNull.Value ? row["ProfilePic"].ToString() : string.Empty
                };

                return client;
            }

            return null; 
        }

        public bool UpdateProfile(Client c)
{
    try
    {
        
        string userQuery = "UPDATE Users SET Username = @name WHERE UserId = @uid";
        MySqlParameter[] userParams = {
            new MySqlParameter("@name", c.Username), 
            new MySqlParameter("@uid", UserSession.UserId)
        };

        
            bool isUserUpdate = db.ExecuteCommand(userQuery, userParams); 
        if (!isUserUpdate) return false; 

        string clientQuery = "UPDATE Clients SET Phone = @phone, Email = @email, Address = @address, ProfilePic = @profile WHERE UserId = @uid";
        MySqlParameter[] clientParams = { 
            new MySqlParameter("@uid", UserSession.UserId),
            new MySqlParameter("@phone", c.Phone),
            new MySqlParameter("@email", c.Email),
            new MySqlParameter("@address",c.Address),
            new MySqlParameter("@profile", c.ProfilePic)
        };

        return db.ExecuteCommand(clientQuery, clientParams);
        

        
    }
    catch (Exception ex)
    {
                MessageBox.Show("Profile UpdateFailed..... " + ex.Message);
                return false;
        
    }
}

        public bool AcceptFreelancer(int bidId,int projectId)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using(MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        //  Acception selected Freelancers
                        string updateSelectedBid = "UPDATE biddings SET Status = 'Accepted',AcceptedDate = NOW() WHERE BidId = @BidId";

                        
                        // Rejecting other freelancers
                        string rejectOthers = "UPDATE biddings SET Status = 'Rejected',RejectedDate = NOW() WHERE ProjectId = @ProjectId AND BidId != @BidId";

                        
                        string updateProjectStatus = "UPDATE projects SET Status = 'IN_PROGRESS' WHERE ProjectId = @ProjectId";


                        // Running Command
                        using (var cmd = new MySqlCommand(updateSelectedBid, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@BidId", bidId);
                            cmd.ExecuteNonQuery();
                        }

                        using (var cmd = new MySqlCommand(rejectOthers, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ProjectId", projectId);
                            cmd.Parameters.AddWithValue("@BidId", bidId);
                            cmd.ExecuteNonQuery();
                        }

                        using (var cmd = new MySqlCommand(updateProjectStatus, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ProjectId", projectId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;

                    }
                    catch (Exception ex)
                    {

                        transaction.Rollback();
                        throw new Exception("Profile Updating Failed: " + ex.Message);
                    }
                }
            }
        }

        public bool RejectFreelancer(int bidId)
        {
            try
            {
                string query = "UPDATE biddings SET Status = 'Rejected' WHERE BidId = @BidId;";
                MySqlParameter[] ps =
                    {
                new MySqlParameter("@BidId",bidId),
                
                };

                return db.ExecuteCommand(query, ps);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return false;
        }

        //Approve & complete the project
        public bool ApproveAndCompleteProject(int projectId)
        {
            try
            {
                string query = "UPDATE projects SET Status = 'COMPLETED',CompletedDate = NOW() where ProjectId = @pid";
                MySqlParameter[] ps =
                {
                    new MySqlParameter("@pid",projectId),
                };

                return db.ExecuteCommand(query, ps);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error is {ex.Message}");
                return false;
            }

        }

        public bool RatingFreelancer( Review review)
        {
            try
            {
                string query = "INSERT INTO REVIEWS (ProjectId,ClientId,FreelancerId,Rating,Comment) " +
                    "values (@pid,@cid,@fid,@rating,@comment)";
                MySqlParameter[] ps =
                    {
                new MySqlParameter("@pid",review.ProjectId),
                new MySqlParameter("@cid",review.ClientId),
                new MySqlParameter("@fid",review.FreelancerId),
                new MySqlParameter("@rating",review.Rating),
                new MySqlParameter("@comment",review.Comment),
                };

                return db.ExecuteCommand(query, ps);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error is {ex.Message}");
                return false;
            }
        }

    }

    
}
