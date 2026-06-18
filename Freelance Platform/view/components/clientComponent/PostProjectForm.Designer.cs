namespace Freelance_Platform.Forms
{
    partial class PostProjectForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnPostProject = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numBudget = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtimeEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtimeStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtProejctDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjectTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.lblGreeting);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 740);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.btnCancel);
            this.guna2Panel2.Controls.Add(this.btnPostProject);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.numBudget);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.dtimeEndDate);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.dtimeStartDate);
            this.guna2Panel2.Controls.Add(this.txtProejctDesc);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.txtProjectTitle);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.guna2Panel2.Location = new System.Drawing.Point(163, 104);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(600, 612);
            this.guna2Panel2.TabIndex = 5;
            this.guna2Panel2.UseTransparentBackground = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(42, 527);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPostProject
            // 
            this.btnPostProject.BorderRadius = 15;
            this.btnPostProject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPostProject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPostProject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPostProject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPostProject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPostProject.ForeColor = System.Drawing.Color.White;
            this.btnPostProject.Location = new System.Drawing.Point(369, 527);
            this.btnPostProject.Name = "btnPostProject";
            this.btnPostProject.Size = new System.Drawing.Size(180, 45);
            this.btnPostProject.TabIndex = 15;
            this.btnPostProject.Text = "Post Project";
            this.btnPostProject.Click += new System.EventHandler(this.btnPostProject_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Budget (USD)";
            // 
            // numBudget
            // 
            this.numBudget.BackColor = System.Drawing.Color.Transparent;
            this.numBudget.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numBudget.DecimalPlaces = 2;
            this.numBudget.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBudget.Location = new System.Drawing.Point(42, 441);
            this.numBudget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numBudget.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBudget.Name = "numBudget";
            this.numBudget.Size = new System.Drawing.Size(200, 48);
            this.numBudget.TabIndex = 13;
            this.numBudget.ValueChanged += new System.EventHandler(this.guna2NumericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "End Date";
            // 
            // dtimeEndDate
            // 
            this.dtimeEndDate.Checked = true;
            this.dtimeEndDate.FillColor = System.Drawing.Color.White;
            this.dtimeEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtimeEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtimeEndDate.Location = new System.Drawing.Point(349, 359);
            this.dtimeEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtimeEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtimeEndDate.Name = "dtimeEndDate";
            this.dtimeEndDate.Size = new System.Drawing.Size(225, 36);
            this.dtimeEndDate.TabIndex = 11;
            this.dtimeEndDate.Value = new System.DateTime(2026, 6, 11, 23, 54, 25, 506);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start Date";
            // 
            // dtimeStartDate
            // 
            this.dtimeStartDate.Checked = true;
            this.dtimeStartDate.FillColor = System.Drawing.Color.White;
            this.dtimeStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtimeStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtimeStartDate.Location = new System.Drawing.Point(42, 359);
            this.dtimeStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtimeStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtimeStartDate.Name = "dtimeStartDate";
            this.dtimeStartDate.Size = new System.Drawing.Size(220, 36);
            this.dtimeStartDate.TabIndex = 9;
            this.dtimeStartDate.Value = new System.DateTime(2026, 6, 11, 23, 54, 25, 506);
            // 
            // txtProejctDesc
            // 
            this.txtProejctDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProejctDesc.BorderRadius = 15;
            this.txtProejctDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProejctDesc.DefaultText = "";
            this.txtProejctDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProejctDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProejctDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProejctDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProejctDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProejctDesc.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtProejctDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProejctDesc.Location = new System.Drawing.Point(42, 172);
            this.txtProejctDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProejctDesc.Multiline = true;
            this.txtProejctDesc.Name = "txtProejctDesc";
            this.txtProejctDesc.PlaceholderText = "Describe the deliverables,  required skills, and \r\nany other relevant details\r\n";
            this.txtProejctDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProejctDesc.SelectedText = "";
            this.txtProejctDesc.Size = new System.Drawing.Size(507, 122);
            this.txtProejctDesc.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Project Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Project Title";
            // 
            // txtProjectTitle
            // 
            this.txtProjectTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectTitle.BorderRadius = 15;
            this.txtProjectTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProjectTitle.DefaultText = "";
            this.txtProjectTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProjectTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProjectTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProjectTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProjectTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProjectTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtProjectTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProjectTitle.Location = new System.Drawing.Point(42, 63);
            this.txtProjectTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProjectTitle.Name = "txtProjectTitle";
            this.txtProjectTitle.PlaceholderText = "e.g. C# Developer \r\n";
            this.txtProjectTitle.SelectedText = "";
            this.txtProjectTitle.Size = new System.Drawing.Size(515, 60);
            this.txtProjectTitle.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(506, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Provide details about your project to attract the right freelancers.";
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(27, 22);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(229, 29);
            this.lblGreeting.TabIndex = 3;
            this.lblGreeting.Text = "Post a new project";
            // 
            // PostProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 740);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PostProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PostProjectForm";
            this.Load += new System.EventHandler(this.PostProjectForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBudget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtProjectTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGreeting;
        private Guna.UI2.WinForms.Guna2TextBox txtProejctDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtimeEndDate;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtimeStartDate;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2NumericUpDown numBudget;
        private Guna.UI2.WinForms.Guna2Button btnPostProject;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}