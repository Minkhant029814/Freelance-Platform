
using FontAwesome.Sharp;
using Freelance_Platform.Forms.Dashboard;
using Freelance_Platform.model;
using Freelance_Platform.Service;
using Freelance_Platform.Session;
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
        private List<string> currentSkills = new List<string>();
        private  Freelancer freelancer = new Freelancer();
        private readonly FreelancerService service = new FreelancerService();
        private readonly FreelancerDashboard dashboard;
        //private readonly PastWorksCard  = new PastWorksCard();

      
        public FreelancerEdit(FreelancerDashboard d)
        {
            this.dashboard = d;
          
            InitializeComponent();
            btnAddProjects.Image = IconChar.Add.ToBitmap(Color.White, 30);
            //btnEditProfile.Image = IconChar.Edit.ToBitmap(Color.White, 30);
            btnEditProfile.Image = IconChar.Save.ToBitmap(Color.White, 30);
            btnEditImage.Image = IconChar.Edit.ToBitmap(Color.White, 30);


        }

        private void DisplayPastProjects(List<Project> projects)
        {

            cardDisplayLayout.Controls.Clear();

            if (projects == null || projects.Count == 0) return;

            foreach (Project p in projects)
            {

                PastWorksCard card = new PastWorksCard();

                card.LoadData(p);

                //card.Dock = DockStyle.Fill;
                cardDisplayLayout.Controls.Add(card);
            }
        }

    

        public void LoadData(Freelancer f)
        {
            this.freelancer = f;
            lblName.Text = freelancer.Portfolio.OwnerName;
            lblProfessionalTitle.Text = freelancer.Portfolio.ProfessionalTitle;
            txtName.Text = freelancer.Portfolio.OwnerName;
            numPayRate.Value = freelancer.HourlyRate;
            rtxtBio.Text = freelancer.Portfolio.Biography;
            ComboExpertise.Text = f.Expertise;
            if(freelancer.Portfolio.Projects.Count == 0)
            {
                lblProjectsCount.Text =  " no Projects";
            }else
            {
                lblProjectsCount.Text = freelancer.Portfolio.Projects.Count.ToString() + " Projects";
            }
                
            this.currentSkills = new List<string>(f.Skills);
            DisplaySkillBlock();
            DisplayPastProjects(freelancer.Portfolio.Projects);
            string image = freelancer.Portfolio.Profile;
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

        }

        //Create Button UI
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
            btnSkillTag.Click += (s, ev) =>
            {
                skillTagPanel.Controls.Remove(btnSkillTag);
                this.currentSkills.Remove(skill);
            };

            skillTagPanel.Controls.Add(btnSkillTag);


        }

        //Display Skill Tag Block

        private void DisplaySkillBlock()
        {

            skillTagPanel.Controls.Clear();

            foreach (string skill in currentSkills)
            {
                CreateSkillButton(skill);


            }
        }

        private void FreelancerProfile_Load(object sender, EventArgs e)
        {
            btnSkillAdd.Image = IconChar.Add.ToBitmap(Color.White, 30);
        }

       

        

        

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CardDisplayFlow_SizeChanged(object sender, EventArgs e)
        {
           
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {

        }

       
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSkillAdd_Click(object sender, EventArgs e)
        {
            string newSkills = comboSkills.Text.Trim();

            if (string.IsNullOrEmpty(newSkills) || currentSkills.Contains(newSkills))
            {
                return;
            }
            currentSkills.Add(newSkills);
            CreateSkillButton(newSkills);
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblProjectsCount_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProjects_Click(object sender, EventArgs e)
        {
            new AddProjectForm(this.freelancer).ShowDialog();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {

            try
            {

                freelancer.FreelancerId = (int)UserSession.FreelancerId;
                freelancer.Expertise = ComboExpertise.Text;
                freelancer.HourlyRate = numPayRate.Value;
                freelancer.Skills = currentSkills;
                freelancer.Portfolio.ProfessionalTitle = ComboExpertise.Text;
                freelancer.Portfolio.Biography = rtxtBio.Text;
                freelancer.Portfolio.OwnerName = txtName.Text;




                string profileFileName;
                if (string.IsNullOrEmpty(selectedFilePath))
                {
                    profileFileName = freelancer.Portfolio.Profile;
                }
                else
                {
                    profileFileName   = HandleImageUpload(Convert.ToInt32(UserSession.FreelancerId), selectedFilePath);
                }
                   

                if (profileFileName == "ERROR")
                {
                    return;
                }

                bool flag = service.UpdateProfile(freelancer, profileFileName);

                if (flag)
                {
                    
                    MessageBox.Show("Profile successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dashboard.DisplayDashboard();
                   
                    selectedFilePath = "";


                   
                }
                else
                {
                    MessageBox.Show("Failed to save profile. Database transaction error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("An unexpected error occurred: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string selectedFilePath = "";
        private void btnEditImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = ofd.FileName;

                    profilePic.Image = Image.FromFile(selectedFilePath);

                }
            }
        }

        //handling photo
        private string HandleImageUpload(int userId, string sourceFilePath)
        {

            if (string.IsNullOrEmpty(sourceFilePath) || !File.Exists(sourceFilePath))
            {
                return null;
            }

            try
            {

                string targetFolder = Path.Combine(Application.StartupPath, "Uploads");
                if (!Directory.Exists(targetFolder))
                {
                    Directory.CreateDirectory(targetFolder);
                }


                string uniqueFileName = "Freelacer_" + userId + Path.GetExtension(sourceFilePath);
                string destinationPath = Path.Combine(targetFolder, uniqueFileName);


                File.Copy(sourceFilePath, destinationPath, true);


                return uniqueFileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image upload failed.... " + ex.Message, "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "ERROR";
            }
        }
    }
}
