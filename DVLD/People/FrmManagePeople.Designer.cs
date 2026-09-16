namespace DVLD
{
    partial class FrmManagePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManagePeople));
            pictureBox1 = new PictureBox();
            dgvPeopleView = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showToolStripMenuItem = new ToolStripMenuItem();
            addPersonToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            lblManagePeople = new Label();
            label = new Label();
            cbFilter = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            lblNumber = new Label();
            txtChangeNameFilter = new TextBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeopleView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(482, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 160);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvPeopleView
            // 
            dgvPeopleView.AllowUserToAddRows = false;
            dgvPeopleView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeopleView.BackgroundColor = SystemColors.Control;
            dgvPeopleView.ColumnHeadersHeight = 34;
            dgvPeopleView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPeopleView.ContextMenuStrip = contextMenuStrip1;
            dgvPeopleView.Location = new Point(12, 300);
            dgvPeopleView.Name = "dgvPeopleView";
            dgvPeopleView.RowHeadersWidth = 62;
            dgvPeopleView.Size = new Size(1158, 305);
            dgvPeopleView.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showToolStripMenuItem, addPersonToolStripMenuItem, eToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(250, 132);
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            showToolStripMenuItem.Image = (Image)resources.GetObject("showToolStripMenuItem.Image");
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(249, 32);
            showToolStripMenuItem.Text = "Show Details";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // addPersonToolStripMenuItem
            // 
            addPersonToolStripMenuItem.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            addPersonToolStripMenuItem.Image = (Image)resources.GetObject("addPersonToolStripMenuItem.Image");
            addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            addPersonToolStripMenuItem.Size = new Size(249, 32);
            addPersonToolStripMenuItem.Text = "Add Person";
            addPersonToolStripMenuItem.Click += addPersonToolStripMenuItem_Click;
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            eToolStripMenuItem.Image = (Image)resources.GetObject("eToolStripMenuItem.Image");
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(249, 32);
            eToolStripMenuItem.Text = "Edit";
            eToolStripMenuItem.Click += eToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(249, 32);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // lblManagePeople
            // 
            lblManagePeople.AutoSize = true;
            lblManagePeople.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManagePeople.ForeColor = Color.Brown;
            lblManagePeople.Location = new Point(448, 179);
            lblManagePeople.Name = "lblManagePeople";
            lblManagePeople.Size = new Size(214, 30);
            lblManagePeople.TabIndex = 2;
            lblManagePeople.Text = "Manage People";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(12, 243);
            label.Name = "label";
            label.Size = new Size(119, 26);
            label.TabIndex = 3;
            label.Text = "Filter By";
            // 
            // cbFilter
            // 
            cbFilter.AccessibleRole = AccessibleRole.None;
            cbFilter.Cursor = Cursors.PanNW;
            cbFilter.DisplayMember = "None";
            cbFilter.FlatStyle = FlatStyle.Popup;
            cbFilter.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "Person ID", "National No.", "First Name", "Second Name", "Third Name", "Last Name", "Gender", "Phone", "Email" });
            cbFilter.Location = new Point(147, 243);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(182, 38);
            cbFilter.TabIndex = 4;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(1062, 226);
            button1.Name = "button1";
            button1.Size = new Size(80, 62);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 619);
            label1.Name = "label1";
            label1.Size = new Size(249, 28);
            label1.TabIndex = 6;
            label1.Text = "Number Of People :";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Showcard Gothic", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(267, 619);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(26, 28);
            lblNumber.TabIndex = 7;
            lblNumber.Text = "0";
            // 
            // txtChangeNameFilter
            // 
            txtChangeNameFilter.Location = new Point(359, 250);
            txtChangeNameFilter.Name = "txtChangeNameFilter";
            txtChangeNameFilter.Size = new Size(288, 31);
            txtChangeNameFilter.TabIndex = 8;
            txtChangeNameFilter.TextChanged += txtChangeNameFilter_TextChanged_1;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(977, 619);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(193, 34);
            btnClose.TabIndex = 71;
            btnClose.Text = "   Close ";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FrmManagePeople
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 680);
            Controls.Add(btnClose);
            Controls.Add(txtChangeNameFilter);
            Controls.Add(lblNumber);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(cbFilter);
            Controls.Add(label);
            Controls.Add(lblManagePeople);
            Controls.Add(dgvPeopleView);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmManagePeople";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage People";
            Load += FrmManagePeople_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeopleView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dgvPeopleView;
        private Label lblManagePeople;
        private Label label;
        private ComboBox cbFilter;
        private Button button1;
        private Label label1;
        private Label lblNumber;
        private TextBox txtChangeNameFilter;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem addPersonToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button btnClose;
    }
}