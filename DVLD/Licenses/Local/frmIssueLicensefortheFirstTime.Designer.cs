namespace DVLD.Licenses
{
    partial class frmIssueLicensefortheFirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueLicensefortheFirstTime));
            ctrlLocalDrivingLicenseApplicationInfo1 = new DVLD.Applications.Manage_Application.ctrlLocalDrivingLicenseApplicationInfo();
            label1 = new Label();
            txtNotes = new RichTextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseApplicationInfo1
            // 
            ctrlLocalDrivingLicenseApplicationInfo1.Location = new Point(-6, 12);
            ctrlLocalDrivingLicenseApplicationInfo1.Name = "ctrlLocalDrivingLicenseApplicationInfo1";
            ctrlLocalDrivingLicenseApplicationInfo1.Size = new Size(1251, 617);
            ctrlLocalDrivingLicenseApplicationInfo1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 632);
            label1.Name = "label1";
            label1.Size = new Size(95, 32);
            label1.TabIndex = 2;
            label1.Text = "Notes :";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(269, 632);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(687, 103);
            txtNotes.TabIndex = 3;
            txtNotes.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(183, 636);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(979, 726);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "  Close";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ActiveCaption;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(1109, 726);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "   Issue";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmIssueLicensefortheFirstTime
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 772);
            Controls.Add(btnSave);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(txtNotes);
            Controls.Add(label1);
            Controls.Add(ctrlLocalDrivingLicenseApplicationInfo1);
            Name = "frmIssueLicensefortheFirstTime";
            Text = "Issue License for the FirstTime";
            Load += frmIssueLicensefortheFirstTime_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Applications.Manage_Application.ctrlLocalDrivingLicenseApplicationInfo ctrlLocalDrivingLicenseApplicationInfo1;
        private Label label1;
        private RichTextBox txtNotes;
        private PictureBox pictureBox1;
        private Button button1;
        private Button btnSave;
    }
}