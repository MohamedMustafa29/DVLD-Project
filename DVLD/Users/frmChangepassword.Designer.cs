namespace DVLD.Users
{
    partial class frmChangepassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangepassword));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtCurrent = new TextBox();
            txtNew = new TextBox();
            txtConfrim = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnClose = new Button();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            ctrlUserCard2 = new ctrlUserCard();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 597);
            label1.Name = "label1";
            label1.Size = new Size(230, 32);
            label1.TabIndex = 1;
            label1.Text = "Current Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(213, 656);
            label2.Name = "label2";
            label2.Size = new Size(194, 32);
            label2.TabIndex = 2;
            label2.Text = "New Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(207, 725);
            label3.Name = "label3";
            label3.Size = new Size(236, 32);
            label3.TabIndex = 3;
            label3.Text = "Confirm Password :";
            // 
            // TxtCurrent
            // 
            TxtCurrent.Location = new Point(518, 598);
            TxtCurrent.Name = "TxtCurrent";
            TxtCurrent.Size = new Size(255, 31);
            TxtCurrent.TabIndex = 4;
            TxtCurrent.UseSystemPasswordChar = true;
            TxtCurrent.Validating += TxtCurrent_Validating;
            // 
            // txtNew
            // 
            txtNew.Location = new Point(518, 659);
            txtNew.Name = "txtNew";
            txtNew.Size = new Size(255, 31);
            txtNew.TabIndex = 5;
            txtNew.UseSystemPasswordChar = true;
            txtNew.Validating += txtNew_Validating;
            // 
            // txtConfrim
            // 
            txtConfrim.Location = new Point(518, 728);
            txtConfrim.Name = "txtConfrim";
            txtConfrim.Size = new Size(255, 31);
            txtConfrim.TabIndex = 6;
            txtConfrim.UseSystemPasswordChar = true;
            txtConfrim.Validating += txtConfrim_Validating;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.SizeNESW;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(463, 598);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Cursor = Cursors.SizeNESW;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(463, 657);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Cursor = Cursors.SizeNESW;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(464, 715);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(798, 787);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 10;
            btnClose.Text = "    close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ActiveCaption;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(947, 787);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 11;
            btnSave.Text = "   Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlUserCard2
            // 
            ctrlUserCard2.Location = new Point(-3, 3);
            ctrlUserCard2.Name = "ctrlUserCard2";
            ctrlUserCard2.Size = new Size(1602, 579);
            ctrlUserCard2.TabIndex = 12;
            // 
            // frmChangepassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 844);
            Controls.Add(ctrlUserCard2);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtConfrim);
            Controls.Add(txtNew);
            Controls.Add(TxtCurrent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmChangepassword";
            Text = "Changepassword";
            Load += frmChangepassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlUserCard ctrlUserCard1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtCurrent;
        private TextBox txtNew;
        private TextBox txtConfrim;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnClose;
        private Button btnSave;
        private ErrorProvider errorProvider1;
        private ctrlUserCard ctrlUserCard2;
    }
}