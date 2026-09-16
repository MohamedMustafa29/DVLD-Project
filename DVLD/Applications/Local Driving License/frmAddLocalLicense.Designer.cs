namespace DVLD.Applications.Manage_Application
{
    partial class frmAddLocalLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLocalLicense));
            tabControl1 = new TabControl();
            tabPersonInfo = new TabPage();
            btnNext = new Button();
            ctrlClsPeopleWithFilter1 = new DVLD.People.UserControl.ctrlClsPeopleWithFilter();
            tabApplicationInfo = new TabPage();
            lblCreatedBy = new Label();
            label6 = new Label();
            lblApplicationFees = new Label();
            label5 = new Label();
            cbLicensesClass = new ComboBox();
            label3 = new Label();
            lblDate = new Label();
            label4 = new Label();
            lblID = new Label();
            label2 = new Label();
            lblAddOrUpdate = new Label();
            button1 = new Button();
            btnSave = new Button();
            tabControl1.SuspendLayout();
            tabPersonInfo.SuspendLayout();
            tabApplicationInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPersonInfo);
            tabControl1.Controls.Add(tabApplicationInfo);
            tabControl1.Location = new Point(12, 79);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1084, 614);
            tabControl1.TabIndex = 0;
            // 
            // tabPersonInfo
            // 
            tabPersonInfo.Controls.Add(btnNext);
            tabPersonInfo.Controls.Add(ctrlClsPeopleWithFilter1);
            tabPersonInfo.Location = new Point(4, 34);
            tabPersonInfo.Name = "tabPersonInfo";
            tabPersonInfo.Padding = new Padding(3);
            tabPersonInfo.Size = new Size(1076, 576);
            tabPersonInfo.TabIndex = 0;
            tabPersonInfo.Text = "Person Info";
            tabPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = SystemColors.ActiveCaption;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(925, 523);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 37);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next   ";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // ctrlClsPeopleWithFilter1
            // 
            ctrlClsPeopleWithFilter1.FiltererEnabled = true;
            ctrlClsPeopleWithFilter1.Location = new Point(-4, -34);
            ctrlClsPeopleWithFilter1.Name = "ctrlClsPeopleWithFilter1";
            ctrlClsPeopleWithFilter1.ShowAddPerson = true;
            ctrlClsPeopleWithFilter1.Size = new Size(1588, 842);
            ctrlClsPeopleWithFilter1.TabIndex = 0;
            ctrlClsPeopleWithFilter1.OnPersonSelected += ctrlClsPeopleWithFilter1_OnPersonSelected;
            // 
            // tabApplicationInfo
            // 
            tabApplicationInfo.Controls.Add(lblCreatedBy);
            tabApplicationInfo.Controls.Add(label6);
            tabApplicationInfo.Controls.Add(lblApplicationFees);
            tabApplicationInfo.Controls.Add(label5);
            tabApplicationInfo.Controls.Add(cbLicensesClass);
            tabApplicationInfo.Controls.Add(label3);
            tabApplicationInfo.Controls.Add(lblDate);
            tabApplicationInfo.Controls.Add(label4);
            tabApplicationInfo.Controls.Add(lblID);
            tabApplicationInfo.Controls.Add(label2);
            tabApplicationInfo.Location = new Point(4, 34);
            tabApplicationInfo.Name = "tabApplicationInfo";
            tabApplicationInfo.Padding = new Padding(3);
            tabApplicationInfo.Size = new Size(1076, 576);
            tabApplicationInfo.TabIndex = 1;
            tabApplicationInfo.Text = "Application Info";
            tabApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCreatedBy.Location = new Point(574, 435);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(36, 32);
            lblCreatedBy.TabIndex = 9;
            lblCreatedBy.Text = "??";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(329, 435);
            label6.Name = "label6";
            label6.Size = new Size(151, 32);
            label6.TabIndex = 8;
            label6.Text = "Created By :";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblApplicationFees.Location = new Point(574, 354);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(36, 32);
            lblApplicationFees.TabIndex = 7;
            lblApplicationFees.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(325, 354);
            label5.Name = "label5";
            label5.Size = new Size(216, 32);
            label5.TabIndex = 6;
            label5.Text = "Application Fees :";
            // 
            // cbLicensesClass
            // 
            cbLicensesClass.FormattingEnabled = true;
            cbLicensesClass.Location = new Point(543, 280);
            cbLicensesClass.Name = "cbLicensesClass";
            cbLicensesClass.Size = new Size(266, 33);
            cbLicensesClass.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(325, 277);
            label3.Name = "label3";
            label3.Size = new Size(186, 32);
            label3.TabIndex = 4;
            label3.Text = "Licenses Class :";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDate.Location = new Point(593, 207);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(36, 32);
            lblDate.TabIndex = 3;
            lblDate.Text = "??";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(325, 207);
            label4.Name = "label4";
            label4.Size = new Size(220, 32);
            label4.TabIndex = 2;
            label4.Text = "Application Date :";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblID.Location = new Point(593, 135);
            lblID.Name = "lblID";
            lblID.Size = new Size(36, 32);
            lblID.TabIndex = 1;
            lblID.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(325, 135);
            label2.Name = "label2";
            label2.Size = new Size(236, 32);
            label2.TabIndex = 0;
            label2.Text = "D.L.Application ID :";
            // 
            // lblAddOrUpdate
            // 
            lblAddOrUpdate.AutoSize = true;
            lblAddOrUpdate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddOrUpdate.ForeColor = Color.IndianRed;
            lblAddOrUpdate.Location = new Point(201, 28);
            lblAddOrUpdate.Name = "lblAddOrUpdate";
            lblAddOrUpdate.Size = new Size(661, 48);
            lblAddOrUpdate.TabIndex = 1;
            lblAddOrUpdate.Text = "New Local Driving License Application";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(833, 699);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "   Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ActiveCaption;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(960, 699);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "   Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddLocalLicense
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 740);
            Controls.Add(btnSave);
            Controls.Add(button1);
            Controls.Add(lblAddOrUpdate);
            Controls.Add(tabControl1);
            Name = "frmAddLocalLicense";
            Text = "Add Local License";
            Activated += frmAddLocalLicense_Activated;
            Load += frmAddLocalLicense_Load;
            tabControl1.ResumeLayout(false);
            tabPersonInfo.ResumeLayout(false);
            tabApplicationInfo.ResumeLayout(false);
            tabApplicationInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPersonInfo;
        private TabPage tabApplicationInfo;
        private Label lblAddOrUpdate;
        private People.UserControl.ctrlClsPeopleWithFilter ctrlClsPeopleWithFilter1;
        private Button btnNext;
        private Button button1;
        private Button btnSave;
        private ComboBox cbLicensesClass;
        private Label label3;
        private Label lblDate;
        private Label label4;
        private Label lblID;
        private Label label2;
        private Label lblCreatedBy;
        private Label label6;
        private Label lblApplicationFees;
        private Label label5;
    }
}