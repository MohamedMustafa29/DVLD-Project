using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.Licenses.Controls
{
    public partial class ctrlDriverLicenseInfoControlwithFilter : UserControl
    {
        public event Action<int> OnLicenseSelected;

        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(LicenseID);
            }
        }

        private bool _isFilterEnabled = true;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsFilterEnabled
        {
            get { return _isFilterEnabled; }
            set
            {
                _isFilterEnabled = value;
                gbFilter.Enabled = _isFilterEnabled;
            }


        }
        private int _licenseID = -1;


        public clsLicense SelectedLicensesInfo
        { get { return ctrlDriverLicenseInfoControl1.SelectedLicensesInfo; } }
        public int LicenseID
        {
            get
            {
                return ctrlDriverLicenseInfoControl1.LicenseID;
            }
        }



        public void LoadInfo(int LicenseID)
        {
            txtFilter.Text = LicenseID.ToString();
            ctrlDriverLicenseInfoControl1.LoadLicenseInfo(LicenseID);
            _licenseID = ctrlDriverLicenseInfoControl1.LicenseID;

            if (IsFilterEnabled)
            {
                OnLicenseSelected?.Invoke(_licenseID);
            }

        }

        public ctrlDriverLicenseInfoControlwithFilter()
        {
            InitializeComponent();
        }



        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFilter.Focus();
                return;
            }

            _licenseID = int.Parse(txtFilter.Text);
            LoadInfo(_licenseID);
        }

        public void txtFilterFocus()
        {
            txtFilter.Focus();
        }


        private void txtFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilter, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtFilter, null);
            }

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == (char)13)
            {
                btnFind.PerformClick();
            }

        
        }
    }
}
