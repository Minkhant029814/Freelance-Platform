using Freelance_Platform.Connection;
using Freelance_Platform.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Freelance_Platform.Repositories
{
    internal class BidRepository
    {
        private readonly dbConnect db = new dbConnect();


        public bool SubmitBid(Bidding bid)
        {

            try
            {
                string query = "INSERT INTO Biddings (ProjectId,FreelancerId,Message,BidAmount,Status,SubmissionDate) " +
                    " values (@pid,@fid,@message,@bidAmount,@status,@date)";
                MySqlParameter[] ps =
                    {
                new MySqlParameter("@pid",bid.ProjectId),
                new MySqlParameter("@fid",bid.FreelancerId),
                new MySqlParameter("@message",bid.Message),
                new MySqlParameter("@bidAmount",bid.BidAmount),
                new MySqlParameter("@status",bid.Status ?? "Pending"),
                new MySqlParameter("@date",bid.SubmissionDate)
                };

                return db.ExecuteCommand(query, ps);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public bool CancelBid(int projectId, int freelancerId)
        {
            try
            {
                string query = "UPDATE Biddings SET Status = 'Cancelled' WHERE ProjectId = @pid AND FreelancerId = @fid;";

                MySqlParameter[] ps = {
        new MySqlParameter("@pid", projectId),
        new MySqlParameter("@fid", freelancerId)
    };

                return db.ExecuteCommand(query, ps);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }


       
        public bool HasUserBidded(int projectId, int freelancerId)
        {
            string query = "SELECT COUNT(*) FROM Biddings WHERE ProjectId = @pid AND FreelancerId = @fid AND Status = 'Pending';";
            MySqlParameter[] ps = {
        new MySqlParameter("@pid", projectId),
        new MySqlParameter("@fid", freelancerId)
    };

            
            return Convert.ToInt32(db.GetScaler(query,ps)) > 0;
        }
    }
}
