namespace DVLD.People
{
    partial class frmFindPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindPerson));
            ctrlClsPeopleWithFilter1 = new DVLD.People.UserControl.ctrlClsPeopleWithFilter();
            label1 = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ctrlClsPeopleWithFilter1
            // 
            ctrlClsPeopleWithFilter1.FiltererEnabled = true;
            ctrlClsPeopleWithFilter1.Location = new Point(2, 76);
            ctrlClsPeopleWithFilter1.Name = "ctrlClsPeopleWithFilter1";
            ctrlClsPeopleWithFilter1.ShowAddPerson = true;
            ctrlClsPeopleWithFilter1.Size = new Size(1563, 769);
            ctrlClsPeopleWithFilter1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(465, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 48);
            label1.TabIndex = 1;
            label1.Text = "Find Person";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1002, 629);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 53);
            btnClose.TabIndex = 2;
            btnClose.Text = "   Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button1_Click;
            // 
            // frmFindPerson
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 694);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(ctrlClsPeopleWithFilter1);
            Name = "frmFindPerson";
            Text = "Find Person";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControl.ctrlClsPeopleWithFilter ctrlClsPeopleWithFilter1;
        private Label label1;
        private Button btnClose;
    }
}