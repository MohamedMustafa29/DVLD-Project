namespace DVLD.Drivers.Controls
{
    partial class ctrlDriverLicenses
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlDriverLicenses));
            groupBox1 = new GroupBox();
            tcTypeOfLicenses = new TabControl();
            tbLocal = new TabPage();
            lblNumberOfLocalLicenses = new Label();
            label3 = new Label();
            dgvLocalLicenses = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showLicensesInfoToolStripMenuItem = new ToolStripMenuItem();
            tpInternational = new TabPage();
            lblNumberOfInternationalLicenses = new Label();
            dgvInternationalLicenses = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            label1 = new Label();
            groupBox1.SuspendLayout();
            tcTypeOfLicenses.SuspendLayout();
            tbLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicenses).BeginInit();
            contextMenuStrip1.SuspendLayout();
            tpInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).BeginInit();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tcTypeOfLicenses);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1338, 301);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = " Driver Licenses";
            // 
            // tcTypeOfLicenses
            // 
            tcTypeOfLicenses.Controls.Add(tbLocal);
            tcTypeOfLicenses.Controls.Add(tpInternational);
            tcTypeOfLicenses.Location = new Point(20, 36);
            tcTypeOfLicenses.Name = "tcTypeOfLicenses";
            tcTypeOfLicenses.SelectedIndex = 0;
            tcTypeOfLicenses.Size = new Size(1302, 265);
            tcTypeOfLicenses.TabIndex = 0;
            // 
            // tbLocal
            // 
            tbLocal.Controls.Add(lblNumberOfLocalLicenses);
            tbLocal.Controls.Add(label3);
            tbLocal.Controls.Add(dgvLocalLicenses);
            tbLocal.Location = new Point(4, 39);
            tbLocal.Name = "tbLocal";
            tbLocal.Padding = new Padding(3);
            tbLocal.Size = new Size(1294, 222);
            tbLocal.TabIndex = 0;
            tbLocal.Text = "Local";
            tbLocal.UseVisualStyleBackColor = true;
            // 
            // lblNumberOfLocalLicenses
            // 
            lblNumberOfLocalLicenses.AutoSize = true;
            lblNumberOfLocalLicenses.Location = new Point(234, 167);
            lblNumberOfLocalLicenses.Name = "lblNumberOfLocalLicenses";
            lblNumberOfLocalLicenses.Size = new Size(52, 30);
            lblNumberOfLocalLicenses.TabIndex = 4;
            lblNumberOfLocalLicenses.Text = "###";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-4, 167);
            label3.Name = "label3";
            label3.Size = new Size(232, 30);
            label3.TabIndex = 3;
            label3.Text = "Number Of Licenses :";
            // 
            // dgvLocalLicenses
            // 
            dgvLocalLicenses.AllowUserToAddRows = false;
            dgvLocalLicenses.AllowUserToDeleteRows = false;
            dgvLocalLicenses.AllowUserToResizeColumns = false;
            dgvLocalLicenses.AllowUserToResizeRows = false;
            dgvLocalLicenses.BackgroundColor = SystemColors.ButtonFace;
            dgvLocalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalLicenses.ContextMenuStrip = contextMenuStrip1;
            dgvLocalLicenses.Location = new Point(3, 3);
            dgvLocalLicenses.Name = "dgvLocalLicenses";
            dgvLocalLicenses.RowHeadersWidth = 62;
            dgvLocalLicenses.Size = new Size(1285, 161);
            dgvLocalLicenses.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showLicensesInfoToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(254, 36);
            // 
            // showLicensesInfoToolStripMenuItem
            // 
            showLicensesInfoToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showLicensesInfoToolStripMenuItem.Image = (Image)resources.GetObject("showLicensesInfoToolStripMenuItem.Image");
            showLicensesInfoToolStripMenuItem.Name = "showLicensesInfoToolStripMenuItem";
            showLicensesInfoToolStripMenuItem.Size = new Size(253, 32);
            showLicensesInfoToolStripMenuItem.Text = "Show Licenses Info";
            showLicensesInfoToolStripMenuItem.Click += showLicensesInfoToolStripMenuItem_Click;
            // 
            // tpInternational
            // 
            tpInternational.Controls.Add(lblNumberOfInternationalLicenses);
            tpInternational.Controls.Add(dgvInternationalLicenses);
            tpInternational.Controls.Add(label1);
            tpInternational.Location = new Point(4, 39);
            tpInternational.Name = "tpInternational";
            tpInternational.Padding = new Padding(3);
            tpInternational.Size = new Size(1294, 222);
            tpInternational.TabIndex = 1;
            tpInternational.Text = "international";
            tpInternational.UseVisualStyleBackColor = true;
            // 
            // lblNumberOfInternationalLicenses
            // 
            lblNumberOfInternationalLicenses.AutoSize = true;
            lblNumberOfInternationalLicenses.Location = new Point(234, 167);
            lblNumberOfInternationalLicenses.Name = "lblNumberOfInternationalLicenses";
            lblNumberOfInternationalLicenses.Size = new Size(52, 30);
            lblNumberOfInternationalLicenses.TabIndex = 2;
            lblNumberOfInternationalLicenses.Text = "###";
            // 
            // dgvInternationalLicenses
            // 
            dgvInternationalLicenses.AllowUserToAddRows = false;
            dgvInternationalLicenses.AllowUserToDeleteRows = false;
            dgvInternationalLicenses.AllowUserToResizeColumns = false;
            dgvInternationalLicenses.BackgroundColor = SystemColors.ButtonFace;
            dgvInternationalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternationalLicenses.ContextMenuStrip = contextMenuStrip2;
            dgvInternationalLicenses.Location = new Point(0, 3);
            dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            dgvInternationalLicenses.RowHeadersWidth = 62;
            dgvInternationalLicenses.Size = new Size(1282, 161);
            dgvInternationalLicenses.TabIndex = 0;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(254, 36);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(253, 32);
            toolStripMenuItem1.Text = "Show Licenses Info";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-4, 167);
            label1.Name = "label1";
            label1.Size = new Size(232, 30);
            label1.TabIndex = 1;
            label1.Text = "Number Of Licenses :";
            // 
            // ctrlDriverLicenses
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ctrlDriverLicenses";
            Size = new Size(1338, 331);
            groupBox1.ResumeLayout(false);
            tcTypeOfLicenses.ResumeLayout(false);
            tbLocal.ResumeLayout(false);
            tbLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicenses).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            tpInternational.ResumeLayout(false);
            tpInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TabControl tcTypeOfLicenses;
        private TabPage tbLocal;
        private TabPage tpInternational;
        private DataGridView dgvLocalLicenses;
        private DataGridView dgvInternationalLicenses;
        private Label lblNumberOfLocalLicenses;
        private Label label3;
        private Label lblNumberOfInternationalLicenses;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showLicensesInfoToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}
