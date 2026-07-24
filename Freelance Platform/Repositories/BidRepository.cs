using Freelance_Platform.Connection;
using Freelance_Platform.DTO;
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
    public class BidRepository
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


        public List<BidProjectModelDTO> GetBidProjects()
        {
          
            string query = @"SELECT 
    p.ProjectId, 
    p.ProjectTitle, 
    p.Budget, 
    COUNT(b.BidId) AS TotalBids, 
    SUM(CASE WHEN b.SubmissionDate >= NOW() - INTERVAL 1 DAY AND b.Status = 'PENDING' THEN 1 ELSE 0 END) AS NewBidsCount
FROM Projects p
INNER JOIN Biddings b ON p.ProjectId = b.ProjectId
WHERE p.ClientId = @ClientId 
GROUP BY p.ProjectId, p.ProjectTitle, p.Budget
ORDER BY MAX(b.SubmissionDate) DESC;  ";

            MySqlParameter[] ps =
            {
        new MySqlParameter("@ClientId", UserSession.ClientId) 
    };

            DataTable dt = db.GetData(query, ps);
            List<BidProjectModelDTO> projects = new List<BidProjectModelDTO>();

            foreach (DataRow row in dt.Rows)
            {
                BidProjectModelDTO p = new BidProjectModelDTO
                {
                    ProjectId = Convert.ToInt32(row["ProjectId"]),
                    Title = row["ProjectTitle"].ToString(),
                    Budget = Convert.ToDecimal(row["Budget"]),
                    TotalBids = Convert.ToInt32(row["TotalBids"]),
                    NewBids = Convert.ToInt32(row["NewBidsCount"]), 
                };

                projects.Add(p);
            }

            return projects;
        }


        public List<FreelancerBidDTO> GetFreelancerBids(int projectId)
        {
            string query = @"SELECT  p.OwnerName, p.ProfilePic, p.ProfessionalTitle,b.BidId,b.ProjectId, b.BidAmount, b.Message ,b.Status
                 FROM Biddings b 
                 JOIN Portfolios p ON b.FreelancerId = p.FreelancerId 
                 WHERE b.ProjectId = @ProjectId";
            MySqlParameter[] ps =
            {
                new MySqlParameter("@ProjectId", projectId),
             };

            DataTable dt = db.GetData(query, ps);
            List<FreelancerBidDTO> freelancerBids = new List<FreelancerBidDTO>();

            foreach (DataRow row in dt.Rows)
            {
                FreelancerBidDTO bid = new FreelancerBidDTO
                {
                    ProjectId = Convert.ToInt32(row["ProjectId"]),
                    BidId = Convert.ToInt32(row["BidId"]),
                    OwnerName = row["OwnerName"].ToString(),
                    BidAmount = Convert.ToDecimal(row["BidAmount"]),
                    Message = row["Message"].ToString(),
                    ProfessionalTitle = row["ProfessionalTitle"].ToString(),
                    Status = row["Status"].ToString(),
                    ProfilePic = row["ProfilePic"].ToString(),
                    
                };

                freelancerBids.Add(bid);
            }

            return freelancerBids;

        }

    }

}
