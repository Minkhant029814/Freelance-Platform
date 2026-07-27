
using Freelance_Platform.DTO;
using Freelance_Platform.Interfaces;
using Freelance_Platform.model;
using Freelance_Platform.Repositories;
using Freelance_Platform.Session;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Freelance_Platform.Service
{
    public class BidService
    {
        private readonly IBidRepository _bidRepository;

        public BidService() : this(new BidRepository()) { }

        public BidService(IBidRepository bidRepository)
        {
            _bidRepository = bidRepository ?? throw new ArgumentNullException(nameof(bidRepository));
        }

        public bool BidSubmit(Bidding bid)
        {
            if (bid == null) throw new ArgumentNullException(nameof(bid));
            return _bidRepository.SubmitBid(bid);
        }

        public bool CancelSubmit(int projectId, int freelancerId)
        {
            return _bidRepository.CancelBid(projectId, freelancerId);
        }

        public bool HasUserBidded(int projectId, int freelancerId)
        {
            return _bidRepository.HasUserBidded(projectId, freelancerId);
        }

        public List<BidProjectModelDTO> GetBidProjects()
        {
            // forward current client id explicitly to repository
            try
            {
                return _bidRepository.GetBidProjects(UserSession.ClientId);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"GetBidProjects failed: {ex}");
                return new List<BidProjectModelDTO>();
            }
        }

        public List<FreelancerBidDTO> GetFreelancerBids(int projectId)
        {
            // Repository returns DTOs with ProfilePic (filename). convert to Image safely here.
            List<FreelancerBidDTO> bidList;
            try
            {
                bidList = _bidRepository.GetFreelancerBids(projectId) ?? new List<FreelancerBidDTO>();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"GetFreelancerBids failed: {ex}");
                return new List<FreelancerBidDTO>();
            }

            foreach (var item in bidList)
            {
                item.ProfileImage = Properties.Resources.register;

                if (string.IsNullOrWhiteSpace(item.ProfilePic)) continue;

                string imgPath = Path.Combine(Application.StartupPath, "Uploads", item.ProfilePic);


                if (!File.Exists(imgPath)) continue;

                try
                {
                    using (var fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read))
                    using (var img = Image.FromStream(fs))
                    {
                        item.ProfileImage = (Image)img.Clone();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Failed to load image {imgPath}: {ex}");
                    item.ProfileImage = Properties.Resources.register;
                }
            }

            return bidList;
        }
    }
}