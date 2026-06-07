using Freelance_Platform.Connection;
using Freelance_Platform.model;
using MySql.Data.MySqlClient;
using System;
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
                string query = "Insert into users (UserName,Password,UserType) values (@name,@pass,@type);\r\n\r\nSELECT LAST_INSERT_ID();";
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

        public bool Login(string username , string password) 
        {
            try
            {
                //string query = "Select us"
    
            }
            catch (Exception)
            {

                throw;
            }

            return false;
        }

        
    }
}
