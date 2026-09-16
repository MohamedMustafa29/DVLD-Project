namespace DVLD.Applications.Test
{
    partial class frmTakeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTakeTest));
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtNotes = new RichTextBox();
            label3 = new Label();
            lblUserMessage = new Label();
            rbnFail = new RadioButton();
            rbnPass = new RadioButton();
            label1 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            ctrlScheduleTestInfo1 = new DVLD.Applications.Test.Sechdule_Test.ctrlScheduleTestInfo();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtNotes);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblUserMessage);
            groupBox1.Controls.Add(rbnFail);
            groupBox1.Controls.Add(rbnPass);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 588);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(615, 184);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(101, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(101, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(131, 58);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(398, 99);
            txtNotes.TabIndex = 5;
            txtNotes.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 66);
            label3.Name = "label3";
            label3.Size = new Size(76, 30);
            label3.TabIndex = 4;
            label3.Text = "Note :";
            // 
            // lblUserMessage
            // 
            lblUserMessage.AutoSize = true;
            lblUserMessage.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserMessage.ForeColor = Color.Firebrick;
            lblUserMessage.Location = new Point(299, 29);
            lblUserMessage.Name = "lblUserMessage";
            lblUserMessage.Size = new Size(248, 21);
            lblUserMessage.TabIndex = 3;
            lblUserMessage.Text = "You Can No Change The Result ";
            // 
            // rbnFail
            // 
            rbnFail.AutoSize = true;
            rbnFail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbnFail.Location = new Point(224, 20);
            rbnFail.Name = "rbnFail";
            rbnFail.Size = new Size(69, 32);
            rbnFail.TabIndex = 2;
            rbnFail.TabStop = true;
            rbnFail.Text = "Fail";
            rbnFail.UseVisualStyleBackColor = true;
            // 
            // rbnPass
            // 
            rbnPass.AutoSize = true;
            rbnPass.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbnPass.Location = new Point(131, 19);
            rbnPass.Name = "rbnPass";
            rbnPass.Size = new Size(78, 32);
            rbnPass.TabIndex = 1;
            rbnPass.TabStop = true;
            rbnPass.Text = "Pass";
            rbnPass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(88, 30);
            label1.TabIndex = 0;
            label1.Text = "Result :";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(403, 793);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 2;
            btnClose.Text = "   Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ActiveCaption;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(533, 793);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "   Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ctrlScheduleTestInfo1
            // 
            ctrlScheduleTestInfo1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            ctrlScheduleTestInfo1.Location = new Point(12, 3);
            ctrlScheduleTestInfo1.Margin = new Padding(3, 2, 3, 2);
            ctrlScheduleTestInfo1.Name = "ctrlScheduleTestInfo1";
            ctrlScheduleTestInfo1.Size = new Size(615, 607);
            ctrlScheduleTestInfo1.TabIndex = 4;
            // 
            // frmTakeTest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 839);
            Controls.Add(ctrlScheduleTestInfo1);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Name = "frmTakeTest";
            Text = "Take Test";
            Load += frmTakeTest_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbnFail;
        private RadioButton rbnPass;
        private Label label1;
        private Label label3;
        private Label lblUserMessage;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private RichTextBox txtNotes;
        private Button btnClose;
        private Button btnSave;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private Sechdule_Test.ctrlScheduleTestInfo ctrlScheduleTestInfo1;
    }
}