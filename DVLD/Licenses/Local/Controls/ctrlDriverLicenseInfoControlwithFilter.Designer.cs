namespace DVLD.Licenses.Controls
{
    partial class ctrlDriverLicenseInfoControlwithFilter
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlDriverLicenseInfoControlwithFilter));
            ctrlDriverLicenseInfoControl1 = new ctrlDriverLicenseInfoControl();
            gbFilter = new GroupBox();
            btnFind = new Button();
            txtFilter = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfoControl1
            // 
            ctrlDriverLicenseInfoControl1.Location = new Point(3, 105);
            ctrlDriverLicenseInfoControl1.Name = "ctrlDriverLicenseInfoControl1";
            ctrlDriverLicenseInfoControl1.Size = new Size(1174, 552);
            ctrlDriverLicenseInfoControl1.TabIndex = 0;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnFind);
            gbFilter.Controls.Add(txtFilter);
            gbFilter.Controls.Add(label1);
            gbFilter.Location = new Point(3, 3);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(594, 96);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter ";
            // 
            // btnFind
            // 
            btnFind.BackgroundImage = (Image)resources.GetObject("btnFind.BackgroundImage");
            btnFind.BackgroundImageLayout = ImageLayout.Zoom;
            btnFind.ForeColor = SystemColors.ControlLight;
            btnFind.Location = new Point(433, 27);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(47, 37);
            btnFind.TabIndex = 2;
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(148, 27);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(234, 31);
            txtFilter.TabIndex = 1;
            txtFilter.KeyPress += txtFilter_KeyPress;
            txtFilter.Validating += txtFilter_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "License ID";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlDriverLicenseInfoControlwithFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFilter);
            Controls.Add(ctrlDriverLicenseInfoControl1);
            Name = "ctrlDriverLicenseInfoControlwithFilter";
            Size = new Size(1175, 645);
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlDriverLicenseInfoControl ctrlDriverLicenseInfoControl1;
        private GroupBox gbFilter;
        private Label label1;
        private Button btnFind;
        private TextBox txtFilter;
        private ErrorProvider errorProvider1;
    }
}
