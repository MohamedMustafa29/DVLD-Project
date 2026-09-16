using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.People.UserControl
{
    public partial class ctrlClsPeopleWithFilter : System.Windows.Forms.UserControl
    {
        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> Handler = OnPersonSelected;
            if (Handler != null) Handler(PersonID);
        }

        private bool _showAddPerson = true;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ShowAddPerson
        {
            get
            {
                return _showAddPerson;
            }
            set
            {
                _showAddPerson = value;
                btnAddPerson.Visible = _showAddPerson;
            }
        }

        private bool _iSFiltererEnabled = true;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool FiltererEnabled
        {
            get
            {
                return _iSFiltererEnabled;
            }
            set
            {
                _iSFiltererEnabled = value;
                gbFilter.Enabled = _iSFiltererEnabled;
            }
        }

        private int _PersonID = -1;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int PersonID
        {
            get
            {
                return ctrlClsPeopleInfo1.PersonID;
            }
        }

        public ctrlClsPeopleWithFilter()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int personID)
        {
            cbFilter.SelectedIndex = 0;
            txtFilterName.Text = personID.ToString();
            FindBy();
        }

        private void FindBy()
        {
            switch (cbFilter.Text)
            {
                case "Person ID":
                    ctrlClsPeopleInfo1.LoadPersonInfo(int.Parse(txtFilterName.Text));
                    break;
                case "National Number":
                    ctrlClsPeopleInfo1.LoadPersonInfo(txtFilterName.Text);
                    break;
                default:
                    break;
            }
            if (OnPersonSelected != null && FiltererEnabled)
                OnPersonSelected(ctrlClsPeopleInfo1.PersonID);
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fileds are Not Valdite!,Put Mouse to Red Icon to see What Wrong");
                return;
            }
            FindBy();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterName.Text = "";
            txtFilterName.Focus();
        }

        private void ctrlClsPeopleWithFilter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            txtFilterName.Focus();
        }

        private void txtFilterName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterName, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtFilterName, null);
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePeople frm = new frmAddUpdatePeople();
            frm.DataBack += DataBack;
            frm.ShowDialog();
        }

        private void DataBack(object sender, int PersonID)
        {
            cbFilter.SelectedIndex = 0;
            txtFilterName.Text = PersonID.ToString();
            ctrlClsPeopleInfo1.LoadPersonInfo(PersonID);
        }

        public void FilterFocus()
        {
            txtFilterName.Focus();
        }
        private void txtFilterName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearchPerson.PerformClick();
            }

            if (cbFilter.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}