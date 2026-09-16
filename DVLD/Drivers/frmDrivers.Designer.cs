namespace DVLD.Drivers
{
    partial class frmDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrivers));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvDriversList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            showToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            cbFilter = new ComboBox();
            txtChangeNameFilter = new TextBox();
            lblNumberOfDrivers = new Label();
            btnclose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDriversList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(498, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(498, 203);
            label1.Name = "label1";
            label1.Size = new Size(285, 48);
            label1.TabIndex = 1;
            label1.Text = "Manage Drivers";
            // 
            // dgvDriversList
            // 
            dgvDriversList.AllowUserToAddRows = false;
            dgvDriversList.AllowUserToDeleteRows = false;
            dgvDriversList.BackgroundColor = SystemColors.ButtonFace;
            dgvDriversList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDriversList.ContextMenuStrip = contextMenuStrip1;
            dgvDriversList.Location = new Point(12, 310);
            dgvDriversList.Name = "dgvDriversList";
            dgvDriversList.RowHeadersWidth = 62;
            dgvDriversList.Size = new Size(1269, 329);
            dgvDriversList.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, showToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(363, 68);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(362, 32);
            toolStripMenuItem1.Text = "Show Details";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            showToolStripMenuItem.Image = (Image)resources.GetObject("showToolStripMenuItem.Image");
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(362, 32);
            showToolStripMenuItem.Text = "Person License History";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 654);
            label2.Name = "label2";
            label2.Size = new Size(245, 32);
            label2.TabIndex = 3;
            label2.Text = "Number Of Drivers :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 273);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 4;
            label3.Text = "Filter By : ";
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "Driver ID", "Person No", "National No", "Full Name" });
            cbFilter.Location = new Point(133, 270);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(182, 33);
            cbFilter.TabIndex = 5;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // txtChangeNameFilter
            // 
            txtChangeNameFilter.Location = new Point(332, 273);
            txtChangeNameFilter.Name = "txtChangeNameFilter";
            txtChangeNameFilter.Size = new Size(251, 31);
            txtChangeNameFilter.TabIndex = 6;
            txtChangeNameFilter.TextChanged += txtChangeNameFilter_TextChanged;
            // 
            // lblNumberOfDrivers
            // 
            lblNumberOfDrivers.AutoSize = true;
            lblNumberOfDrivers.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberOfDrivers.Location = new Point(263, 656);
            lblNumberOfDrivers.Name = "lblNumberOfDrivers";
            lblNumberOfDrivers.Size = new Size(52, 30);
            lblNumberOfDrivers.TabIndex = 7;
            lblNumberOfDrivers.Text = "###";
            // 
            // btnclose
            // 
            btnclose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose.ForeColor = SystemColors.ActiveCaption;
            btnclose.Image = (Image)resources.GetObject("btnclose.Image");
            btnclose.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose.Location = new Point(1146, 645);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(112, 34);
            btnclose.TabIndex = 8;
            btnclose.Text = "   Close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // frmDrivers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 688);
            Controls.Add(btnclose);
            Controls.Add(lblNumberOfDrivers);
            Controls.Add(txtChangeNameFilter);
            Controls.Add(cbFilter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvDriversList);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmDrivers";
            Text = "Drivers";
            Load += frmDrivers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDriversList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvDriversList;
        private Label label2;
        private Label label3;
        private ComboBox cbFilter;
        private TextBox txtChangeNameFilter;
        private Label lblNumberOfDrivers;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem showToolStripMenuItem;
        private Button btnclose;
    }
}