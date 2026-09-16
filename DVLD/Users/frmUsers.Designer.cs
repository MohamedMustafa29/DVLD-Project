namespace DVLD.Users
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnAddUser = new Button();
            dgvUsersList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showToolStripMenuItem = new ToolStripMenuItem();
            addPersonToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            cbFilter = new ComboBox();
            label2 = new Label();
            txtFilter = new TextBox();
            label3 = new Label();
            lblNumberOfUsers = new Label();
            cbActivFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsersList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(466, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(452, 191);
            label1.Name = "label1";
            label1.Size = new Size(231, 45);
            label1.TabIndex = 1;
            label1.Text = "Manage Users";
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = SystemColors.ActiveCaption;
            btnAddUser.Image = (Image)resources.GetObject("btnAddUser.Image");
            btnAddUser.Location = new Point(1064, 205);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(67, 70);
            btnAddUser.TabIndex = 2;
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // dgvUsersList
            // 
            dgvUsersList.AllowUserToAddRows = false;
            dgvUsersList.AllowUserToDeleteRows = false;
            dgvUsersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsersList.BackgroundColor = SystemColors.ButtonHighlight;
            dgvUsersList.ColumnHeadersHeight = 34;
            dgvUsersList.ContextMenuStrip = contextMenuStrip1;
            dgvUsersList.GridColor = SystemColors.ScrollBar;
            dgvUsersList.Location = new Point(12, 288);
            dgvUsersList.Name = "dgvUsersList";
            dgvUsersList.ReadOnly = true;
            dgvUsersList.RowHeadersWidth = 62;
            dgvUsersList.Size = new Size(1129, 291);
            dgvUsersList.TabIndex = 3;
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
            addPersonToolStripMenuItem.Text = "Add User";
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
            // cbFilter
            // 
            cbFilter.FlatStyle = FlatStyle.Popup;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "User ID", "Person ID", "Full Name", "User Name", "IS Active" });
            cbFilter.Location = new Point(137, 242);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(182, 33);
            cbFilter.TabIndex = 4;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 243);
            label2.Name = "label2";
            label2.Size = new Size(100, 32);
            label2.TabIndex = 5;
            label2.Text = "Fiter By";
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(346, 244);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(197, 31);
            txtFilter.TabIndex = 6;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 597);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 7;
            label3.Text = "Numer Of Users :";
            // 
            // lblNumberOfUsers
            // 
            lblNumberOfUsers.AutoSize = true;
            lblNumberOfUsers.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberOfUsers.Location = new Point(188, 592);
            lblNumberOfUsers.Name = "lblNumberOfUsers";
            lblNumberOfUsers.Size = new Size(33, 30);
            lblNumberOfUsers.TabIndex = 8;
            lblNumberOfUsers.Text = "??";
            // 
            // cbActivFilter
            // 
            cbActivFilter.FlatStyle = FlatStyle.Popup;
            cbActivFilter.FormattingEnabled = true;
            cbActivFilter.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbActivFilter.Location = new Point(346, 242);
            cbActivFilter.Name = "cbActivFilter";
            cbActivFilter.Size = new Size(197, 33);
            cbActivFilter.TabIndex = 9;
            cbActivFilter.SelectedIndexChanged += cbActivFilter_SelectedIndexChanged;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 631);
            Controls.Add(lblNumberOfUsers);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbFilter);
            Controls.Add(dgvUsersList);
            Controls.Add(btnAddUser);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(cbActivFilter);
            Controls.Add(txtFilter);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users List";
            Load += frmUsers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsersList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnAddUser;
        private DataGridView dgvUsersList;
        private ComboBox cbFilter;
        private Label label2;
        private TextBox txtFilter;
        private Label label3;
        private Label lblNumberOfUsers;
        private ComboBox cbActivFilter;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem addPersonToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}