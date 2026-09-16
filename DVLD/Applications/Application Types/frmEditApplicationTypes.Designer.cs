namespace DVLD.Applications
{
    partial class frmEditApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditApplicationTypes));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblID = new Label();
            txtApplicationTitle = new TextBox();
            txtFees = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(42, 19);
            label1.Name = "label1";
            label1.Size = new Size(508, 54);
            label1.TabIndex = 0;
            label1.Text = "Update Application Types";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label2.Location = new Point(81, 110);
            label2.Name = "label2";
            label2.Size = new Size(50, 26);
            label2.TabIndex = 1;
            label2.Text = "ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label3.Location = new Point(42, 175);
            label3.Name = "label3";
            label3.Size = new Size(196, 26);
            label3.TabIndex = 2;
            label3.Text = "Application Title :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label4.Location = new Point(67, 233);
            label4.Name = "label4";
            label4.Size = new Size(78, 26);
            label4.TabIndex = 3;
            label4.Text = "Fees :";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            lblID.Location = new Point(165, 110);
            lblID.Name = "lblID";
            lblID.Size = new Size(38, 26);
            lblID.TabIndex = 4;
            lblID.Text = "??";
            // 
            // txtApplicationTitle
            // 
            txtApplicationTitle.Location = new Point(313, 173);
            txtApplicationTitle.Name = "txtApplicationTitle";
            txtApplicationTitle.Size = new Size(237, 31);
            txtApplicationTitle.TabIndex = 5;
            txtApplicationTitle.Validating += txtApplicationTitle_Validating;
            // 
            // txtFees
            // 
            txtFees.Location = new Point(313, 228);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(237, 31);
            txtFees.TabIndex = 6;
            txtFees.Validating += txtFees_Validating;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(273, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 32);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(273, 228);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 32);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ActiveCaption;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(462, 289);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 9;
            btnSave.Text = "     Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(313, 289);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 12;
            btnClose.Text = "   Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmEditApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 335);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtFees);
            Controls.Add(txtApplicationTitle);
            Controls.Add(lblID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmEditApplicationTypes";
            Text = "Edit Application Types";
            Load += frmEditApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblID;
        private TextBox txtApplicationTitle;
        private TextBox txtFees;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnSave;
        private ErrorProvider errorProvider1;
        private Button btnClose;
    }
}