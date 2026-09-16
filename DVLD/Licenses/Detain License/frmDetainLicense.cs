using DVLD.Drivers;
using DVLD.general;
using DVLD.Global;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.Licenses.Detain_License
{
    public partial class frmDetainLicense : Form
    {
        private int _detainID = -1;
        private int _selectedLicenseID = -1;

        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            lblCreatedByUser.Text = (clsGlobal.currentUser != null) ? clsGlobal.currentUser.UserName : "";
            lblDetainDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void ctrlDriverLicenseInfoControlwithFilter1_OnLicenseSelected(int obj)
        {
            _selectedLicenseID = obj;
            lblLicenseID.Text = _selectedLicenseID.ToString();

            llShowLicensesHistory.Enabled = (_selectedLicenseID != -1);
            llShowNewLicenseInfo.Enabled = false; 

            if (_selectedLicenseID == -1 || ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo == null)
            {
                btnDetain.Enabled = false;
                return;
            }

            if (!ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.IsActive)
            {
                MessageBox.Show("Selected License is NOT Active, choose an active license to detain.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
                return;
            }

            if (ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.IsDetained)
            {
                MessageBox.Show("Selected License is already detained, choose another one.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnDetain.Enabled = false;
                return;
            }

            txtFineFees.Focus();
            btnDetain.Enabled = true;
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFineFees, null);
            }

            if (!clsValidation.IsNumber(txtFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txtFineFees, null);
            }
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo == null)
            {
                MessageBox.Show("Please select a valid license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            int createdByUserID = (clsGlobal.currentUser != null) ? clsGlobal.currentUser.UserID : 1;

            _detainID = ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.Detain(Convert.ToSingle(txtFineFees.Text.Trim()), createdByUserID);

            if (_detainID == -1)
            {
                MessageBox.Show("Failed to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDetainID.Text = _detainID.ToString();
            MessageBox.Show("License Detained Successfully with ID=" + _detainID.ToString(), "License Detained", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnDetain.Enabled = false;
            ctrlDriverLicenseInfoControlwithFilter1.IsFilterEnabled = false;
            txtFineFees.Enabled = false;
            llShowNewLicenseInfo.Enabled = true;
        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo == null || ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.DriverInfo == null)
            {
                MessageBox.Show("Please select a license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int personID = ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.DriverInfo.PersonID;

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(personID);
            frm.ShowDialog();
        }

        private void llShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_selectedLicenseID == -1)
            {
                MessageBox.Show("Please select a license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowDriverLicenseInfo frm = new frmShowDriverLicenseInfo(_selectedLicenseID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}