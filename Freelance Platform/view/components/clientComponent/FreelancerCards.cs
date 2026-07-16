using FontAwesome.Sharp;
using Freelance_Platform.DTO;
using Freelance_Platform.model;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.view.components.clientComponent
{
    public partial class FreelancerCards : UserControl
    {
        private readonly FreelancerCardDTO freelancer;
        private readonly int freelancerId;

     
        public FreelancerCards(FreelancerCardDTO f)
        {
            InitializeComponent();
            this.freelancer = f;
            this.freelancerId = f.FreelancerId;
            DisplayData(freelancer);
        }

        private void DisplayData(FreelancerCardDTO f)
        {
            lblName.Text = f.OwnerName;
            lblProfessionalTitle.Text = f.ProfessionalTitle;
            lblPayRate.Text = f.HourlyRate.ToString();
            lblDescription.Text = f.Biography;

            //for Profile picutre
            string imgPath = Path.Combine(Application.StartupPath, "Uploads", f.ProfilePic ?? "");
            profilePic.Image = (File.Exists(imgPath)) ? Image.FromFile(imgPath) : Properties.Resources.register;

            //Display Skill Panel
            if(f.Skills != null)
            {
                skillDisplayPanel.Controls.Clear();
                foreach (string skill in f.Skills)
                {
                    CreateSkillButton(skill);
                }
            }
        }


        private void CreateSkillButton(string skill)
        {
            Guna2Button btnSkillTag = new Guna2Button
            {
                Image = IconChar.Xmark.ToBitmap(Color.White, 16),
                ImageAlign = HorizontalAlignment.Right,
                Text = skill,
                TextAlign = HorizontalAlignment.Left,
                TextOffset = new Point(5, 0),
                AutoSize = true,
                FillColor = Color.FromArgb(11, 115, 168),
                ForeColor = Color.White,
                BorderRadius = 15,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                Margin = new Padding(4),
                Padding = new Padding(10, 5, 10, 5),
            };

            skillDisplayPanel.Controls.Add(btnSkillTag);
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            new FreelancerDetails().ShowDialog();
        }
    }
}
