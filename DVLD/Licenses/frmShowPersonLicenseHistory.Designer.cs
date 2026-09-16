namespace DVLD.Drivers
{
    partial class frmShowPersonLicenseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPersonLicenseHistory));
            ctrlClsPeopleWithFilter1 = new DVLD.People.UserControl.ctrlClsPeopleWithFilter();
            pictureBox1 = new PictureBox();
            ctrlDriverLicenses1 = new DVLD.Drivers.Controls.ctrlDriverLicenses();
            btnclose = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrlClsPeopleWithFilter1
            // 
            ctrlClsPeopleWithFilter1.FiltererEnabled = true;
            ctrlClsPeopleWithFilter1.Location = new Point(285, 61);
            ctrlClsPeopleWithFilter1.Name = "ctrlClsPeopleWithFilter1";
            ctrlClsPeopleWithFilter1.ShowAddPerson = true;
            ctrlClsPeopleWithFilter1.Size = new Size(1077, 558);
            ctrlClsPeopleWithFilter1.TabIndex = 0;
            ctrlClsPeopleWithFilter1.OnPersonSelected += ctrlClsPeopleWithFilter1_OnPersonSelected;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ctrlDriverLicenses1
            // 
            ctrlDriverLicenses1.Location = new Point(12, 623);
            ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
            ctrlDriverLicenses1.Size = new Size(1351, 325);
            ctrlDriverLicenses1.TabIndex = 2;
            // 
            // btnclose
            // 
            btnclose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose.ForeColor = SystemColors.ActiveCaption;
            btnclose.Image = (Image)resources.GetObject("btnclose.Image");
            btnclose.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose.Location = new Point(1250, 954);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(112, 34);
            btnclose.TabIndex = 9;
            btnclose.Text = "   Close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(488, 19);
            label1.Name = "label1";
            label1.Size = new Size(321, 54);
            label1.TabIndex = 10;
            label1.Text = " License History";
            // 
            // frmShowPersonLicenseHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 999);
            Controls.Add(label1);
            Controls.Add(btnclose);
            Controls.Add(ctrlDriverLicenses1);
            Controls.Add(pictureBox1);
            Controls.Add(ctrlClsPeopleWithFilter1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmShowPersonLicenseHistory";
            Text = "License History";
            Load += frmPersonLicenseHistory_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private People.UserControl.ctrlClsPeopleWithFilter ctrlClsPeopleWithFilter1;
        private PictureBox pictureBox1;
        private Controls.ctrlDriverLicenses ctrlDriverLicenses1;
        private Button btnclose;
        private Label label1;
    }
}