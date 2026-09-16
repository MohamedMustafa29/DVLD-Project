namespace DVLD.Licenses.Detain_License
{
    partial class frmDetainLicense
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicense));
            label1 = new Label();
            ctrlDriverLicenseInfoControlwithFilter1 = new DVLD.Licenses.Controls.ctrlDriverLicenseInfoControlwithFilter();
            gbDetainInfo = new GroupBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtFineFees = new TextBox();
            lblCreatedByUser = new Label();
            lblLicenseID = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            lblDetainDate = new Label();
            label4 = new Label();
            lblDetainID = new Label();
            label2 = new Label();
            btnClose = new Button();
            btnDetain = new Button();
            errorProvider1 = new ErrorProvider(components);
            llShowNewLicenseInfo = new LinkLabel();
            llShowLicensesHistory = new LinkLabel();
            gbDetainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(530, 27);
            label1.Name = "label1";
            label1.Size = new Size(252, 45);
            label1.TabIndex = 0;
            label1.Text = "  Detain License";
            // 
            // ctrlDriverLicenseInfoControlwithFilter1
            // 
            ctrlDriverLicenseInfoControlwithFilter1.Location = new Point(-2, 75);
            ctrlDriverLicenseInfoControlwithFilter1.Name = "ctrlDriverLicenseInfoControlwithFilter1";
            ctrlDriverLicenseInfoControlwithFilter1.Size = new Size(1183, 652);
            ctrlDriverLicenseInfoControlwithFilter1.TabIndex = 1;
            ctrlDriverLicenseInfoControlwithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoControlwithFilter1_OnLicenseSelected;
            // 
            // gbDetainInfo
            // 
            gbDetainInfo.Controls.Add(pictureBox5);
            gbDetainInfo.Controls.Add(pictureBox4);
            gbDetainInfo.Controls.Add(pictureBox3);
            gbDetainInfo.Controls.Add(pictureBox2);
            gbDetainInfo.Controls.Add(pictureBox1);
            gbDetainInfo.Controls.Add(txtFineFees);
            gbDetainInfo.Controls.Add(lblCreatedByUser);
            gbDetainInfo.Controls.Add(lblLicenseID);
            gbDetainInfo.Controls.Add(label9);
            gbDetainInfo.Controls.Add(label8);
            gbDetainInfo.Controls.Add(label6);
            gbDetainInfo.Controls.Add(lblDetainDate);
            gbDetainInfo.Controls.Add(label4);
            gbDetainInfo.Controls.Add(lblDetainID);
            gbDetainInfo.Controls.Add(label2);
            gbDetainInfo.Location = new Point(-2, 733);
            gbDetainInfo.Name = "gbDetainInfo";
            gbDetainInfo.Size = new Size(1170, 204);
            gbDetainInfo.TabIndex = 2;
            gbDetainInfo.TabStop = false;
            gbDetainInfo.Text = "Detain Info";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(741, 103);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(154, 152);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(154, 103);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(741, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(154, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // txtFineFees
            // 
            txtFineFees.Location = new Point(210, 151);
            txtFineFees.Name = "txtFineFees";
            txtFineFees.Size = new Size(79, 31);
            txtFineFees.TabIndex = 10;
            txtFineFees.Validating += txtFineFees_Validating;
            // 
            // lblCreatedByUser
            // 
            lblCreatedByUser.AutoSize = true;
            lblCreatedByUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedByUser.Location = new Point(787, 103);
            lblCreatedByUser.Name = "lblCreatedByUser";
            lblCreatedByUser.Size = new Size(33, 30);
            lblCreatedByUser.TabIndex = 9;
            lblCreatedByUser.Text = "??";
            // 
            // lblLicenseID
            // 
            lblLicenseID.AutoSize = true;
            lblLicenseID.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicenseID.Location = new Point(787, 47);
            lblLicenseID.Name = "lblLicenseID";
            lblLicenseID.Size = new Size(33, 30);
            lblLicenseID.TabIndex = 8;
            lblLicenseID.Text = "??";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(575, 103);
            label9.Name = "label9";
            label9.Size = new Size(133, 30);
            label9.TabIndex = 7;
            label9.Text = "Created By:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(575, 47);
            label8.Name = "label8";
            label8.Size = new Size(123, 30);
            label8.TabIndex = 6;
            label8.Text = "License ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 151);
            label6.Name = "label6";
            label6.Size = new Size(112, 30);
            label6.TabIndex = 4;
            label6.Text = "Fine Fees:";
            // 
            // lblDetainDate
            // 
            lblDetainDate.AutoSize = true;
            lblDetainDate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetainDate.Location = new Point(210, 103);
            lblDetainDate.Name = "lblDetainDate";
            lblDetainDate.Size = new Size(33, 30);
            lblDetainDate.TabIndex = 3;
            lblDetainDate.Text = "??";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 103);
            label4.Name = "label4";
            label4.Size = new Size(142, 30);
            label4.TabIndex = 2;
            label4.Text = "Detain Date:";
            // 
            // lblDetainID
            // 
            lblDetainID.AutoSize = true;
            lblDetainID.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetainID.Location = new Point(210, 47);
            lblDetainID.Name = "lblDetainID";
            lblDetainID.Size = new Size(33, 30);
            lblDetainID.TabIndex = 1;
            lblDetainID.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 47);
            label2.Name = "label2";
            label2.Size = new Size(122, 30);
            label2.TabIndex = 0;
            label2.Text = "Detain ID: ";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(913, 939);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 11;
            btnClose.Text = "   Close ";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDetain
            // 
            btnDetain.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDetain.ForeColor = SystemColors.ActiveCaption;
            btnDetain.Image = (Image)resources.GetObject("btnDetain.Image");
            btnDetain.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetain.Location = new Point(1050, 939);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(112, 34);
            btnDetain.TabIndex = 12;
            btnDetain.Text = "      Detain ";
            btnDetain.UseVisualStyleBackColor = true;
            btnDetain.Click += btnDetain_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // llShowNewLicenseInfo
            // 
            llShowNewLicenseInfo.AutoSize = true;
            llShowNewLicenseInfo.Location = new Point(212, 951);
            llShowNewLicenseInfo.Name = "llShowNewLicenseInfo";
            llShowNewLicenseInfo.Size = new Size(202, 25);
            llShowNewLicenseInfo.TabIndex = 69;
            llShowNewLicenseInfo.TabStop = true;
            llShowNewLicenseInfo.Text = "Show New Licenses Info";
            llShowNewLicenseInfo.LinkClicked += llShowNewLicenseInfo_LinkClicked;
            // 
            // llShowLicensesHistory
            // 
            llShowLicensesHistory.AutoSize = true;
            llShowLicensesHistory.Location = new Point(12, 951);
            llShowLicensesHistory.Name = "llShowLicensesHistory";
            llShowLicensesHistory.Size = new Size(187, 25);
            llShowLicensesHistory.TabIndex = 68;
            llShowLicensesHistory.TabStop = true;
            llShowLicensesHistory.Text = "Show Licenses History";
            llShowLicensesHistory.LinkClicked += llShowLicensesHistory_LinkClicked;
            // 
            // frmDetainLicense
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 985);
            Controls.Add(llShowNewLicenseInfo);
            Controls.Add(llShowLicensesHistory);
            Controls.Add(btnDetain);
            Controls.Add(btnClose);
            Controls.Add(gbDetainInfo);
            Controls.Add(ctrlDriverLicenseInfoControlwithFilter1);
            Controls.Add(label1);
            Name = "frmDetainLicense";
            Text = "Detain License";
            Load += frmDetainLicense_Load;
            gbDetainInfo.ResumeLayout(false);
            gbDetainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Controls.ctrlDriverLicenseInfoControlwithFilter ctrlDriverLicenseInfoControlwithFilter1;
        private GroupBox gbDetainInfo;
        private Label lblCreatedByUser;
        private Label lblLicenseID;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label lblDetainDate;
        private Label label4;
        private Label lblDetainID;
        private Label label2;
        private TextBox txtFineFees;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnClose;
        private Button btnDetain;
        private PictureBox pictureBox5;
        private ErrorProvider errorProvider1;
        private LinkLabel llShowNewLicenseInfo;
        private LinkLabel llShowLicensesHistory;
    }
}