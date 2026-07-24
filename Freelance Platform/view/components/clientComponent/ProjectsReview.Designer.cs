namespace Freelance_Platform.view.components.clientComponent
{
    partial class ProjectsReview
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
            this.mainContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.planning = new System.Windows.Forms.TabPage();
            this.planningCardDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.inProgress = new System.Windows.Forms.TabPage();
            this.InProgressDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.Review = new System.Windows.Forms.TabPage();
            this.ReviewLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.completed = new System.Windows.Forms.TabPage();
            this.CompletedDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.headContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTotalProjects = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.mainContainer.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.planning.SuspendLayout();
            this.inProgress.SuspendLayout();
            this.Review.SuspendLayout();
            this.completed.SuspendLayout();
            this.headContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.BackColor = System.Drawing.Color.White;
            this.mainContainer.Controls.Add(this.guna2TabControl1);
            this.mainContainer.Controls.Add(this.headContainer);
            this.mainContainer.Location = new System.Drawing.Point(14, 15);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(980, 597);
            this.mainContainer.TabIndex = 0;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TabControl1.Controls.Add(this.planning);
            this.guna2TabControl1.Controls.Add(this.inProgress);
            this.guna2TabControl1.Controls.Add(this.Review);
            this.guna2TabControl1.Controls.Add(this.completed);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(18, 154);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(944, 417);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 1;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.guna2TabControl1.SelectedIndexChanged += new System.EventHandler(this.guna2TabControl1_SelectedIndexChanged);
            // 
            // planning
            // 
            this.planning.BackColor = System.Drawing.Color.Transparent;
            this.planning.Controls.Add(this.planningCardDisplay);
            this.planning.Location = new System.Drawing.Point(4, 44);
            this.planning.Name = "planning";
            this.planning.Padding = new System.Windows.Forms.Padding(3);
            this.planning.Size = new System.Drawing.Size(936, 369);
            this.planning.TabIndex = 0;
            this.planning.Text = "Planning";
            // 
            // planningCardDisplay
            // 
            this.planningCardDisplay.AutoScroll = true;
            this.planningCardDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.planningCardDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planningCardDisplay.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.planningCardDisplay.Location = new System.Drawing.Point(3, 3);
            this.planningCardDisplay.Name = "planningCardDisplay";
            this.planningCardDisplay.Size = new System.Drawing.Size(930, 363);
            this.planningCardDisplay.TabIndex = 0;
            this.planningCardDisplay.WrapContents = false;
            this.planningCardDisplay.Resize += new System.EventHandler(this.planningCardDisplay_Resize);
            // 
            // inProgress
            // 
            this.inProgress.Controls.Add(this.InProgressDisplay);
            this.inProgress.Location = new System.Drawing.Point(4, 44);
            this.inProgress.Name = "inProgress";
            this.inProgress.Padding = new System.Windows.Forms.Padding(3);
            this.inProgress.Size = new System.Drawing.Size(936, 369);
            this.inProgress.TabIndex = 1;
            this.inProgress.Text = "In Progress";
            this.inProgress.UseVisualStyleBackColor = true;
            // 
            // InProgressDisplay
            // 
            this.InProgressDisplay.AutoScroll = true;
            this.InProgressDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InProgressDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InProgressDisplay.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.InProgressDisplay.Location = new System.Drawing.Point(3, 3);
            this.InProgressDisplay.Name = "InProgressDisplay";
            this.InProgressDisplay.Size = new System.Drawing.Size(930, 363);
            this.InProgressDisplay.TabIndex = 0;
            this.InProgressDisplay.WrapContents = false;
            this.InProgressDisplay.Resize += new System.EventHandler(this.InProgressDisplay_Resize);
            // 
            // Review
            // 
            this.Review.Controls.Add(this.ReviewLayout);
            this.Review.Location = new System.Drawing.Point(4, 44);
            this.Review.Name = "Review";
            this.Review.Size = new System.Drawing.Size(936, 369);
            this.Review.TabIndex = 3;
            this.Review.Text = " Submission";
            this.Review.UseVisualStyleBackColor = true;
            // 
            // ReviewLayout
            // 
            this.ReviewLayout.AutoScroll = true;
            this.ReviewLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ReviewLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReviewLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ReviewLayout.Location = new System.Drawing.Point(0, 0);
            this.ReviewLayout.Name = "ReviewLayout";
            this.ReviewLayout.Size = new System.Drawing.Size(936, 369);
            this.ReviewLayout.TabIndex = 0;
            this.ReviewLayout.WrapContents = false;
            this.ReviewLayout.Resize += new System.EventHandler(this.ReviewLayout_Resize);
            // 
            // completed
            // 
            this.completed.Controls.Add(this.CompletedDisplay);
            this.completed.Location = new System.Drawing.Point(4, 44);
            this.completed.Name = "completed";
            this.completed.Padding = new System.Windows.Forms.Padding(3);
            this.completed.Size = new System.Drawing.Size(936, 369);
            this.completed.TabIndex = 2;
            this.completed.Text = "Completed";
            this.completed.UseVisualStyleBackColor = true;
            // 
            // CompletedDisplay
            // 
            this.CompletedDisplay.AutoScroll = true;
            this.CompletedDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CompletedDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompletedDisplay.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CompletedDisplay.Location = new System.Drawing.Point(3, 3);
            this.CompletedDisplay.Name = "CompletedDisplay";
            this.CompletedDisplay.Size = new System.Drawing.Size(930, 363);
            this.CompletedDisplay.TabIndex = 0;
            this.CompletedDisplay.WrapContents = false;
            this.CompletedDisplay.Resize += new System.EventHandler(this.CompletedDisplay_Resize);
            // 
            // headContainer
            // 
            this.headContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headContainer.Controls.Add(this.iconPictureBox2);
            this.headContainer.Controls.Add(this.lblTotalProjects);
            this.headContainer.Controls.Add(this.label2);
            this.headContainer.Controls.Add(this.label1);
            this.headContainer.Controls.Add(this.iconPictureBox1);
            this.headContainer.Location = new System.Drawing.Point(18, 18);
            this.headContainer.Name = "headContainer";
            this.headContainer.Size = new System.Drawing.Size(944, 100);
            this.headContainer.TabIndex = 0;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 47;
            this.iconPictureBox2.Location = new System.Drawing.Point(671, 38);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(47, 47);
            this.iconPictureBox2.TabIndex = 4;
            this.iconPictureBox2.TabStop = false;
            // 
            // lblTotalProjects
            // 
            this.lblTotalProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalProjects.AutoSize = true;
            this.lblTotalProjects.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProjects.Location = new System.Drawing.Point(763, 50);
            this.lblTotalProjects.Name = "lblTotalProjects";
            this.lblTotalProjects.Size = new System.Drawing.Size(116, 25);
            this.lblTotalProjects.TabIndex = 3;
            this.lblTotalProjects.Text = "Total Projects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage project planning, delivery, and feedback";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project  WorkSpace";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Suitcase;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 47;
            this.iconPictureBox1.Location = new System.Drawing.Point(14, 28);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(47, 47);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // ProjectsReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "ProjectsReview";
            this.Size = new System.Drawing.Size(1007, 626);
            this.mainContainer.ResumeLayout(false);
            this.guna2TabControl1.ResumeLayout(false);
            this.planning.ResumeLayout(false);
            this.inProgress.ResumeLayout(false);
            this.Review.ResumeLayout(false);
            this.completed.ResumeLayout(false);
            this.headContainer.ResumeLayout(false);
            this.headContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private Guna.UI2.WinForms.Guna2Panel headContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage planning;
        private System.Windows.Forms.TabPage inProgress;
        private System.Windows.Forms.TabPage completed;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label lblTotalProjects;
        private System.Windows.Forms.FlowLayoutPanel planningCardDisplay;
        private System.Windows.Forms.FlowLayoutPanel InProgressDisplay;
        private System.Windows.Forms.FlowLayoutPanel CompletedDisplay;
        private System.Windows.Forms.TabPage Review;
        private System.Windows.Forms.FlowLayoutPanel ReviewLayout;
    }
}
