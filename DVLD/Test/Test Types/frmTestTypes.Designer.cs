namespace DVLD.Applications.Test
{
    partial class frmTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestTypes));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvTestTypes = new DataGridView();
            lblNumberOFTests = new Label();
            label = new Label();
            btnCloseTestFrom = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(453, 201);
            label1.Name = "label1";
            label1.Size = new Size(321, 48);
            label1.TabIndex = 0;
            label1.Text = "Manage Test Type";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(491, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dgvTestTypes
            // 
            dgvTestTypes.AllowUserToAddRows = false;
            dgvTestTypes.AllowUserToDeleteRows = false;
            dgvTestTypes.AllowUserToOrderColumns = true;
            dgvTestTypes.AllowUserToResizeColumns = false;
            dgvTestTypes.BackgroundColor = SystemColors.ButtonFace;
            dgvTestTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTestTypes.Location = new Point(13, 252);
            dgvTestTypes.Name = "dgvTestTypes";
            dgvTestTypes.RowHeadersWidth = 62;
            dgvTestTypes.Size = new Size(1199, 364);
            dgvTestTypes.TabIndex = 2;
            // 
            // lblNumberOFTests
            // 
            lblNumberOFTests.AutoSize = true;
            lblNumberOFTests.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberOFTests.ForeColor = Color.IndianRed;
            lblNumberOFTests.Location = new Point(297, 649);
            lblNumberOFTests.Name = "lblNumberOFTests";
            lblNumberOFTests.Size = new Size(33, 30);
            lblNumberOFTests.TabIndex = 6;
            lblNumberOFTests.Text = "??";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(25, 649);
            label.Name = "label";
            label.Size = new Size(266, 30);
            label.TabIndex = 5;
            label.Text = "Number Of Application :";
            // 
            // btnCloseTestFrom
            // 
            btnCloseTestFrom.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseTestFrom.ForeColor = SystemColors.ActiveCaption;
            btnCloseTestFrom.Image = (Image)resources.GetObject("btnCloseTestFrom.Image");
            btnCloseTestFrom.ImageAlign = ContentAlignment.MiddleLeft;
            btnCloseTestFrom.Location = new Point(1100, 645);
            btnCloseTestFrom.Name = "btnCloseTestFrom";
            btnCloseTestFrom.Size = new Size(112, 34);
            btnCloseTestFrom.TabIndex = 13;
            btnCloseTestFrom.Text = "   Close";
            btnCloseTestFrom.UseVisualStyleBackColor = true;
            btnCloseTestFrom.Click += btnCloseTestFrom_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(135, 40);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(134, 36);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // frmTestTypes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 707);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(btnCloseTestFrom);
            Controls.Add(lblNumberOFTests);
            Controls.Add(label);
            Controls.Add(dgvTestTypes);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "frmTestTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTestTypes";
            Load += frmTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvTestTypes;
        private Label lblNumberOFTests;
        private Label label;
        private Button btnCloseTestFrom;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}