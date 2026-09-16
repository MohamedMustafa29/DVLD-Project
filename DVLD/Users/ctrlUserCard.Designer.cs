namespace DVLD.Users
{
    partial class ctrlUserCard
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
            Label lblISActive;
            ctrlClsPeopleInfo1 = new DVLD.People.UserControl.ctrlClsPeopleInfo();
            groupBox1 = new GroupBox();
            lblActive = new Label();
            lblID = new Label();
            lblName = new Label();
            lblUserID = new Label();
            lblUserName = new Label();
            lblISActive = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblISActive
            // 
            lblISActive.AutoSize = true;
            lblISActive.Location = new Point(762, 49);
            lblISActive.Name = "lblISActive";
            lblISActive.Size = new Size(115, 30);
            lblISActive.TabIndex = 2;
            lblISActive.Text = "IS Active :";
            // 
            // ctrlClsPeopleInfo1
            // 
            ctrlClsPeopleInfo1.Location = new Point(0, 0);
            ctrlClsPeopleInfo1.Name = "ctrlClsPeopleInfo1";
            ctrlClsPeopleInfo1.Size = new Size(1060, 479);
            ctrlClsPeopleInfo1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblActive);
            groupBox1.Controls.Add(lblID);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(lblISActive);
            groupBox1.Controls.Add(lblUserID);
            groupBox1.Controls.Add(lblUserName);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 444);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1062, 129);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Information";
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Location = new Point(983, 49);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(43, 30);
            lblActive.TabIndex = 5;
            lblActive.Text = "???";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(190, 49);
            lblID.Name = "lblID";
            lblID.Size = new Size(43, 30);
            lblID.TabIndex = 4;
            lblID.Text = "???";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(608, 49);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 30);
            lblName.TabIndex = 3;
            lblName.Text = "???";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(21, 49);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(95, 30);
            lblUserID.TabIndex = 1;
            lblUserID.Text = "UserID :";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(383, 49);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(133, 30);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "UserName :";
            // 
            // ctrlUserCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(ctrlClsPeopleInfo1);
            Name = "ctrlUserCard";
            Size = new Size(1068, 573);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private People.UserControl.ctrlClsPeopleInfo ctrlClsPeopleInfo1;
        private GroupBox groupBox1;
        private Label lblActive;
        private Label lblID;
        private Label lblName;
        private Label lblUserID;
        private Label lblUserName;
    }
}
