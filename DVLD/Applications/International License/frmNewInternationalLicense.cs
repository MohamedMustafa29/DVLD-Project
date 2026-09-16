using DVLD.Drivers;
using DVLD.Global;
using DVLD.Licenses;
using DVLD.Licenses.Controls;
using DVLD.Licenses.International_License;
using DVLD_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Applications.International_License
{
    public partial class frmNewInternationalLicense : Form
    {
        private int _internationalLicenseID = -1;

        public frmNewInternationalLicense()
        {
            InitializeComponent();
        }

        private void frmNewInternationalLicense_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoControlwithFilter1.txtFilterFocus();

            lblApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblIssueDate.Text = lblApplicationDate.Text;
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToString("dd/MM/yyyy");

            lblFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicationType.NewInternationalDrivingLicense).ApplicationFees.ToString();
            lblCreatedBy.Text = clsGlobal.currentUser.UserName;
        }

        private void ctrlDriverLicenseInfoControlwithFilter1_OnLicenseSelected(int obj)
        {
            int selectedLicenseID = obj;

            lblLocalLicenseID.Text = selectedLicenseID.ToString();
            llShowLicensesHistory.Enabled = (selectedLicenseID != -1);

            if (selectedLicenseID == -1)
            {
                return;
            }

            if (ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo == null)
            {
                btnRenew.Enabled = false;
                return;
            }

            if (ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.LicenseClass != 3)
            {
                MessageBox.Show("Selected License should be Class 3, please choose another license.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            if (ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.IsLicenseExpired())
            {
                MessageBox.Show("Selected License is expired, please renew it first.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            if (!ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.IsActive)
            {
                MessageBox.Show("Selected License is Not Active, choose an active license.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            int activeInternationalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.DriverID);

            if (activeInternationalLicenseID != -1)
            {
                MessageBox.Show("Person already has an active international license with ID = " + activeInternationalLicenseID.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblILicenseID.Text = activeInternationalLicenseID.ToString();
                btnRenew.Enabled = false;
                llShowNewLicenseInfo.Enabled = true;
                _internationalLicenseID = activeInternationalLicenseID;
                return;
            }

            btnRenew.Enabled = true;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue International License?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsInternationalLicense internationalLicense = new clsInternationalLicense();

            internationalLicense.ApplicantPersonID = ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.DriverInfo.PersonID;
            internationalLicense.ApplicationDate = DateTime.Now;
            internationalLicense.ApplicationTypeID = (int)clsApplication.enApplicationType.NewInternationalDrivingLicense;
            internationalLicense.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            internationalLicense.LastStatusDate = DateTime.Now;

            clsApplicationTypes appType = clsApplicationTypes.Find((int)clsApplication.enApplicationType.NewInternationalDrivingLicense);
            internationalLicense.PaidFees = (appType != null) ? appType.ApplicationFees : 50;

            internationalLicense.CreatedByUserID = clsGlobal.currentUser.UserID;

            internationalLicense.DriverID = ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.DriverID;
            internationalLicense.IssuedUsingLocalLicenseID = ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.LicenseID;
            internationalLicense.IssueDate = DateTime.Now;
            internationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            internationalLicense.IsActive = true;

            if (!internationalLicense.Save())
            {
                MessageBox.Show("Failed to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblILApplicationID.Text = internationalLicense.ApplicationID.ToString();
            _internationalLicenseID = internationalLicense.InternationalLicenseID;
            lblILicenseID.Text = _internationalLicenseID.ToString();

            MessageBox.Show("International License Issued Successfully with ID = " + _internationalLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRenew.Enabled = false;
            ctrlDriverLicenseInfoControlwithFilter1.IsFilterEnabled = false;
            llShowNewLicenseInfo.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo == null)
                return;

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(_internationalLicenseID);
            frm.ShowDialog();
        }
    }
}