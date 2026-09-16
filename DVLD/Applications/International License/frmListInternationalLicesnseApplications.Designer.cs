namespace DVLD.Applications.International_License
{
    partial class frmListInternationalLicesnseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListInternationalLicesnseApplications));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            btnNewApplication = new Button();
            btnClose = new Button();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            pbPersonImage = new PictureBox();
            PesonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            cmsApplications = new ContextMenuStrip(components);
            lblTitle = new Label();
            dgvInternationalLicenses = new DataGridView();
            lblInternationalLicensesRecords = new Label();
            label5 = new Label();
            cbIsReleased = new ComboBox();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            cmsApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(669, 81);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 141;
            pictureBox1.TabStop = false;
            // 
            // btnNewApplication
            // 
            btnNewApplication.FlatStyle = FlatStyle.Flat;
            btnNewApplication.Image = (Image)resources.GetObject("btnNewApplication.Image");
            btnNewApplication.Location = new Point(1038, 243);
            btnNewApplication.Name = "btnNewApplication";
            btnNewApplication.Size = new Size(88, 75);
            btnNewApplication.TabIndex = 140;
            btnNewApplication.UseVisualStyleBackColor = true;
            btnNewApplication.Click += btnNewApplication_Click;
            // 
            // btnClose
            // 
            btnClose.AutoEllipsis = true;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(991, 674);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 36);
            btnClose.TabIndex = 131;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(309, 32);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonImage.Image = (Image)resources.GetObject("pbPersonImage.Image");
            pbPersonImage.InitialImage = null;
            pbPersonImage.Location = new Point(493, 14);
            pbPersonImage.Margin = new Padding(4, 5, 4, 5);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(220, 189);
            pbPersonImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPersonImage.TabIndex = 139;
            pbPersonImage.TabStop = false;
            // 
            // PesonDetailsToolStripMenuItem
            // 
            PesonDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            PesonDetailsToolStripMenuItem.Name = "PesonDetailsToolStripMenuItem";
            PesonDetailsToolStripMenuItem.Size = new Size(309, 32);
            PesonDetailsToolStripMenuItem.Text = "Show Person Details";
            PesonDetailsToolStripMenuItem.Click += PesonDetailsToolStripMenuItem_Click;
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(309, 32);
            showDetailsToolStripMenuItem.Text = "&Show License Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // cmsApplications
            // 
            cmsApplications.ImageScalingSize = new Size(24, 24);
            cmsApplications.Items.AddRange(new ToolStripItem[] { PesonDetailsToolStripMenuItem, showDetailsToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem });
            cmsApplications.Name = "contextMenuStrip1";
            cmsApplications.Size = new Size(310, 100);
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(281, 208);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(568, 51);
            lblTitle.TabIndex = 135;
            lblTitle.Text = "International License Applications";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvInternationalLicenses
            // 
            dgvInternationalLicenses.AllowUserToAddRows = false;
            dgvInternationalLicenses.AllowUserToDeleteRows = false;
            dgvInternationalLicenses.AllowUserToResizeRows = false;
            dgvInternationalLicenses.BackgroundColor = Color.White;
            dgvInternationalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternationalLicenses.ContextMenuStrip = cmsApplications;
            dgvInternationalLicenses.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvInternationalLicenses.Location = new Point(24, 326);
            dgvInternationalLicenses.Margin = new Padding(4, 5, 4, 5);
            dgvInternationalLicenses.MultiSelect = false;
            dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            dgvInternationalLicenses.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInternationalLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInternationalLicenses.RowHeadersWidth = 62;
            dgvInternationalLicenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInternationalLicenses.Size = new Size(1102, 340);
            dgvInternationalLicenses.TabIndex = 145;
            dgvInternationalLicenses.TabStop = false;
            // 
            // lblInternationalLicensesRecords
            // 
            lblInternationalLicensesRecords.AutoSize = true;
            lblInternationalLicensesRecords.Location = new Point(169, 678);
            lblInternationalLicensesRecords.Name = "lblInternationalLicensesRecords";
            lblInternationalLicensesRecords.Size = new Size(37, 29);
            lblInternationalLicensesRecords.TabIndex = 147;
            lblInternationalLicensesRecords.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 675);
            label5.Name = "label5";
            label5.Size = new Size(139, 29);
            label5.TabIndex = 146;
            label5.Text = "# Records:";
            // 
            // cbIsReleased
            // 
            cbIsReleased.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsReleased.FormattingEnabled = true;
            cbIsReleased.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsReleased.Location = new Point(320, 290);
            cbIsReleased.Name = "cbIsReleased";
            cbIsReleased.Size = new Size(121, 37);
            cbIsReleased.TabIndex = 163;
            cbIsReleased.Visible = false;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "International License ID", "Application ID", "Driver ID", "Local License ID", "Is Active" });
            cbFilterBy.Location = new Point(104, 290);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(210, 37);
            cbFilterBy.TabIndex = 162;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Location = new Point(321, 290);
            txtFilterValue.Margin = new Padding(4, 5, 4, 5);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(256, 35);
            txtFilterValue.TabIndex = 161;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 293);
            label1.Name = "label1";
            label1.Size = new Size(117, 29);
            label1.TabIndex = 160;
            label1.Text = "Filter By:";
            // 
            // frmListInternationalLicesnseApplications
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(1139, 720);
            Controls.Add(cbIsReleased);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(label1);
            Controls.Add(lblInternationalLicensesRecords);
            Controls.Add(label5);
            Controls.Add(dgvInternationalLicenses);
            Controls.Add(pictureBox1);
            Controls.Add(btnNewApplication);
            Controls.Add(btnClose);
            Controls.Add(pbPersonImage);
            Controls.Add(lblTitle);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmListInternationalLicesnseApplications";
            StartPosition = FormStartPosition.CenterParent;
            Text = "List International Licesnse Applications";
            Load += frmListInternationalLicesnseApplications_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            cmsApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNewApplication;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.ToolStripMenuItem PesonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.Label lblInternationalLicensesRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbIsReleased;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
    }
}