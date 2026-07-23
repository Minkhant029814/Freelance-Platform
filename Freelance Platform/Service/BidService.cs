using Freelance_Platform.DTO;
using Freelance_Platform.model;
using Freelance_Platform.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Freelance_Platform.Service
{
    public class BidService
    {
        private readonly BidRepository bidRepository = new BidRepository();

        public bool BidSubmit(Bidding bid)
        {
            return bidRepository.SubmitBid(bid);
        }

        public bool CancelSubmit(int projectId,int freelancerId)
        {
            return bidRepository.CancelBid(projectId, freelancerId);
        }

        public bool HasUserBidded(int projectId,int freelancerId)
        {
            return bidRepository.HasUserBidded(projectId, freelancerId);
        }

        public List<BidProjectModel> GetBidProjects()
        {
            return bidRepository.GetBidProjects();
        }

        public List<FreelancerBidDTO> GetFreelancerBids(int projectId)
        {
            // Repository က Data အရင်ယူ
            List<FreelancerBidDTO> bidList = bidRepository.GetFreelancerBids(projectId);

            // ProfilePic (string) -> ProfileImage (Image)
            foreach (var item in bidList)
            {
                string imgPath = Path.Combine(Application.StartupPath, "Uploads", item.ProfilePic);

                if (File.Exists(imgPath))
                {
                    try
                    {
                        // File Lock မဖြစ်အောင် Clone လုပ်
                        using (var img = Image.FromFile(imgPath))
                        {
                            item.ProfileImage = (Image)img.Clone();
                        }
                    }
                    catch
                    {
                        item.ProfileImage = Properties.Resources.register;
                    }
                }
                else
                {
                    item.ProfileImage = Properties.Resources.register;
                }
            }

            return bidList;
        }
    }
}
