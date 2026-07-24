namespace Freelance_Platform.view.components.FreelancerComponent
{
    partial class SearchProjects
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainContainer = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ProjectDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.headContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.mainContainer.SuspendLayout();
            this.headContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.Controls.Add(this.ProjectDisplay);
            this.mainContainer.Controls.Add(this.headContainer);
            this.mainContainer.Location = new System.Drawing.Point(15, 18);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(956, 504);
            this.mainContainer.TabIndex = 0;
            // 
            // ProjectDisplay
            // 
            this.ProjectDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectDisplay.AutoScroll = true;
            this.ProjectDisplay.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ProjectDisplay.Location = new System.Drawing.Point(24, 164);
            this.ProjectDisplay.Name = "ProjectDisplay";
            this.ProjectDisplay.Size = new System.Drawing.Size(917, 320);
            this.ProjectDisplay.TabIndex = 1;
            this.ProjectDisplay.WrapContents = false;
            this.ProjectDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.ProjectDisplay_Paint);
            this.ProjectDisplay.Resize += new System.EventHandler(this.ProjectDisplay_Resize);
            // 
            // headContainer
            // 
            this.headContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headContainer.BorderRadius = 15;
            this.headContainer.Controls.Add(this.txtSearch);
            this.headContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.headContainer.Location = new System.Drawing.Point(20, 15);
            this.headContainer.Name = "headContainer";
            this.headContainer.Size = new System.Drawing.Size(921, 119);
            this.headContainer.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(21, 26);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search by Title....";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(633, 78);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // SearchProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainContainer);
            this.Name = "SearchProjects";
            this.Size = new System.Drawing.Size(990, 534);
            this.Load += new System.EventHandler(this.SearchProjects_Load);
            this.mainContainer.ResumeLayout(false);
            this.headContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel mainContainer;
        private System.Windows.Forms.FlowLayoutPanel ProjectDisplay;
        private Guna.UI2.WinForms.Guna2Panel headContainer;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}
