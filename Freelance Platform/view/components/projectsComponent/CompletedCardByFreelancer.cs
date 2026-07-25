using Freelance_Platform.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.view.components.projectsComponent
{
    public partial class CompletedCardByFreelancer : UserControl
    {
        public CompletedCardByFreelancer(CompletedProjectReviewDTO project)
        {
            InitializeComponent();
            DisplayData(project);
        }

        private void DisplayData(CompletedProjectReviewDTO p)
        {
            lblProjectTitle.Text = p.ProjectTitle;
            lblClientName.Text = p.ClientName;
            lblComment.Text = p.Comment;
            ratingStar.Value = p.Rating;
            lblPayment.Text = $"$ {p.ProjectBudget}";
            lblCompletedDate.Text = $"Completed {p.CompletedDate:dd MMMM yyyy}";

        }
    }
}
