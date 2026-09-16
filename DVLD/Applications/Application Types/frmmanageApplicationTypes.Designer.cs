namespace DVLD.Applications
{
    partial class frmmanageApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmanageApplicationTypes));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvApplicationTypes = new DataGridView();
            label2 = new Label();
            lblNumberOfApplication = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(249, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(58, 215);
            label1.Name = "label1";
            label1.Size = new Size(575, 60);
            label1.TabIndex = 1;
            label1.Text = "Manage Application Types";
            // 
            // dgvApplicationTypes
            // 
            dgvApplicationTypes.AllowUserToAddRows = false;
            dgvApplicationTypes.AllowUserToDeleteRows = false;
            dgvApplicationTypes.AllowUserToResizeColumns = false;
            dgvApplicationTypes.AllowUserToResizeRows = false;
            dgvApplicationTypes.BackgroundColor = SystemColors.ButtonFace;
            dgvApplicationTypes.ColumnHeadersHeight = 34;
            dgvApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvApplicationTypes.Location = new Point(20, 289);
            dgvApplicationTypes.Name = "dgvApplicationTypes";
            dgvApplicationTypes.RowHeadersWidth = 62;
            dgvApplicationTypes.Size = new Size(694, 264);
            dgvApplicationTypes.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 556);
            label2.Name = "label2";
            label2.Size = new Size(266, 30);
            label2.TabIndex = 3;
            label2.Text = "Number Of Application :";
            // 
            // lblNumberOfApplication
            // 
            lblNumberOfApplication.AutoSize = true;
            lblNumberOfApplication.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberOfApplication.ForeColor = Color.IndianRed;
            lblNumberOfApplication.Location = new Point(292, 556);
            lblNumberOfApplication.Name = "lblNumberOfApplication";
            lblNumberOfApplication.Size = new Size(33, 30);
            lblNumberOfApplication.TabIndex = 4;
            lblNumberOfApplication.Text = "??";
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
            // frmmanageApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 595);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(lblNumberOfApplication);
            Controls.Add(label2);
            Controls.Add(dgvApplicationTypes);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmmanageApplicationTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Application Types";
            Load += frmmanageApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvApplicationTypes;
        private Label label2;
        private Label lblNumberOfApplication;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}