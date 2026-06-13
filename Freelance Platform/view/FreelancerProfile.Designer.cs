namespace Freelance_Platform.Forms
{
    partial class FreelancerProfile
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
            this.LeftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Rightpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.profilePict = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnUploadPhoto = new Guna.UI2.WinForms.Guna2Button();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numPayRate = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FormLayout = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBiogarphy = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtExternalLink = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.Rightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPayRate)).BeginInit();
            this.FormLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.LeftPanel.BorderThickness = 5;
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Controls.Add(this.label2);
            this.LeftPanel.Controls.Add(this.numPayRate);
            this.LeftPanel.Controls.Add(this.guna2ComboBox1);
            this.LeftPanel.Controls.Add(this.txtName);
            this.LeftPanel.Controls.Add(this.btnUploadPhoto);
            this.LeftPanel.Controls.Add(this.profilePict);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(356, 639);
            this.LeftPanel.TabIndex = 0;
            // 
            // Rightpanel
            // 
            this.Rightpanel.BackColor = System.Drawing.Color.White;
            this.Rightpanel.Controls.Add(this.FormLayout);
            this.Rightpanel.Controls.Add(this.label4);
            this.Rightpanel.Controls.Add(this.label1);
            this.Rightpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rightpanel.Location = new System.Drawing.Point(356, 0);
            this.Rightpanel.Name = "Rightpanel";
            this.Rightpanel.Size = new System.Drawing.Size(828, 639);
            this.Rightpanel.TabIndex = 1;
            // 
            // profilePict
            // 
            this.profilePict.ImageRotate = 0F;
            this.profilePict.Location = new System.Drawing.Point(84, 12);
            this.profilePict.Name = "profilePict";
            this.profilePict.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilePict.Size = new System.Drawing.Size(150, 150);
            this.profilePict.TabIndex = 0;
            this.profilePict.TabStop = false;
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.BorderRadius = 10;
            this.btnUploadPhoto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUploadPhoto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUploadPhoto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUploadPhoto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUploadPhoto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(168)))));
            this.btnUploadPhoto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUploadPhoto.ForeColor = System.Drawing.Color.White;
            this.btnUploadPhoto.Location = new System.Drawing.Point(60, 192);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(180, 45);
            this.btnUploadPhoto.TabIndex = 1;
            this.btnUploadPhoto.Text = "Upload Photo\r\n";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.BorderColor = System.Drawing.Color.Blue;
            this.txtName.BorderThickness = 0;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Blue;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(14, 246);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "";
            this.txtName.ReadOnly = true;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(242, 74);
            this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.Blue;
            this.guna2ComboBox1.BorderRadius = 10;
            this.guna2ComboBox1.BorderThickness = 2;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.Blue;
            this.guna2ComboBox1.ItemHeight = 45;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Full Stack Developer",
            "UI/UX Developer",
            "Backend Developer",
            "Frontend Developer",
            "Mobile Developer",
            "Data Scientist"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(14, 390);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(284, 51);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2ComboBox1.TabIndex = 4;
            // 
            // numPayRate
            // 
            this.numPayRate.BackColor = System.Drawing.Color.Transparent;
            this.numPayRate.BorderThickness = 0;
            this.numPayRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numPayRate.DecimalPlaces = 2;
            this.numPayRate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.numPayRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPayRate.Location = new System.Drawing.Point(84, 488);
            this.numPayRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPayRate.Name = "numPayRate";
            this.numPayRate.Size = new System.Drawing.Size(121, 48);
            this.numPayRate.TabIndex = 5;
            this.numPayRate.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.numPayRate.UpDownButtonForeColor = System.Drawing.Color.Blue;
            this.numPayRate.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "/hr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complete Your Profile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Manage your public freelancer identity and portfolio";
            // 
            // FormLayout
            // 
            this.FormLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormLayout.AutoScroll = true;
            this.FormLayout.BorderRadius = 15;
            this.FormLayout.Controls.Add(this.label10);
            this.FormLayout.Controls.Add(this.txtExternalLink);
            this.FormLayout.Controls.Add(this.txtEmail);
            this.FormLayout.Controls.Add(this.label9);
            this.FormLayout.Controls.Add(this.label8);
            this.FormLayout.Controls.Add(this.label7);
            this.FormLayout.Controls.Add(this.txtBiogarphy);
            this.FormLayout.Controls.Add(this.label6);
            this.FormLayout.Controls.Add(this.label5);
            this.FormLayout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.FormLayout.Location = new System.Drawing.Point(24, 109);
            this.FormLayout.Name = "FormLayout";
            this.FormLayout.Size = new System.Drawing.Size(765, 500);
            this.FormLayout.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Biography / About Me";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(504, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tell clients about your professional experience and core strengths.";
            // 
            // txtBiogarphy
            // 
            this.txtBiogarphy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBiogarphy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.txtBiogarphy.BorderRadius = 15;
            this.txtBiogarphy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBiogarphy.DefaultText = "";
            this.txtBiogarphy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBiogarphy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBiogarphy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBiogarphy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBiogarphy.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtBiogarphy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBiogarphy.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtBiogarphy.ForeColor = System.Drawing.Color.Blue;
            this.txtBiogarphy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBiogarphy.Location = new System.Drawing.Point(23, 109);
            this.txtBiogarphy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBiogarphy.Multiline = true;
            this.txtBiogarphy.Name = "txtBiogarphy";
            this.txtBiogarphy.PlaceholderText = "I am a passionate developer with 5+ years of experience building scalable\r\n web a" +
    "pplications..";
            this.txtBiogarphy.SelectedText = "";
            this.txtBiogarphy.Size = new System.Drawing.Size(722, 121);
            this.txtBiogarphy.TabIndex = 4;
            this.txtBiogarphy.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "Contact/Web link";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "Contact Email";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(463, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(290, 28);
            this.label9.TabIndex = 7;
            this.label9.Text = "External Links (GitHub/LinkedIn)";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(23, 358);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "alex@example.com";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(286, 60);
            this.txtEmail.TabIndex = 8;
            // 
            // txtExternalLink
            // 
            this.txtExternalLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExternalLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.txtExternalLink.BorderRadius = 10;
            this.txtExternalLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExternalLink.DefaultText = "";
            this.txtExternalLink.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtExternalLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtExternalLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExternalLink.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExternalLink.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExternalLink.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtExternalLink.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExternalLink.Location = new System.Drawing.Point(468, 358);
            this.txtExternalLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExternalLink.Name = "txtExternalLink";
            this.txtExternalLink.PlaceholderText = "https://github.com/alexdev";
            this.txtExternalLink.SelectedText = "";
            this.txtExternalLink.Size = new System.Drawing.Size(286, 60);
            this.txtExternalLink.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 442);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 28);
            this.label10.TabIndex = 10;
            this.label10.Text = "Technical Skill & Tech Stack\r\n";
            // 
            // FreelancerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 639);
            this.Controls.Add(this.Rightpanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "FreelancerProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FreelancerProfile";
            this.Load += new System.EventHandler(this.FreelancerProfile_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.Rightpanel.ResumeLayout(false);
            this.Rightpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPayRate)).EndInit();
            this.FormLayout.ResumeLayout(false);
            this.FormLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel LeftPanel;
        private Guna.UI2.WinForms.Guna2Panel Rightpanel;
        private Guna.UI2.WinForms.Guna2Button btnUploadPhoto;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePict;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numPayRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel FormLayout;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtBiogarphy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtExternalLink;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}