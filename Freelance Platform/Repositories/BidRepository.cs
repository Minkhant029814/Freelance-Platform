using Freelance_Platform.Connection;
using Freelance_Platform.DTO;
using Freelance_Platform.Interfaces;
using Freelance_Platform.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;



namespace Freelance_Platform.Repositories
{
    public class BidRepository : IBidRepository
    {
        private readonly dbConnect db = new dbConnect();

        public bool SubmitBid(Bidding bid)
        {
            if (bid == null) throw new ArgumentNullException(nameof(bid));

            try
            {
                string query = "INSERT INTO Biddings (ProjectId,FreelancerId,Message,BidAmount,Status,SubmissionDate) " +
                               "VALUES (@pid,@fid,@message,@bidAmount,@status,@date)";
                MySqlParameter[] ps =
                {
                    new MySqlParameter("@pid", bid.ProjectId),
                    new MySqlParameter("@fid", bid.FreelancerId),
                    new MySqlParameter("@message", bid.Message ?? (object)DBNull.Value),
                    new MySqlParameter("@bidAmount", bid.BidAmount),
                    new MySqlParameter("@status", bid.Status ?? "Pending"),
                    new MySqlParameter("@date", bid.SubmissionDate)
                };

                return db.ExecuteCommand(query, ps);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"SubmitBid failed: {ex}");
                return false;
            }
        }

        public bool CancelBid(int projectId, int freelancerId)
        {
            try
            {
                string query = "UPDATE Biddings SET Status = 'Cancelled' WHERE ProjectId = @pid AND FreelancerId = @fid;";
                MySqlParameter[] ps =
                {
                    new MySqlParameter("@pid", projectId),
                    new MySqlParameter("@fid", freelancerId)
                };

                return db.ExecuteCommand(query, ps);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"CancelBid failed: {ex}");
                return false;
            }
        }

        public bool HasUserBidded(int projectId, int freelancerId)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Biddings WHERE ProjectId = @pid AND FreelancerId = @fid AND Status = 'Pending';";
                MySqlParameter[] ps =
                {
                    new MySqlParameter("@pid", projectId),
                    new MySqlParameter("@fid", freelancerId)
                };

                int count = db.GetScaler(query, ps);
                return count > 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"HasUserBidded failed: {ex}");
                return false;
            }
        }

        public List<BidProjectModelDTO> GetBidProjects(int clientId)
        {
            try
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
ORDER BY MAX(b.SubmissionDate) DESC;";

                MySqlParameter[] ps = { new MySqlParameter("@ClientId", clientId) };

                DataTable dt = db.GetData(query, ps);
                var projects = new List<BidProjectModelDTO>();

                if (dt == null) return projects;

                foreach (DataRow row in dt.Rows)
                {
                    projects.Add(new BidProjectModelDTO
                    {
                        ProjectId = row["ProjectId"] != DBNull.Value ? Convert.ToInt32(row["ProjectId"]) : 0,
                        Title = row["ProjectTitle"]?.ToString() ?? string.Empty,
                        Budget = row["Budget"] != DBNull.Value ? Convert.ToDecimal(row["Budget"]) : 0m,
                        TotalBids = row["TotalBids"] != DBNull.Value ? Convert.ToInt32(row["TotalBids"]) : 0,
                        NewBids = row["NewBidsCount"] != DBNull.Value ? Convert.ToInt32(row["NewBidsCount"]) : 0
                    });
                }

                return projects;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"GetBidProjects failed: {ex}");
                return new List<BidProjectModelDTO>();
            }
        }

        public List<FreelancerBidDTO> GetFreelancerBids(int projectId)
        {
            try
            {
                string query = @"SELECT p.OwnerName, p.ProfilePic, p.ProfessionalTitle, b.BidId, b.ProjectId, b.BidAmount, b.Message, b.Status
                                 FROM Biddings b 
                                 JOIN Portfolios p ON b.FreelancerId = p.FreelancerId 
                                 WHERE b.ProjectId = @ProjectId";
                MySqlParameter[] ps = { new MySqlParameter("@ProjectId", projectId) };

                DataTable dt = db.GetData(query, ps);
                var freelancerBids = new List<FreelancerBidDTO>();

                if (dt == null) return freelancerBids;

                foreach (DataRow row in dt.Rows)
                {
                    freelancerBids.Add(new FreelancerBidDTO
                    {
                        ProjectId = row["ProjectId"] != DBNull.Value ? Convert.ToInt32(row["ProjectId"]) : 0,
                        BidId = row["BidId"] != DBNull.Value ? Convert.ToInt32(row["BidId"]) : 0,
                        OwnerName = row["OwnerName"]?.ToString() ?? string.Empty,
                        BidAmount = row["BidAmount"] != DBNull.Value ? Convert.ToDecimal(row["BidAmount"]) : 0m,
                        Message = row["Message"]?.ToString() ?? string.Empty,
                        ProfessionalTitle = row["ProfessionalTitle"]?.ToString() ?? string.Empty,
                        Status = row["Status"]?.ToString() ?? string.Empty,
                        ProfilePic = row["ProfilePic"]?.ToString() ?? string.Empty
                    });
                }

                return freelancerBids;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"GetFreelancerBids failed: {ex}");
                return new List<FreelancerBidDTO>();
            }
        }
    }
}