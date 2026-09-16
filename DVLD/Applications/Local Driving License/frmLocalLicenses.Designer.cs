namespace DVLD.Applications.Manage_Application
{
    partial class frmLocalLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalLicenses));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            dgvAddLocalLincense = new DataGridView();
            label2 = new Label();
            lblNumbers = new Label();
            btnAddLicense = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetaToolStripMenuItem = new ToolStripMenuItem();
            editApplicationToolStripMenuItem = new ToolStripMenuItem();
            deleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            canslToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ScheduleTestsMenue = new ToolStripMenuItem();
            scheduleVisionTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleWrittenTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleStreetTestToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            issueDrivingLicenseFirstTimeToolStripMenuItem = new ToolStripMenuItem();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            showPersonToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            cbFilter = new ComboBox();
            txtFilter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddLocalLincense).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(491, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(800, 181);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(400, 249);
            label1.Name = "label1";
            label1.Size = new Size(567, 48);
            label1.TabIndex = 2;
            label1.Text = "Local Driving license Application";
            // 
            // dgvAddLocalLincense
            // 
            dgvAddLocalLincense.AllowUserToAddRows = false;
            dgvAddLocalLincense.AllowUserToDeleteRows = false;
            dgvAddLocalLincense.BackgroundColor = SystemColors.ButtonHighlight;
            dgvAddLocalLincense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddLocalLincense.GridColor = Color.Gray;
            dgvAddLocalLincense.Location = new Point(34, 357);
            dgvAddLocalLincense.Name = "dgvAddLocalLincense";
            dgvAddLocalLincense.ReadOnly = true;
            dgvAddLocalLincense.RowHeadersWidth = 62;
            dgvAddLocalLincense.Size = new Size(1348, 294);
            dgvAddLocalLincense.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 654);
            label2.Name = "label2";
            label2.Size = new Size(135, 38);
            label2.TabIndex = 4;
            label2.Text = "Records :";
            // 
            // lblNumbers
            // 
            lblNumbers.AutoSize = true;
            lblNumbers.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumbers.Location = new Point(163, 654);
            lblNumbers.Name = "lblNumbers";
            lblNumbers.Size = new Size(41, 38);
            lblNumbers.TabIndex = 5;
            lblNumbers.Text = "??";
            // 
            // btnAddLicense
            // 
            btnAddLicense.Image = (Image)resources.GetObject("btnAddLicense.Image");
            btnAddLicense.Location = new Point(1268, 226);
            btnAddLicense.Name = "btnAddLicense";
            btnAddLicense.Size = new Size(95, 71);
            btnAddLicense.TabIndex = 6;
            btnAddLicense.UseVisualStyleBackColor = true;
            btnAddLicense.Click += btnAddLicense_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStrip1.ImageScalingSize = new Size(50, 50);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetaToolStripMenuItem, editApplicationToolStripMenuItem, deleteApplicationToolStripMenuItem, canslToolStripMenuItem, toolStripSeparator1, ScheduleTestsMenue, toolStripSeparator2, issueDrivingLicenseFirstTimeToolStripMenuItem, showLicenseToolStripMenuItem, showPersonToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(474, 480);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // showDetaToolStripMenuItem
            // 
            showDetaToolStripMenuItem.Image = (Image)resources.GetObject("showDetaToolStripMenuItem.Image");
            showDetaToolStripMenuItem.Name = "showDetaToolStripMenuItem";
            showDetaToolStripMenuItem.Size = new Size(473, 58);
            showDetaToolStripMenuItem.Text = "Show Application Details";
            showDetaToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            showDetaToolStripMenuItem.Click += showDetaToolStripMenuItem_Click;
            // 
            // editApplicationToolStripMenuItem
            // 
            editApplicationToolStripMenuItem.Image = (Image)resources.GetObject("editApplicationToolStripMenuItem.Image");
            editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            editApplicationToolStripMenuItem.Size = new Size(473, 58);
            editApplicationToolStripMenuItem.Text = "Edit Application ";
            editApplicationToolStripMenuItem.Click += editApplicationToolStripMenuItem_Click;
            // 
            // deleteApplicationToolStripMenuItem
            // 
            deleteApplicationToolStripMenuItem.Image = (Image)resources.GetObject("deleteApplicationToolStripMenuItem.Image");
            deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            deleteApplicationToolStripMenuItem.Size = new Size(473, 58);
            deleteApplicationToolStripMenuItem.Text = "Delete Application";
            deleteApplicationToolStripMenuItem.Click += deleteApplicationToolStripMenuItem_Click;
            // 
            // canslToolStripMenuItem
            // 
            canslToolStripMenuItem.Image = (Image)resources.GetObject("canslToolStripMenuItem.Image");
            canslToolStripMenuItem.Name = "canslToolStripMenuItem";
            canslToolStripMenuItem.Size = new Size(473, 58);
            canslToolStripMenuItem.Text = "Cancel Application";
            canslToolStripMenuItem.Click += canslToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(470, 6);
            // 
            // ScheduleTestsMenue
            // 
            ScheduleTestsMenue.DropDownItems.AddRange(new ToolStripItem[] { scheduleVisionTestToolStripMenuItem, scheduleWrittenTestToolStripMenuItem, scheduleStreetTestToolStripMenuItem });
            ScheduleTestsMenue.Image = (Image)resources.GetObject("ScheduleTestsMenue.Image");
            ScheduleTestsMenue.Name = "ScheduleTestsMenue";
            ScheduleTestsMenue.Size = new Size(473, 58);
            ScheduleTestsMenue.Text = "schedule Test";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            scheduleVisionTestToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            scheduleVisionTestToolStripMenuItem.ForeColor = Color.Cyan;
            scheduleVisionTestToolStripMenuItem.Image = (Image)resources.GetObject("scheduleVisionTestToolStripMenuItem.Image");
            scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            scheduleVisionTestToolStripMenuItem.Size = new Size(341, 60);
            scheduleVisionTestToolStripMenuItem.Text = "schedule Vision Test";
            scheduleVisionTestToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            scheduleVisionTestToolStripMenuItem.Click += scheduleVisionTestToolStripMenuItem_Click;
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            scheduleWrittenTestToolStripMenuItem.Enabled = false;
            scheduleWrittenTestToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            scheduleWrittenTestToolStripMenuItem.Image = (Image)resources.GetObject("scheduleWrittenTestToolStripMenuItem.Image");
            scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            scheduleWrittenTestToolStripMenuItem.Size = new Size(341, 60);
            scheduleWrittenTestToolStripMenuItem.Text = "Sechudule Wirtten Test";
            scheduleWrittenTestToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            scheduleWrittenTestToolStripMenuItem.Click += scheduleWrittenTestToolStripMenuItem_Click;
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            scheduleStreetTestToolStripMenuItem.Enabled = false;
            scheduleStreetTestToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            scheduleStreetTestToolStripMenuItem.Image = (Image)resources.GetObject("scheduleStreetTestToolStripMenuItem.Image");
            scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            scheduleStreetTestToolStripMenuItem.Size = new Size(341, 60);
            scheduleStreetTestToolStripMenuItem.Text = "Sechdule Street Test";
            scheduleStreetTestToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            scheduleStreetTestToolStripMenuItem.Click += scheduleStreetTestToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(470, 6);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Checked = true;
            issueDrivingLicenseFirstTimeToolStripMenuItem.CheckState = CheckState.Checked;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Image = (Image)resources.GetObject("issueDrivingLicenseFirstTimeToolStripMenuItem.Image");
            issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new Size(473, 58);
            issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue License for the First Time";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Click += issueLicenseForTheFirstTimeToolStripMenuItem_Click;
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.Image = (Image)resources.GetObject("showLicenseToolStripMenuItem.Image");
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(473, 58);
            showLicenseToolStripMenuItem.Text = "Show Driver License Info ";
            showLicenseToolStripMenuItem.Click += showDriverLicenseInfoToolStripMenuItem_Click;
            // 
            // showPersonToolStripMenuItem
            // 
            showPersonToolStripMenuItem.Image = (Image)resources.GetObject("showPersonToolStripMenuItem.Image");
            showPersonToolStripMenuItem.Name = "showPersonToolStripMenuItem";
            showPersonToolStripMenuItem.Size = new Size(473, 58);
            showPersonToolStripMenuItem.Text = "Show Person Licenses History";
            showPersonToolStripMenuItem.Click += showPersonToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 324);
            label3.Name = "label3";
            label3.Size = new Size(110, 30);
            label3.TabIndex = 7;
            label3.Text = "Filter By :";
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "L.D.L.AppID", "National No.", "FullName", "Status", "" });
            cbFilter.Location = new Point(150, 321);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(182, 33);
            cbFilter.TabIndex = 8;
            cbFilter.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(338, 323);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(211, 31);
            txtFilter.TabIndex = 9;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // frmLocalLicenses
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 699);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(txtFilter);
            Controls.Add(cbFilter);
            Controls.Add(label3);
            Controls.Add(btnAddLicense);
            Controls.Add(lblNumbers);
            Controls.Add(label2);
            Controls.Add(dgvAddLocalLincense);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "frmLocalLicenses";
            Text = "Local Licenses List";
            Load += frmLocalLicenses_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddLocalLincense).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private DataGridView dgvAddLocalLincense;
        private Label label2;
        private Label lblNumbers;
        private Button btnAddLicense;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showDetaToolStripMenuItem;
        private ToolStripMenuItem editApplicationToolStripMenuItem;
        private ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private ToolStripMenuItem canslToolStripMenuItem;
        private ToolStripMenuItem ScheduleTestsMenue;
        private ToolStripMenuItem showPersonToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private Label label3;
        private ComboBox cbFilter;
        private TextBox txtFilter;
        private ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
    }
}