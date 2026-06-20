namespace Freelance_Platform.view.components.FreelancerComponent
{
    partial class PastWorksCard
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.ForeColor = System.Drawing.Color.White;
            this.lblProjectTitle.Location = new System.Drawing.Point(41, 22);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(239, 38);
            this.lblProjectTitle.TabIndex = 0;
            this.lblProjectTitle.Text = "Project Title";
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(0, 94);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(667, 71);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // PastWorksCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(168)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProjectTitle);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PastWorksCard";
            this.Size = new System.Drawing.Size(667, 165);
            this.Load += new System.EventHandler(this.PastWorksCard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Label lblDescription;
    }
}
