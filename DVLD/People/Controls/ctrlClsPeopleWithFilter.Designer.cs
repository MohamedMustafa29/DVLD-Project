namespace DVLD.People.UserControl
{
    partial class ctrlClsPeopleWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlClsPeopleWithFilter));
            ctrlClsPeopleInfo1 = new ctrlClsPeopleInfo();
            cbFilter = new ComboBox();
            label1 = new Label();
            txtFilterName = new TextBox();
            btnAddPerson = new Button();
            btnSearchPerson = new Button();
            gbFilter = new GroupBox();
            errorProvider1 = new ErrorProvider(components);
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlClsPeopleInfo1
            // 
            ctrlClsPeopleInfo1.Location = new Point(0, 106);
            ctrlClsPeopleInfo1.Name = "ctrlClsPeopleInfo1";
            ctrlClsPeopleInfo1.Size = new Size(1056, 452);
            ctrlClsPeopleInfo1.TabIndex = 0;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "Person ID", "National Number" });
            cbFilter.Location = new Point(135, 41);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(201, 40);
            cbFilter.TabIndex = 1;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 2;
            label1.Text = "Filter By";
            // 
            // txtFilterName
            // 
            txtFilterName.Location = new Point(351, 41);
            txtFilterName.Name = "txtFilterName";
            txtFilterName.Size = new Size(211, 39);
            txtFilterName.TabIndex = 3;
            txtFilterName.KeyPress += txtFilterName_KeyPress;
            txtFilterName.Validating += txtFilterName_Validating;
            // 
            // btnAddPerson
            // 
            btnAddPerson.BackgroundImage = (Image)resources.GetObject("btnAddPerson.BackgroundImage");
            btnAddPerson.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddPerson.Location = new Point(671, 38);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(55, 40);
            btnAddPerson.TabIndex = 5;
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // btnSearchPerson
            // 
            btnSearchPerson.AutoSize = true;
            btnSearchPerson.Image = (Image)resources.GetObject("btnSearchPerson.Image");
            btnSearchPerson.Location = new Point(601, 38);
            btnSearchPerson.Name = "btnSearchPerson";
            btnSearchPerson.Size = new Size(52, 40);
            btnSearchPerson.TabIndex = 6;
            btnSearchPerson.TextAlign = ContentAlignment.BottomLeft;
            btnSearchPerson.UseVisualStyleBackColor = true;
            btnSearchPerson.Click += btnSearchPerson_Click;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(cbFilter);
            gbFilter.Controls.Add(txtFilterName);
            gbFilter.Controls.Add(btnAddPerson);
            gbFilter.Controls.Add(btnSearchPerson);
            gbFilter.Controls.Add(label1);
            gbFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFilter.Location = new Point(0, 6);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(1059, 94);
            gbFilter.TabIndex = 7;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlClsPeopleWithFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ctrlClsPeopleInfo1);
            Controls.Add(gbFilter);
            Name = "ctrlClsPeopleWithFilter";
            Size = new Size(1059, 561);
            Load += ctrlClsPeopleWithFilter_Load;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlClsPeopleInfo ctrlClsPeopleInfo1;
        private ComboBox cbFilter;
        private Label label1;
        private TextBox txtFilterName;
        private Button btnSearch;
        private Button btnAddPerson;
        private Button btnSearchPerson;
        private GroupBox gbFilter;
        private ErrorProvider errorProvider1;
    }
}
