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



        public bool UpdateProfile(string name, string email, string phone, string address, string profile)
{
    try
    {
        
        string userQuery = "UPDATE Users SET Username = @name WHERE UserId = @uid";
        MySqlParameter[] userParams = {
            new MySqlParameter("@name", name), 
            new MySqlParameter("@uid", UserSession.UserId)
        };

        
            bool isUserUpdate = db.ExecuteCommand(userQuery, userParams); 
        if (!isUserUpdate) return false; 

        string clientQuery = "UPDATE Clients SET Phone = @phone, Email = @email, Address = @address, ProfilePic = @profile WHERE UserId = @uid";
        MySqlParameter[] clientParams = { 
            new MySqlParameter("@uid", UserSession.UserId),
            new MySqlParameter("@phone", phone),
            new MySqlParameter("@email", email),
            new MySqlParameter("@address", address),
            new MySqlParameter("@profile", profile)
        };

        bool isClientUpdate = db.ExecuteCommand(clientQuery, clientParams);
        if (!isClientUpdate) return false;

       
        UserSession.Username = name;
        UserSession.Phone = phone;
        UserSession.Email = email;
        UserSession.Imagepath = profile; 
        UserSession.Address = address;

        return true; 
    }
    catch (Exception ex)
    {
        throw new Exception("Profile Update Failed..... " + ex.Message);
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
                        // ၁။ ရွေးချယ်လိုက်တဲ့ Freelancer ကို Accepted လုပ်ခြင်း
                        string updateSelectedBid = "UPDATE biddings SET Status = 'Accepted' WHERE BidId = @BidId";

                        // ၂။ အဲ့ဒီ Project ထဲက တခြား Freelancer တွေကို Reject လုပ်ခြင်း
                        // (BidId မတူတဲ့သူတွေကို ရှာပြီး Reject လုပ်တာပါ)
                        string rejectOthers = "UPDATE biddings SET Status = 'Rejected' WHERE ProjectId = @ProjectId AND BidId != @BidId";

                        
                        string updateProjectStatus = "UPDATE projects SET Status = 'IN_PROGRESS' WHERE ProjectId = @ProjectId";


                        // Command များ run ခြင်း
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
                string query = "UPDATE projects SET Status = 'COMPLETED' where ProjectId = @pid";
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
