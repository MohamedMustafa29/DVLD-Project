namespace DVLD.Applications.Test
{
    partial class frmEditTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditTestTypes));
            btnCloseTest = new Button();
            btnSaveTest = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtFeesTest = new TextBox();
            txtTestTitle = new TextBox();
            lblTestID = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rtxtDescription = new RichTextBox();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnCloseTest
            // 
            btnCloseTest.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseTest.ForeColor = SystemColors.ActiveCaption;
            btnCloseTest.Image = (Image)resources.GetObject("btnCloseTest.Image");
            btnCloseTest.ImageAlign = ContentAlignment.MiddleLeft;
            btnCloseTest.Location = new Point(437, 386);
            btnCloseTest.Name = "btnCloseTest";
            btnCloseTest.Size = new Size(112, 34);
            btnCloseTest.TabIndex = 23;
            btnCloseTest.Text = "   Close";
            btnCloseTest.UseVisualStyleBackColor = true;
            btnCloseTest.Click += btnCloseTest_Click;
            // 
            // btnSaveTest
            // 
            btnSaveTest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveTest.ForeColor = SystemColors.ActiveCaption;
            btnSaveTest.Image = (Image)resources.GetObject("btnSaveTest.Image");
            btnSaveTest.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveTest.Location = new Point(562, 387);
            btnSaveTest.Name = "btnSaveTest";
            btnSaveTest.Size = new Size(112, 34);
            btnSaveTest.TabIndex = 22;
            btnSaveTest.Text = "     Save";
            btnSaveTest.UseVisualStyleBackColor = true;
            btnSaveTest.Click += btnSaveTest_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(365, 324);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 32);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(365, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 32);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // txtFeesTest
            // 
            txtFeesTest.Location = new Point(437, 324);
            txtFeesTest.Name = "txtFeesTest";
            txtFeesTest.Size = new Size(237, 31);
            txtFeesTest.TabIndex = 19;
            txtFeesTest.Validating += txtFeesTest_Validating;
            // 
            // txtTestTitle
            // 
            txtTestTitle.Location = new Point(437, 143);
            txtTestTitle.Name = "txtTestTitle";
            txtTestTitle.Size = new Size(237, 31);
            txtTestTitle.TabIndex = 18;
            txtTestTitle.Validating += txtTestTitle_Validating;
            // 
            // lblTestID
            // 
            lblTestID.AutoSize = true;
            lblTestID.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            lblTestID.Location = new Point(257, 83);
            lblTestID.Name = "lblTestID";
            lblTestID.Size = new Size(38, 26);
            lblTestID.TabIndex = 17;
            lblTestID.Text = "??";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label4.Location = new Point(134, 324);
            label4.Name = "label4";
            label4.Size = new Size(78, 26);
            label4.TabIndex = 16;
            label4.Text = "Fees :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label3.Location = new Point(125, 148);
            label3.Name = "label3";
            label3.Size = new Size(123, 26);
            label3.TabIndex = 15;
            label3.Text = "Test Title :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label2.Location = new Point(173, 83);
            label2.Name = "label2";
            label2.Size = new Size(50, 26);
            label2.TabIndex = 14;
            label2.Text = "ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(367, 54);
            label1.TabIndex = 13;
            label1.Text = "Update Test Types";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(434, 198);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(289, 107);
            rtxtDescription.TabIndex = 24;
            rtxtDescription.Text = "";
            rtxtDescription.Validating += rtxtDescription_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label5.Location = new Point(125, 236);
            label5.Name = "label5";
            label5.Size = new Size(146, 26);
            label5.TabIndex = 25;
            label5.Text = "Description :";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(365, 236);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 32);
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEditTestTypes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(744, 428);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(rtxtDescription);
            Controls.Add(btnCloseTest);
            Controls.Add(btnSaveTest);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtFeesTest);
            Controls.Add(txtTestTitle);
            Controls.Add(lblTestID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmEditTestTypes";
            Text = "frmEditTestTypes";
            Load += frmEditTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCloseTest;
        private Button btnSaveTest;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtFeesTest;
        private TextBox txtTestTitle;
        private Label lblTestID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox rtxtDescription;
        private Label label5;
        private PictureBox pictureBox3;
        private ErrorProvider errorProvider1;
    }
}