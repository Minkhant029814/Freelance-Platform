namespace Freelance_Platform.view.components.FreelancerComponent
{
    partial class AddPastWorksForm
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
            this.btnAddPastWorks = new Guna.UI2.WinForms.Guna2Button();
            this.txtProjectDes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprojectName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddPastWorks
            // 
            this.btnAddPastWorks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPastWorks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPastWorks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPastWorks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPastWorks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddPastWorks.ForeColor = System.Drawing.Color.White;
            this.btnAddPastWorks.Location = new System.Drawing.Point(560, 324);
            this.btnAddPastWorks.Name = "btnAddPastWorks";
            this.btnAddPastWorks.Size = new System.Drawing.Size(180, 45);
            this.btnAddPastWorks.TabIndex = 11;
            this.btnAddPastWorks.Text = "Add Past Works\r\n";
            this.btnAddPastWorks.Click += new System.EventHandler(this.btnAddPastWorks_Click);
            // 
            // txtProjectDes
            // 
            this.txtProjectDes.BorderRadius = 10;
            this.txtProjectDes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProjectDes.DefaultText = "";
            this.txtProjectDes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProjectDes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProjectDes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProjectDes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProjectDes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProjectDes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProjectDes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProjectDes.Location = new System.Drawing.Point(70, 324);
            this.txtProjectDes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProjectDes.Multiline = true;
            this.txtProjectDes.Name = "txtProjectDes";
            this.txtProjectDes.PlaceholderText = "Describe the project, Your role and the techniques you used";
            this.txtProjectDes.SelectedText = "";
            this.txtProjectDes.Size = new System.Drawing.Size(432, 76);
            this.txtProjectDes.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Projects Descriptions";
            // 
            // txtprojectName
            // 
            this.txtprojectName.BorderRadius = 10;
            this.txtprojectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprojectName.DefaultText = "";
            this.txtprojectName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprojectName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprojectName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprojectName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprojectName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprojectName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtprojectName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprojectName.Location = new System.Drawing.Point(70, 161);
            this.txtprojectName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtprojectName.Name = "txtprojectName";
            this.txtprojectName.PlaceholderText = "e.g. E-commerce Platform Redesign";
            this.txtprojectName.SelectedText = "";
            this.txtprojectName.Size = new System.Drawing.Size(345, 62);
            this.txtprojectName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Projects Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Featured Past Works/ Projects";
            // 
            // AddPastWorksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddPastWorks);
            this.Controls.Add(this.txtProjectDes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtprojectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPastWorksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPastWorksForm";
            this.Load += new System.EventHandler(this.AddPastWorksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAddPastWorks;
        private Guna.UI2.WinForms.Guna2TextBox txtProjectDes;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtprojectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}