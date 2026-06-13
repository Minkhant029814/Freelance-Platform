using Freelance_Platform.Connection;
using Freelance_Platform.Session;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

    }
}
