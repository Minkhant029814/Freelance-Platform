using Freelance_Platform.Connection;
using Freelance_Platform.model;
using Freelance_Platform.Session;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace Freelance_Platform.Repositories
{
    internal class UserRepository
    {

        // Create object to do database Operations
        private readonly dbConnect db = new dbConnect();

        public int Register (User user)
        {
            

            try
            {
                string query = "Insert into users (UserName,Password,UserType) values (@name,@pass,@type);\r\n\r\n SELECT LAST_INSERT_ID();";
                MySqlParameter[] ps =
                {
                new MySqlParameter("@name", user.Username),
                new MySqlParameter("@pass",user.Password),
                new MySqlParameter("@type",user.Type),

            };
                return db.GetScaler(query, ps);

            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }


        }

        public bool Login(string username, string password)
        {
            try
            {
                
                string userQuery = "SELECT UserId, UserType FROM users WHERE UserName = @username AND Password = @pass";
                MySqlParameter[] userParams = {
            new MySqlParameter("@username", username),
            new MySqlParameter("@pass", password)
        };

                DataTable dtUser = db.GetData(userQuery, userParams);

               
                if (dtUser == null || dtUser.Rows.Count == 0) return false;

                int userId = Convert.ToInt32(dtUser.Rows[0]["UserId"]);
                string userType = dtUser.Rows[0]["UserType"].ToString();

              
                UserSession.UserId = userId;
                UserSession.UserType = userType;
                UserSession.IsLoggedIn = true;

               
                if (userType == "Freelancer")
                {
                    //LoadFreelancerSession(userId);
                    MessageBox.Show("Wait for Freelaner....");
                }
                else if (userType == "Client")
                {
                    LoadClientSession(userId);
                }

                return true; 
            }
            catch (Exception ex)
            {
             
                throw new Exception("Login လုပ်ဆောင်ရာတွင် အမှားအယွင်းရှိပါသည် - " + ex.Message);
            }
        }

     
        //private void LoadFreelancerSession(int userId)
        //{
        //    string query = "SELECT FreelancerId, Phone, Email FROM freelancers WHERE UserId = @id";
        //    MySqlParameter[] ps = { new MySqlParameter("@id", userId) };
        //    DataTable dt = db.GetData(query, ps);

        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        UserSession.FreelancerId = Convert.ToInt32(dt.Rows[0]["FreelancerId"]);
        //        UserSession.Phone = dt.Rows[0]["Phone"].ToString();
        //        UserSession.Email = dt.Rows[0]["Email"].ToString();
        //    }
        //}

       
        private void LoadClientSession(int userId)
        {
            string query = "SELECT ClientId, Phone, Email FROM clients WHERE UserId = @id";
            MySqlParameter[] ps = { new MySqlParameter("@id", userId) };
            DataTable dt = db.GetData(query, ps);

            if (dt != null && dt.Rows.Count > 0)
            {
                UserSession.ClientId = Convert.ToInt32(dt.Rows[0]["ClientId"]);
                UserSession.Phone = dt.Rows[0]["Phone"].ToString();
                UserSession.Email = dt.Rows[0]["Email"].ToString();
            }
        }


    }
}
