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
            this.headContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalProjects = new System.Windows.Forms.Label();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.planning = new System.Windows.Forms.TabPage();
            this.inProgress = new System.Windows.Forms.TabPage();
            this.completed = new System.Windows.Forms.TabPage();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.planningCardDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.mainContainer.SuspendLayout();
            this.headContainer.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.planning.SuspendLayout();
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
            this.mainContainer.Size = new System.Drawing.Size(940, 597);
            this.mainContainer.TabIndex = 0;
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
            this.headContainer.Size = new System.Drawing.Size(904, 100);
            this.headContainer.TabIndex = 0;
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
            // lblTotalProjects
            // 
            this.lblTotalProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalProjects.AutoSize = true;
            this.lblTotalProjects.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProjects.Location = new System.Drawing.Point(723, 50);
            this.lblTotalProjects.Name = "lblTotalProjects";
            this.lblTotalProjects.Size = new System.Drawing.Size(116, 25);
            this.lblTotalProjects.TabIndex = 3;
            this.lblTotalProjects.Text = "Total Projects";
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TabControl1.Controls.Add(this.planning);
            this.guna2TabControl1.Controls.Add(this.inProgress);
            this.guna2TabControl1.Controls.Add(this.completed);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(18, 154);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(904, 417);
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
            // 
            // planning
            // 
            this.planning.Controls.Add(this.planningCardDisplay);
            this.planning.Location = new System.Drawing.Point(4, 44);
            this.planning.Name = "planning";
            this.planning.Padding = new System.Windows.Forms.Padding(3);
            this.planning.Size = new System.Drawing.Size(896, 369);
            this.planning.TabIndex = 0;
            this.planning.Text = "Planning";
            this.planning.UseVisualStyleBackColor = true;
            this.planning.Click += new System.EventHandler(this.planning_Click);
            // 
            // inProgress
            // 
            this.inProgress.Location = new System.Drawing.Point(4, 44);
            this.inProgress.Name = "inProgress";
            this.inProgress.Padding = new System.Windows.Forms.Padding(3);
            this.inProgress.Size = new System.Drawing.Size(896, 369);
            this.inProgress.TabIndex = 1;
            this.inProgress.Text = "In Progress";
            this.inProgress.UseVisualStyleBackColor = true;
            this.inProgress.Click += new System.EventHandler(this.inProgress_Click);
            // 
            // completed
            // 
            this.completed.Location = new System.Drawing.Point(4, 44);
            this.completed.Name = "completed";
            this.completed.Padding = new System.Windows.Forms.Padding(3);
            this.completed.Size = new System.Drawing.Size(896, 369);
            this.completed.TabIndex = 2;
            this.completed.Text = "Completed";
            this.completed.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 47;
            this.iconPictureBox2.Location = new System.Drawing.Point(656, 28);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(47, 47);
            this.iconPictureBox2.TabIndex = 4;
            this.iconPictureBox2.TabStop = false;
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
            // planningCardDisplay
            // 
            this.planningCardDisplay.AutoScroll = true;
            this.planningCardDisplay.BackColor = System.Drawing.Color.IndianRed;
            this.planningCardDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planningCardDisplay.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.planningCardDisplay.Location = new System.Drawing.Point(3, 3);
            this.planningCardDisplay.Name = "planningCardDisplay";
            this.planningCardDisplay.Size = new System.Drawing.Size(890, 363);
            this.planningCardDisplay.TabIndex = 0;
            this.planningCardDisplay.WrapContents = false;
            this.planningCardDisplay.Resize += new System.EventHandler(this.planningCardDisplay_Resize);
            // 
            // ProjectsReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "ProjectsReview";
            this.Size = new System.Drawing.Size(967, 626);
            this.mainContainer.ResumeLayout(false);
            this.headContainer.ResumeLayout(false);
            this.headContainer.PerformLayout();
            this.guna2TabControl1.ResumeLayout(false);
            this.planning.ResumeLayout(false);
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
    }
}
