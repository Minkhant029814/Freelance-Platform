using Freelance_Platform.Connection;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.Repositories
{

    internal class ClientRepository
    {
        private readonly dbConnect db = new dbConnect();

        public bool CreateProfile(int uid,string phone,string email,string address, string profile)
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

    }
}
