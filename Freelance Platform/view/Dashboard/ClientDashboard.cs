using FontAwesome.Sharp;
using Freelance_Platform.components;
using Freelance_Platform.DTO;
using Freelance_Platform.model;
using Freelance_Platform.Service;
using Freelance_Platform.Session;
using Freelance_Platform.view.components.clientComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.Forms.Dashboard
{
    public partial class ClientDashboard : Form
    {
        private  ProfileEdit profilePage;
        private BidReceived bidReceived;
        private FindFreelancersAndReview findFreelancerPage;
        private FreelancerService freelancerService;
       
      private readonly  ProjectService service = new ProjectService();
      
        public ClientDashboard()
        {
            InitializeComponent();
            lblGreeting.Text = "Welcome back, " + UserSession.Username;
            lblsubtitle.Text = "Here's what's happening with your projects today.";
            freelancerService = new FreelancerService();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            lblGreeting.Text = "Welcome back, " + UserSession.Username;
            lblsubtitle.Text = "Here's what's happening with your projects today.";
           


            if (profilePage != null)
            {
                profilePage.Visible = false;
            }

            if(bidReceived != null)
            {
                bidReceived.Visible = false;
               
            }
            
           
            tableLayoutPanel1.Visible = true;
            btnPostProject.Visible = true;
            projectDisplayLayout.Visible = true;
            guna2Panel4.Visible = true;
            guna2Panel5.Visible = true;
            panelDashboardContent.Visible = true;
            panelDashboardContent.BringToFront();

            DisplayProjectCards();
        }

        private void lblProject_Click(object sender, EventArgs e)
        {

        }

        
        private void DisplayProjectCards()
        {
            

            projectDisplayLayout.Controls.Clear();

           
           
            List<Project> activeProjects = service.GetAllProjectsListById();

           
            foreach (Project proj in activeProjects)
            {
                
                ProjectCardRow card = new ProjectCardRow();

           
                card.PopulateData(

                    proj.ProjectTitle,
                    proj.Description,
                    proj.BaselineBudget.ToString("N0"), 
                    proj.EndDate.ToString("d/M/yyyy"),
                    proj.CurrentStatus.ToString()
                );


                card.Width = projectDisplayLayout.ClientSize.Width - 30;

                
              projectDisplayLayout.Controls.Add(card);
            }
        }
        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            
            btnPostProject.Image = IconChar.PlusCircle.ToBitmap(Color.White, 30);
           
           

            DisplayProjectCards();
            panelDashboardContent_Resize(null, null);
        }

       
        //for Profile NavBar

        //Updating User profiel

        private void UpdateProfile()
        {
            profilePage.UpdateProfile(
            name: UserSession.Username,
            email: UserSession.Email,
            phone: UserSession.Phone,
            location: UserSession.Address,
            image: UserSession.Imagepath
     );
        }
      

        private void btnProfile_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Your Profile ";
            lblsubtitle.Text = "Manage your company details and contact information.";

            if (profilePage == null)
            {
                profilePage = new ProfileEdit();
                profilePage.Dock = DockStyle.Fill;

                
                guna2Panel3.Controls.Add(profilePage);
            }

            UpdateProfile();


            
            btnPostProject.Visible = false;
            tableLayoutPanel1.Visible = false;
            profilePage.Visible = true;
            profilePage.BringToFront();


        }

        private void btnPostProject_Click_1(object sender, EventArgs e)
        {
            new PostProjectForm().ShowDialog();
        }

        private void panelDashboardContent_Resize(object sender, EventArgs e)
        {
            projectDisplayLayout.Width = panelDashboardContent.ClientSize.Width - 30;

            
            foreach (Control ctrl in projectDisplayLayout.Controls)
            {
                if (ctrl is ProjectCardRow)
                {
                    ctrl.Width = projectDisplayLayout.ClientSize.Width - 30;
                }
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to log out?",
                                                   "Sign Out",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                UserSession.Logout();


                frmLogin loginForm = new frmLogin();
                loginForm.Show();


                this.Hide();

            }
        }

        private void btnBidReceived_Click(object sender, EventArgs e)
        {
            
            lblGreeting.Text = "Bid Received";
            lblsubtitle.Text = "Review and Respond to Freelancer Proposal ";
            
            guna2Panel5.Visible = false;
            guna2Panel4.Visible = true;
            projectDisplayLayout.Visible = false;
            if (profilePage != null)
            {
                profilePage.Visible = false;
            }
            tableLayoutPanel1.Visible = true;
            btnPostProject.Visible = false;

          
            bidReceived = new BidReceived();
            guna2Panel4.Controls.Add(bidReceived);
            bidReceived.Dock = DockStyle.Fill;
            bidReceived.BringToFront();
            bidReceived.Visible = true;
        }

        private void btnFindFreelancers_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Find Freelancers";
            lblsubtitle.Text = "Discover proven professionals for your next project";
            guna2Panel4.Visible = false;
            tableLayoutPanel1.Visible = false;
            if(findFreelancerPage == null)
            {
                List<FreelancerCardDTO> freelancers = freelancerService.GetFreelancerCards();
                findFreelancerPage = new FindFreelancersAndReview(freelancers);
                findFreelancerPage.Dock = DockStyle.Fill;
                guna2Panel3.Controls.Add(findFreelancerPage);
            }
            findFreelancerPage.Visible = true;
            findFreelancerPage.BringToFront();
            
        }
    }
}
