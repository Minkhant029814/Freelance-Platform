namespace Freelance_Platform.components
{
    partial class ProjectCardRow
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
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.lblProjectDesc = new System.Windows.Forms.Label();
            this.lblProjectBudget = new System.Windows.Forms.Label();
            this.lblProjectDate = new System.Windows.Forms.Label();
            this.lblProjectStatus = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProjectTitle.Location = new System.Drawing.Point(45, 21);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(127, 25);
            this.lblProjectTitle.TabIndex = 0;
            this.lblProjectTitle.Text = "Project Title";
            // 
            // lblProjectDesc
            // 
            this.lblProjectDesc.AutoSize = true;
            this.lblProjectDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProjectDesc.Location = new System.Drawing.Point(47, 57);
            this.lblProjectDesc.Name = "lblProjectDesc";
            this.lblProjectDesc.Size = new System.Drawing.Size(153, 20);
            this.lblProjectDesc.TabIndex = 1;
            this.lblProjectDesc.Text = "Project Description";
            // 
            // lblProjectBudget
            // 
            this.lblProjectBudget.AutoSize = true;
            this.lblProjectBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectBudget.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProjectBudget.Location = new System.Drawing.Point(64, 93);
            this.lblProjectBudget.Name = "lblProjectBudget";
            this.lblProjectBudget.Size = new System.Drawing.Size(120, 20);
            this.lblProjectBudget.TabIndex = 2;
            this.lblProjectBudget.Text = "Project Budget\r\n";
            // 
            // lblProjectDate
            // 
            this.lblProjectDate.AutoSize = true;
            this.lblProjectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProjectDate.Location = new System.Drawing.Point(283, 93);
            this.lblProjectDate.Name = "lblProjectDate";
            this.lblProjectDate.Size = new System.Drawing.Size(103, 20);
            this.lblProjectDate.TabIndex = 3;
            this.lblProjectDate.Text = "Project Date\r\n";
            // 
            // lblProjectStatus
            // 
            this.lblProjectStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjectStatus.AutoSize = true;
            this.lblProjectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProjectStatus.Location = new System.Drawing.Point(543, 26);
            this.lblProjectStatus.Name = "lblProjectStatus";
            this.lblProjectStatus.Size = new System.Drawing.Size(115, 20);
            this.lblProjectStatus.TabIndex = 4;
            this.lblProjectStatus.Text = "Project Status";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(168)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(245, 93);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(168)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Suitcase;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(26, 93);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 6;
            this.iconPictureBox2.TabStop = false;
            // 
            // ProjectCardRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(168)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.lblProjectStatus);
            this.Controls.Add(this.lblProjectDate);
            this.Controls.Add(this.lblProjectBudget);
            this.Controls.Add(this.lblProjectDesc);
            this.Controls.Add(this.lblProjectTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Name = "ProjectCardRow";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(696, 145);
            this.Load += new System.EventHandler(this.ProjectCardRow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Label lblProjectDesc;
        private System.Windows.Forms.Label lblProjectBudget;
        private System.Windows.Forms.Label lblProjectDate;
        private System.Windows.Forms.Label lblProjectStatus;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}
