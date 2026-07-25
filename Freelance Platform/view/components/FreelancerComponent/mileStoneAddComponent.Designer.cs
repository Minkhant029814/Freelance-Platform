namespace Freelance_Platform.view.components.FreelancerComponent
{
    partial class mileStoneAddComponent
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
            this.mileStoneCard = new Guna.UI2.WinForms.Guna2Panel();
            this.rtxtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDeleteMileStone = new FontAwesome.Sharp.IconButton();
            this.numericMileStoneWeight = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtMileStoneTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.mainContainer.SuspendLayout();
            this.mileStoneCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMileStoneWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.BorderRadius = 15;
            this.mainContainer.Controls.Add(this.mileStoneCard);
            this.mainContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.mainContainer.Location = new System.Drawing.Point(18, 25);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(659, 283);
            this.mainContainer.TabIndex = 0;
            this.mainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContainer_Paint);
            // 
            // mileStoneCard
            // 
            this.mileStoneCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mileStoneCard.Controls.Add(this.rtxtDescription);
            this.mileStoneCard.Controls.Add(this.btnDeleteMileStone);
            this.mileStoneCard.Controls.Add(this.numericMileStoneWeight);
            this.mileStoneCard.Controls.Add(this.txtMileStoneTitle);
            this.mileStoneCard.Location = new System.Drawing.Point(18, 35);
            this.mileStoneCard.Name = "mileStoneCard";
            this.mileStoneCard.Size = new System.Drawing.Size(622, 231);
            this.mileStoneCard.TabIndex = 1;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtxtDescription.DefaultText = "";
            this.rtxtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rtxtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rtxtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rtxtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rtxtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtxtDescription.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.rtxtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtxtDescription.Location = new System.Drawing.Point(7, 103);
            this.rtxtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtDescription.Multiline = true;
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.PlaceholderText = "MileStone Description..........";
            this.rtxtDescription.SelectedText = "";
            this.rtxtDescription.Size = new System.Drawing.Size(589, 112);
            this.rtxtDescription.TabIndex = 3;
            // 
            // btnDeleteMileStone
            // 
            this.btnDeleteMileStone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMileStone.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDeleteMileStone.IconColor = System.Drawing.Color.Red;
            this.btnDeleteMileStone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteMileStone.Location = new System.Drawing.Point(549, 23);
            this.btnDeleteMileStone.Name = "btnDeleteMileStone";
            this.btnDeleteMileStone.Size = new System.Drawing.Size(47, 60);
            this.btnDeleteMileStone.TabIndex = 2;
            this.btnDeleteMileStone.UseVisualStyleBackColor = true;
            this.btnDeleteMileStone.Click += new System.EventHandler(this.btnDeleteMileStone_Click);
            // 
            // numericMileStoneWeight
            // 
            this.numericMileStoneWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericMileStoneWeight.BackColor = System.Drawing.Color.Transparent;
            this.numericMileStoneWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericMileStoneWeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericMileStoneWeight.Location = new System.Drawing.Point(262, 36);
            this.numericMileStoneWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericMileStoneWeight.Name = "numericMileStoneWeight";
            this.numericMileStoneWeight.Size = new System.Drawing.Size(175, 48);
            this.numericMileStoneWeight.TabIndex = 1;
            this.numericMileStoneWeight.ValueChanged += new System.EventHandler(this.numericMileStoneWeight_ValueChanged);
            // 
            // txtMileStoneTitle
            // 
            this.txtMileStoneTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMileStoneTitle.DefaultText = "";
            this.txtMileStoneTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMileStoneTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMileStoneTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMileStoneTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMileStoneTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMileStoneTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMileStoneTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMileStoneTitle.Location = new System.Drawing.Point(7, 36);
            this.txtMileStoneTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMileStoneTitle.Name = "txtMileStoneTitle";
            this.txtMileStoneTitle.PlaceholderText = "MileStone Title";
            this.txtMileStoneTitle.SelectedText = "";
            this.txtMileStoneTitle.Size = new System.Drawing.Size(236, 47);
            this.txtMileStoneTitle.TabIndex = 0;
            // 
            // mileStoneAddComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "mileStoneAddComponent";
            this.Size = new System.Drawing.Size(694, 329);
            this.Load += new System.EventHandler(this.mileStoneAddComponent_Load);
            this.mainContainer.ResumeLayout(false);
            this.mileStoneCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericMileStoneWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private Guna.UI2.WinForms.Guna2Panel mileStoneCard;
        private FontAwesome.Sharp.IconButton btnDeleteMileStone;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericMileStoneWeight;
        private Guna.UI2.WinForms.Guna2TextBox txtMileStoneTitle;
        private Guna.UI2.WinForms.Guna2TextBox rtxtDescription;
    }
}
