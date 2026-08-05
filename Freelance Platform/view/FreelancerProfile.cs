using FontAwesome.Sharp;
using Freelance_Platform.model;
using Freelance_Platform.Service;
using Freelance_Platform.view.components.FreelancerComponent;
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
//using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Freelance_Platform.Forms
{
    public partial class FreelancerProfile : Form
    {
        private readonly int userId;
      
        private readonly string name;
        private readonly FreelancerService freelancerService = new FreelancerService();
        private readonly List<string> selectedSkillsList = new List<string>();
        public FreelancerProfile(int userId,string name)
        {
            InitializeComponent();
            txtName.Text = name;
            this.userId = userId;
            this.name = name;
        }

        private void FreelancerProfile_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            btnUploadPhoto.Image = IconChar.Upload.ToBitmap( Color.White, 30);
            txtEmail.IconLeft = IconChar.MailBulk.ToBitmap(Color.Gray, 20);
            btnAddSkill.Image = IconChar.Add.ToBitmap(Color.White, 30);
            btnSaveProfile.Image = IconChar.Save.ToBitmap(Color.White, 30);
            
            //txtEmail.IconLeftSize = new Size(20, 20);

            txtExternalLink.IconLeft = IconChar.Link.ToBitmap(Color.Gray, 20);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            string selectedSkill = comboSkill.Text.ToString();

            if(string.IsNullOrEmpty(selectedSkill) || selectedSkillsList.Contains(selectedSkill))
            {
                return;
            }

            selectedSkillsList.Add(selectedSkill);

            Guna2Button btnSkillTag = new Guna2Button();
         
            btnSkillTag.Image = IconChar.Xmark.ToBitmap(Color.White, 16); 
            btnSkillTag.ImageAlign = HorizontalAlignment.Right; 
            
            btnSkillTag.Text = selectedSkill;
            btnSkillTag.TextAlign = HorizontalAlignment.Left;
            btnSkillTag.TextOffset = new Point(5, 0); 

           
            btnSkillTag.AutoSize = true;
            btnSkillTag.FillColor = Color.FromArgb(11, 115, 168); 
            btnSkillTag.ForeColor = Color.White;
            btnSkillTag.BorderRadius = 15; 
            btnSkillTag.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            btnSkillTag.Margin = new Padding(4);

            
            btnSkillTag.Padding = new Padding(10, 5, 10, 5);

            btnSkillTag.Click += (s, ev) => {
                SkillDisplayLayout.Controls.Remove(btnSkillTag); 
                selectedSkillsList.Remove(selectedSkill);       
            };

            SkillDisplayLayout.Controls.Add(btnSkillTag);
        }

        private void txtExternalLink_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLayout_Scroll(object sender, ScrollEventArgs e)
        {
            FormLayout.Invalidate();
        }

        string selectedFilePath = "";
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = ofd.FileName;
                   
                    profilePict.Image = Image.FromFile(selectedFilePath);

                }
            }
        }
      private readonly  Freelancer freelancer = new Freelancer();
        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtBiogarphy.Text))
            {
                MessageBox.Show("Please fill in the required fields (Email and Biography).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
               
               

              
                freelancer.FreelancerId = this.userId;
                freelancer.HourlyRate = numPayRate.Value;
                freelancer.Expertise = ComboExpertise.Text;

              
                freelancer.Portfolio.OwnerName = txtName.Text;
                freelancer.Portfolio.Biography = txtBiogarphy.Text;

                freelancer.Portfolio.ProfessionalTitle = ComboExpertise.Text;
                freelancer.Portfolio.ContactEmail = txtEmail.Text;
                freelancer.Portfolio.ExternalLink = txtExternalLink.Text;

             
                

                
                freelancer.Skills = selectedSkillsList;

                
                string profileFileName = HandleImageUpload(this.userId, selectedFilePath);

                if (profileFileName == "ERROR")
                {
                    return; 
                }

               
                bool flag = freelancerService.CreateProfile(freelancer, profileFileName);

                if (flag)
                {
                    MessageBox.Show("Profile successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectedFilePath = "";

                
                    this.Hide();
                    frmLogin loginForm = new frmLogin();
                    loginForm.Show();
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


        //handling photo
        private string HandleImageUpload(int userId, string sourceFilePath)
        {

            if (string.IsNullOrEmpty(sourceFilePath))
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

        private void btnAddPastWork_Click(object sender, EventArgs e)
        {
            new AddPastWorksForm(this.freelancer).ShowDialog();
        }

        private void ComboExpertise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
