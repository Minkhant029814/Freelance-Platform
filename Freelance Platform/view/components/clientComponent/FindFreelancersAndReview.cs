using Freelance_Platform.DTO;
using Freelance_Platform.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.view.components.clientComponent
{
    public partial class FindFreelancersAndReview : UserControl
    {
        private readonly List<FreelancerCardDTO> freelancers;
        private FreelancerCards card;
        private FreelancerService fservice;
        public FindFreelancersAndReview(List<FreelancerCardDTO> f)
        {
            InitializeComponent();
            this.freelancers = f;
            fservice = new FreelancerService();
            DisplayFreelancerCards(freelancers);
            lblProfessionalCount.Text = freelancers.Count.ToString() + " Professionals Founds";

            
        }


        private void DisplayFreelancerCards(List<FreelancerCardDTO> fs)
        {
            if(fs != null)
            {
                foreach(FreelancerCardDTO f in fs)
                {
                    card = new FreelancerCards(f);
                    professionalDisplayPanel.Controls.Add(card);
                }
            }
        }

        //Search by Text
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            professionalDisplayPanel.Controls.Clear();

            var freelancers = fservice.GetFreelancerCards(txtSearch.Text);

            foreach (var item in freelancers)
            {
                 card = new FreelancerCards(item);
               professionalDisplayPanel.Controls.Add(card);
            }
        }
    }
}
