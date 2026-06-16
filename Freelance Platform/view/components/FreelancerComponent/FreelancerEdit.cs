
using FontAwesome.Sharp;
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

namespace Freelance_Platform.view.components.FreelancerComponent
{
    public partial class FreelancerEdit : UserControl
    {
        public FreelancerEdit()
        {
            InitializeComponent();
        }



        public void LoadData(Freelancer f,List<string> skills)
        {
            lblName.Text = f.Portfolio.OwnerName;
            lblProfessionalTitle.Text = f.Portfolio.ProfessionalTitle;
            txtName.Text = f.Portfolio.OwnerName;
            numPayRate.Value = f.HourlyRate;
            rtxtBio.Text = f.Portfolio.Biography;
            DisplaySkillBlock(skills);
           
            string image = f.Portfolio.Profile;


            if (!string.IsNullOrEmpty(image))
            {
                string imgPath = Path.Combine(Application.StartupPath, "Uploads", image);


                if (File.Exists(imgPath))
                {

                    profilePic.Image = Image.FromFile(imgPath);
                    return;
                }
            }


            profilePic.Image = Properties.Resources.register;
            //profilePic.Image = Image.FromFile(image);
        }


        //Display Skill Tag Block

        private void DisplaySkillBlock(List<string> skills)
        {
            List<string> TotalSkills = skills;
            skillTagPanel.Controls.Clear();

            foreach (string skill in TotalSkills)
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
                  btnSkillTag. Click += (s, ev) => {
                        skillTagPanel.Controls.Remove(btnSkillTag);
                        TotalSkills.Remove(skill);
                };


                skillTagPanel.Controls.Add(btnSkillTag);
            }
        }

        private void FreelancerProfile_Load(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
