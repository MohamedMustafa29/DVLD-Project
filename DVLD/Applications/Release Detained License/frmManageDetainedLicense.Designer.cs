namespace DVLD.Applications.Release_Detained_License
{
    partial class frmManageDetainedLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDetainedLicense));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvDetainedLicenses = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            txtChangeNameFilter = new TextBox();
            cbFilter = new ComboBox();
            label = new Label();
            btnRelease = new Button();
            btnDetained = new Button();
            lblTotalRecords = new Label();
            label2 = new Label();
            btnClose = new Button();
            cbIsReleased = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetainedLicenses).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(459, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(354, 225);
            label1.Name = "label1";
            label1.Size = new Size(528, 54);
            label1.TabIndex = 1;
            label1.Text = "  Manage Detained License";
            // 
            // dgvDetainedLicenses
            // 
            dgvDetainedLicenses.AllowUserToAddRows = false;
            dgvDetainedLicenses.AllowUserToDeleteRows = false;
            dgvDetainedLicenses.BackgroundColor = SystemColors.ButtonFace;
            dgvDetainedLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetainedLicenses.ContextMenuStrip = contextMenuStrip1;
            dgvDetainedLicenses.Location = new Point(12, 403);
            dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            dgvDetainedLicenses.ReadOnly = true;
            dgvDetainedLicenses.RowHeadersWidth = 62;
            dgvDetainedLicenses.Size = new Size(1198, 396);
            dgvDetainedLicenses.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem, releaseDetainedLicenseToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(390, 148);
            contextMenuStrip1.Opening += cmsApplications_Opening;
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            showPersonDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showPersonDetailsToolStripMenuItem.Image");
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(389, 36);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            showLicenseDetailsToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            showLicenseDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showLicenseDetailsToolStripMenuItem.Image");
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(389, 36);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailsToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            showPersonLicenseHistoryToolStripMenuItem.Image = (Image)resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image");
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(389, 36);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            releaseDetainedLicenseToolStripMenuItem.Image = (Image)resources.GetObject("releaseDetainedLicenseToolStripMenuItem.Image");
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(389, 36);
            releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            releaseDetainedLicenseToolStripMenuItem.Click += releaseDetainedLicenseToolStripMenuItem_Click;
            // 
            // txtChangeNameFilter
            // 
            txtChangeNameFilter.Location = new Point(369, 361);
            txtChangeNameFilter.Name = "txtChangeNameFilter";
            txtChangeNameFilter.Size = new Size(288, 31);
            txtChangeNameFilter.TabIndex = 11;
            txtChangeNameFilter.TextChanged += txtChangeNameFilter_TextChanged;
            // 
            // cbFilter
            // 
            cbFilter.AccessibleRole = AccessibleRole.None;
            cbFilter.Cursor = Cursors.PanNW;
            cbFilter.DisplayMember = "None";
            cbFilter.FlatStyle = FlatStyle.Popup;
            cbFilter.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "Detain ID", "Is Released", "National No", "Full Name", "Release Application ID" });
            cbFilter.Location = new Point(157, 354);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(182, 38);
            cbFilter.TabIndex = 10;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(22, 354);
            label.Name = "label";
            label.Size = new Size(119, 26);
            label.TabIndex = 9;
            label.Text = "Filter By";
            // 
            // btnRelease
            // 
            btnRelease.Image = (Image)resources.GetObject("btnRelease.Image");
            btnRelease.Location = new Point(1018, 306);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(87, 74);
            btnRelease.TabIndex = 12;
            btnRelease.UseVisualStyleBackColor = true;
            btnRelease.Click += btnRelease_Click;
            // 
            // btnDetained
            // 
            btnDetained.Image = (Image)resources.GetObject("btnDetained.Image");
            btnDetained.Location = new Point(1123, 306);
            btnDetained.Name = "btnDetained";
            btnDetained.Size = new Size(87, 74);
            btnDetained.TabIndex = 13;
            btnDetained.UseVisualStyleBackColor = true;
            btnDetained.Click += btnDetained_Click;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Font = new Font("Showcard Gothic", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalRecords.Location = new Point(408, 815);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(26, 28);
            lblTotalRecords.TabIndex = 15;
            lblTotalRecords.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 815);
            label2.Name = "label2";
            label2.Size = new Size(368, 28);
            label2.TabIndex = 14;
            label2.Text = "Number Of Detained License :";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1018, 809);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(193, 34);
            btnClose.TabIndex = 72;
            btnClose.Text = "   Close ";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cbIsReleased
            // 
            cbIsReleased.FormattingEnabled = true;
            cbIsReleased.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsReleased.Location = new Point(369, 358);
            cbIsReleased.Name = "cbIsReleased";
            cbIsReleased.Size = new Size(182, 33);
            cbIsReleased.TabIndex = 73;
            cbIsReleased.SelectedIndexChanged += cbIsReleased_SelectedIndexChanged_1;
            // 
            // frmManageDetainedLicense
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 883);
            Controls.Add(cbIsReleased);
            Controls.Add(btnClose);
            Controls.Add(lblTotalRecords);
            Controls.Add(label2);
            Controls.Add(btnDetained);
            Controls.Add(btnRelease);
            Controls.Add(txtChangeNameFilter);
            Controls.Add(cbFilter);
            Controls.Add(label);
            Controls.Add(dgvDetainedLicenses);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmManageDetainedLicense";
            Text = "Manage Detained License ";
            Load += frmManageDetainedLicense_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetainedLicenses).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvDetainedLicenses;
        private TextBox txtChangeNameFilter;
        private ComboBox cbFilter;
        private Label label;
        private Button btnRelease;
        private Button btnDetained;
        private Label lblTotalRecords;
        private Label label2;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private ComboBox cbIsReleased;
    }
}