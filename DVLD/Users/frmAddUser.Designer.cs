namespace DVLD.Users
{
    partial class frmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            lblAddOrEdit = new Label();
            btnSaveUser = new Button();
            btnCloseform = new Button();
            tabPageLoginInfo = new TabPage();
            cbISActive = new CheckBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtConfirmPass = new TextBox();
            txtPass = new TextBox();
            txtName = new TextBox();
            lblUserID = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbPersonInfo = new TabPage();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            btnNextPage = new Button();
            ctrlClsPeopleWithFilter1 = new DVLD.People.UserControl.ctrlClsPeopleWithFilter();
            tbSwitch = new TabControl();
            errorProvider1 = new ErrorProvider(components);
            tabPageLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tbPersonInfo.SuspendLayout();
            tabControl2.SuspendLayout();
            tbSwitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblAddOrEdit
            // 
            lblAddOrEdit.AutoSize = true;
            lblAddOrEdit.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddOrEdit.ForeColor = Color.IndianRed;
            lblAddOrEdit.Location = new Point(484, 21);
            lblAddOrEdit.Name = "lblAddOrEdit";
            lblAddOrEdit.Size = new Size(159, 45);
            lblAddOrEdit.TabIndex = 0;
            lblAddOrEdit.Text = "Add User";
            // 
            // btnSaveUser
            // 
            btnSaveUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveUser.ForeColor = SystemColors.ActiveCaption;
            btnSaveUser.Image = (Image)resources.GetObject("btnSaveUser.Image");
            btnSaveUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveUser.Location = new Point(1064, 780);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(112, 34);
            btnSaveUser.TabIndex = 10;
            btnSaveUser.Text = "   Save";
            btnSaveUser.UseVisualStyleBackColor = true;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // btnCloseform
            // 
            btnCloseform.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseform.ForeColor = SystemColors.ActiveCaption;
            btnCloseform.Image = (Image)resources.GetObject("btnCloseform.Image");
            btnCloseform.ImageAlign = ContentAlignment.MiddleLeft;
            btnCloseform.Location = new Point(946, 780);
            btnCloseform.Name = "btnCloseform";
            btnCloseform.Size = new Size(112, 34);
            btnCloseform.TabIndex = 11;
            btnCloseform.Text = "   Close";
            btnCloseform.UseVisualStyleBackColor = true;
            btnCloseform.Click += btnCloseform_Click;
            // 
            // tabPageLoginInfo
            // 
            tabPageLoginInfo.Controls.Add(cbISActive);
            tabPageLoginInfo.Controls.Add(pictureBox5);
            tabPageLoginInfo.Controls.Add(pictureBox3);
            tabPageLoginInfo.Controls.Add(pictureBox2);
            tabPageLoginInfo.Controls.Add(pictureBox1);
            tabPageLoginInfo.Controls.Add(txtConfirmPass);
            tabPageLoginInfo.Controls.Add(txtPass);
            tabPageLoginInfo.Controls.Add(txtName);
            tabPageLoginInfo.Controls.Add(lblUserID);
            tabPageLoginInfo.Controls.Add(label5);
            tabPageLoginInfo.Controls.Add(label4);
            tabPageLoginInfo.Controls.Add(label3);
            tabPageLoginInfo.Controls.Add(label2);
            tabPageLoginInfo.Location = new Point(4, 34);
            tabPageLoginInfo.Name = "tabPageLoginInfo";
            tabPageLoginInfo.Padding = new Padding(3);
            tabPageLoginInfo.Size = new Size(1156, 667);
            tabPageLoginInfo.TabIndex = 1;
            tabPageLoginInfo.Text = "LoginInfo";
            tabPageLoginInfo.UseVisualStyleBackColor = true;
            // 
            // cbISActive
            // 
            cbISActive.AutoSize = true;
            cbISActive.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbISActive.ForeColor = SystemColors.ActiveCaption;
            cbISActive.Location = new Point(549, 401);
            cbISActive.Name = "cbISActive";
            cbISActive.Size = new Size(129, 34);
            cbISActive.TabIndex = 13;
            cbISActive.Text = "IS Active";
            cbISActive.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(468, 329);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 37);
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(468, 255);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 37);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(468, 200);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 37);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(468, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 37);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(515, 332);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(239, 31);
            txtConfirmPass.TabIndex = 7;
            txtConfirmPass.UseSystemPasswordChar = true;
            txtConfirmPass.Validating += txtConfirmPass_Validating;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(515, 261);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(239, 31);
            txtPass.TabIndex = 6;
            txtPass.UseSystemPasswordChar = true;
            txtPass.Validating += txtPass_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(515, 200);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 31);
            txtName.TabIndex = 5;
            txtName.Validating += txtName_Validating;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUserID.ForeColor = SystemColors.ActiveCaption;
            lblUserID.Location = new Point(598, 138);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(36, 32);
            lblUserID.TabIndex = 4;
            lblUserID.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(177, 329);
            label5.Name = "label5";
            label5.Size = new Size(236, 32);
            label5.TabIndex = 3;
            label5.Text = "Confirm Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(177, 273);
            label4.Name = "label4";
            label4.Size = new Size(136, 32);
            label4.TabIndex = 2;
            label4.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(177, 215);
            label3.Name = "label3";
            label3.Size = new Size(146, 32);
            label3.TabIndex = 1;
            label3.Text = "UserName :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(188, 143);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 0;
            label2.Text = "User ID :";
            // 
            // tbPersonInfo
            // 
            tbPersonInfo.Controls.Add(tabControl2);
            tbPersonInfo.Controls.Add(btnNextPage);
            tbPersonInfo.Controls.Add(ctrlClsPeopleWithFilter1);
            tbPersonInfo.Location = new Point(4, 34);
            tbPersonInfo.Name = "tbPersonInfo";
            tbPersonInfo.Padding = new Padding(3);
            tbPersonInfo.Size = new Size(1156, 667);
            tbPersonInfo.TabIndex = 0;
            tbPersonInfo.Text = "PersonInfo";
            tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Location = new Point(-130, -147);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(300, 150);
            tabControl2.TabIndex = 11;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(292, 112);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(292, 112);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextPage.ForeColor = SystemColors.ActiveCaption;
            btnNextPage.Image = (Image)resources.GetObject("btnNextPage.Image");
            btnNextPage.ImageAlign = ContentAlignment.MiddleRight;
            btnNextPage.Location = new Point(997, 599);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(112, 34);
            btnNextPage.TabIndex = 8;
            btnNextPage.Text = "Next  ";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // ctrlClsPeopleWithFilter1
            // 
            ctrlClsPeopleWithFilter1.FiltererEnabled = true;
            ctrlClsPeopleWithFilter1.Location = new Point(15, 21);
            ctrlClsPeopleWithFilter1.Name = "ctrlClsPeopleWithFilter1";
            ctrlClsPeopleWithFilter1.ShowAddPerson = true;
            ctrlClsPeopleWithFilter1.Size = new Size(1145, 640);
            ctrlClsPeopleWithFilter1.TabIndex = 7;
            // 
            // tbSwitch
            // 
            tbSwitch.Controls.Add(tbPersonInfo);
            tbSwitch.Controls.Add(tabPageLoginInfo);
            tbSwitch.Location = new Point(12, 69);
            tbSwitch.Name = "tbSwitch";
            tbSwitch.SelectedIndex = 0;
            tbSwitch.Size = new Size(1164, 705);
            tbSwitch.TabIndex = 6;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 904);
            Controls.Add(btnCloseform);
            Controls.Add(tbSwitch);
            Controls.Add(btnSaveUser);
            Controls.Add(lblAddOrEdit);
            Name = "frmAddUser";
            Text = "Add User";
            Load += frmAddUser_Load;
            tabPageLoginInfo.ResumeLayout(false);
            tabPageLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tbPersonInfo.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tbSwitch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddOrEdit;
        private Button btnSaveUser;
        private Button btnCloseform;
        private TabPage tabPageLoginInfo;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtConfirmPass;
        private TextBox txtPass;
        private TextBox txtName;
        private Label lblUserID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tbPersonInfo;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button btnNextPage;
        private People.UserControl.ctrlClsPeopleWithFilter ctrlClsPeopleWithFilter1;
        private TabControl tbSwitch;
        private CheckBox cbISActive;
        private ErrorProvider errorProvider1;
    }
}