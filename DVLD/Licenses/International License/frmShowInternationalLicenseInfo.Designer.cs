namespace DVLD.Licenses.International_License
{
    partial class frmShowInternationalLicenseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowInternationalLicenseInfo));
            ctrlDriverInternationalLicenseInfo1 = new DVLD.Licenses.International_License.Controls.ctrlDriverInternationalLicenseInfo();
            label1 = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ctrlDriverInternationalLicenseInfo1
            // 
            ctrlDriverInternationalLicenseInfo1.Location = new Point(12, 56);
            ctrlDriverInternationalLicenseInfo1.Name = "ctrlDriverInternationalLicenseInfo1";
            ctrlDriverInternationalLicenseInfo1.Size = new Size(1206, 450);
            ctrlDriverInternationalLicenseInfo1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(316, 9);
            label1.Name = "label1";
            label1.Size = new Size(562, 48);
            label1.TabIndex = 1;
            label1.Text = "Driver International License Info";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1046, 512);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 13;
            btnClose.Text = "   Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowInternationalLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 559);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(ctrlDriverInternationalLicenseInfo1);
            Name = "frmShowInternationalLicenseInfo";
            Text = "Show International License Info";
            Load += frmShowInternationalLicenseInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlDriverInternationalLicenseInfo ctrlDriverInternationalLicenseInfo1;
        private Label label1;
        private Button btnClose;
    }
}