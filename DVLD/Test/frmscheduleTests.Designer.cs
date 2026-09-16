namespace DVLD.Applications.Test.Sechdule_Test
{
    partial class frmscheduleTests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmscheduleTests));
            ctrlLocalDrivingLicenseApplicationInfo1 = new DVLD.Applications.Manage_Application.ctrlLocalDrivingLicenseApplicationInfo();
            dgvTestAppointments = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            btnAddAppoint = new Button();
            label2 = new Label();
            lblNumber = new Label();
            button1 = new Button();
            lblTitle = new Label();
            pbTestTypeImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTestAppointments).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTestTypeImage).BeginInit();
            SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseApplicationInfo1
            // 
            ctrlLocalDrivingLicenseApplicationInfo1.Location = new Point(12, 178);
            ctrlLocalDrivingLicenseApplicationInfo1.Name = "ctrlLocalDrivingLicenseApplicationInfo1";
            ctrlLocalDrivingLicenseApplicationInfo1.Size = new Size(1237, 612);
            ctrlLocalDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // dgvTestAppointments
            // 
            dgvTestAppointments.AllowUserToAddRows = false;
            dgvTestAppointments.AllowUserToDeleteRows = false;
            dgvTestAppointments.BackgroundColor = SystemColors.ButtonFace;
            dgvTestAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTestAppointments.ContextMenuStrip = contextMenuStrip1;
            dgvTestAppointments.Location = new Point(19, 830);
            dgvTestAppointments.Name = "dgvTestAppointments";
            dgvTestAppointments.ReadOnly = true;
            dgvTestAppointments.RowHeadersWidth = 62;
            dgvTestAppointments.Size = new Size(1230, 148);
            dgvTestAppointments.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(249, 109);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripMenuItem1.ForeColor = SystemColors.ActiveCaption;
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(248, 36);
            toolStripMenuItem1.Text = "Edit";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click_1;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripMenuItem2.ForeColor = SystemColors.ActiveCaption;
            toolStripMenuItem2.Image = (Image)resources.GetObject("toolStripMenuItem2.Image");
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(248, 36);
            toolStripMenuItem2.Text = "Take Test";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // btnAddAppoint
            // 
            btnAddAppoint.Image = (Image)resources.GetObject("btnAddAppoint.Image");
            btnAddAppoint.Location = new Point(1184, 787);
            btnAddAppoint.Name = "btnAddAppoint";
            btnAddAppoint.Size = new Size(51, 37);
            btnAddAppoint.TabIndex = 5;
            btnAddAppoint.UseVisualStyleBackColor = true;
            btnAddAppoint.Click += btnAddAppoint_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 981);
            label2.Name = "label2";
            label2.Size = new Size(243, 25);
            label2.TabIndex = 6;
            label2.Text = "Number Of Appointments :";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(277, 981);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(28, 25);
            lblNumber.TabIndex = 7;
            lblNumber.Text = "??";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1130, 1004);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(404, 127);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(452, 48);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Vision Test Appointments";
            // 
            // pbTestTypeImage
            // 
            pbTestTypeImage.Image = (Image)resources.GetObject("pbTestTypeImage.Image");
            pbTestTypeImage.Location = new Point(553, 12);
            pbTestTypeImage.Name = "pbTestTypeImage";
            pbTestTypeImage.Size = new Size(150, 112);
            pbTestTypeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTestTypeImage.TabIndex = 2;
            pbTestTypeImage.TabStop = false;
            // 
            // frmscheduleTests
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1254, 1050);
            Controls.Add(button1);
            Controls.Add(lblNumber);
            Controls.Add(label2);
            Controls.Add(btnAddAppoint);
            Controls.Add(dgvTestAppointments);
            Controls.Add(pbTestTypeImage);
            Controls.Add(lblTitle);
            Controls.Add(ctrlLocalDrivingLicenseApplicationInfo1);
            Name = "frmscheduleTests";
            Text = "Sechudle Vision Test";
            Load += frmSechudleVisionTest_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTestAppointments).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbTestTypeImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Manage_Application.ctrlLocalDrivingLicenseApplicationInfo ctrlLocalDrivingLicenseApplicationInfo1;
        private DataGridView dgvTestAppointments;
        private Button btnAddAppoint;
        private Label label2;
        private Label lblNumber;
        private Button button1;
        private Label lblTitle;
        private PictureBox pbTestTypeImage;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}