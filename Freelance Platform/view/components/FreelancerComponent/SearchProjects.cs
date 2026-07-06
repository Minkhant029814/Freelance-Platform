using Freelance_Platform.Forms.Dashboard;
using Freelance_Platform.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.view.components.FreelancerComponent
{
    public partial class SearchProjects : UserControl
    {
        private readonly List<Project> projects;
        public SearchProjects(List<Project> ps)
        {
            this.projects = ps;
            InitializeComponent();
            ShowProjects(projects);
        }

        private void SearchProjects_Load(object sender, EventArgs e)
        {

        }



        public void ShowProjects(List<Project> projects)
        {
            DisplayContainer.SuspendLayout();
            DisplayContainer.Controls.Clear();

           
           

            foreach (Project p in projects)
            {
                FreeLancerProjectCard card = new FreeLancerProjectCard();

                card.PopulateData(
                    p.ProjectId,
                    p.ProjectTitle,
                    p.Description,
                    p.BaselineBudget.ToString("N0"),
                    p.EndDate.ToString("d/M/yyyy"),
                    p.Status
                );

                card.OnBidChanged += (s, ev) =>
                {
                    // Dashboard ကို လှမ်းခေါ်ပြီး Data အသစ်ပြန် Load ခိုင်းမယ်
                    // (ParentForm က FreelancerDashboard ဖြစ်လို့ Casting သုံးပါတယ်)
                    if (this.ParentForm is FreelancerDashboard dashboard)
                    {
                        dashboard.RefreshAllViews(); // ဒီ method လေး အောက်မှာ ကြည့်ပါ
                    }
                };


                card.Width = DisplayContainer.Width - 32;
                

                DisplayContainer.Controls.Add(card);
            }
            DisplayContainer.ResumeLayout();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
