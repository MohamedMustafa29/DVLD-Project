namespace DVLD.People
{
    partial class frmShowPersonInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPersonInfo));
            label1 = new Label();
            ctrlClsPeopleInfo1 = new DVLD.People.UserControl.ctrlClsPeopleInfo();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(346, 36);
            label1.Name = "label1";
            label1.Size = new Size(390, 45);
            label1.TabIndex = 0;
            label1.Text = "Person Card Information";
            // 
            // ctrlClsPeopleInfo1
            // 
            ctrlClsPeopleInfo1.Location = new Point(12, 84);
            ctrlClsPeopleInfo1.Name = "ctrlClsPeopleInfo1";
            ctrlClsPeopleInfo1.Size = new Size(1500, 713);
            ctrlClsPeopleInfo1.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(924, 532);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 44);
            btnClose.TabIndex = 4;
            btnClose.Text = "     Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // UserInformationInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 588);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(ctrlClsPeopleInfo1);
            Name = "UserInformationInfo";
            Text = "UserInformationInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private UserControl.ctrlClsPeopleInfo ctrlClsPeopleInfo1;
        private Button btnClose;
    }
}