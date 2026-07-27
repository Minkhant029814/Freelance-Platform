using Freelance_Platform.Connection;
using Freelance_Platform.Interfaces;
using Freelance_Platform.model;
using Freelance_Platform.Session;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;


namespace Freelance_Platform.Repositories
{
    internal class UserRepository : IUserRepository
    {

        // Create object to do database Operations
        private readonly dbConnect db = new dbConnect();

        public int Register (User user)
        {
            if (user == null) throw new ArgumentException(nameof(user));

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
                Debug.WriteLine($"Register : duplicate username {user.Username}");
                return 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Register failed :{ex}");
                return 0;
            }


        }

        public (int userId, string userType, string username) Authenticate(string name, string pass)
        {
            try
            {
                string userQuery = "SELECT UserId, Username, UserType FROM users WHERE Username = @username AND Password = @pass";
                MySqlParameter[] userParams = {
                    new MySqlParameter("@username", name),
                    new MySqlParameter("@pass", pass)
                };

                DataTable dtUser = db.GetData(userQuery, userParams);

                if (dtUser == null || dtUser.Rows.Count == 0) return (0, null, null);

                int userId = Convert.ToInt32(dtUser.Rows[0]["UserId"]);
                string userType = dtUser.Rows[0]["UserType"].ToString();
                string username = dtUser.Rows[0]["Username"].ToString();

                return (userId, userType, username);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Authenticate failed: {ex}");
                return (0, null, null);
            }
        }

        public int? GetFreelancerId(int userId)
        {
            try
            {
                string query = "SELECT FreelancerId FROM freelancers WHERE UserId = @id";
                MySqlParameter[] ps = { new MySqlParameter("@id", userId) };
                DataTable dt = db.GetData(query, ps);

                if (dt != null && dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0]["FreelancerId"]);
                }

                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"GetFreelancerId failed: {ex}");
                return null;
            }
        }

        public int? GetClientId(int userId)
        {
            try
            {
                string query = "SELECT ClientId FROM clients WHERE UserId = @id";
                MySqlParameter[] ps = { new MySqlParameter("@id", userId) };
                DataTable dt = db.GetData(query, ps);

                if (dt != null && dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0]["ClientId"]);
                }

                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"GetClientId failed: {ex}");
                return null;
            }
        }


        private void LoadClientSession(int userId)
        {
            string query = "SELECT ClientId, Phone, Email,ProfilePic,Address FROM clients WHERE UserId = @id";
            MySqlParameter[] ps = { new MySqlParameter("@id", userId) };
            DataTable dt = db.GetData(query, ps);

            if (dt != null && dt.Rows.Count > 0)
            {
                UserSession.ClientId = Convert.ToInt32(dt.Rows[0]["ClientId"]);
                //UserSession.Phone = dt.Rows[0]["Phone"].ToString();
                //UserSession.Email = dt.Rows[0]["Email"].ToString();
                //UserSession.Imagepath = dt.Rows[0]["ProfilePic"].ToString();
                //UserSession.Address = dt.Rows[0]["Address"].ToString();
            }
        }


    }
}
