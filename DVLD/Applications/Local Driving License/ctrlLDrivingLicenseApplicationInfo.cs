using DVLD.People;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Manage_Application
{
    public partial class ctrlLocalDrivingLicenseApplicationInfo : UserControl
    {
        private int _localDrivingLicenseApplicationID = -1;
        private clsLocalDrivingLicenseApplication _localDrivingLicenseApplication;

        public int LocalDrivingLicenseApplicationID
        {
            get { return _localDrivingLicenseApplicationID; }
        }

        public clsLocalDrivingLicenseApplication LocalDrivingLicenseApplicationInfo
        {
            get { return _localDrivingLicenseApplication; }
        }

        public ctrlLocalDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        private void _ResetLocalDrivingLicenseApplication()
        {
            _localDrivingLicenseApplicationID = -1;
            _localDrivingLicenseApplication = null;

            lblApplicationID.Text = "[???]";
            lblFees.Text = "[???]";
            lblDate.Text = "[???]";
            lblStatus.Text = "[???]";
            lblStatusDate.Text = "[???]";
            lblType.Text = "[???]";
            lblApplicant.Text = "[???]";
            lblCreatedBy.Text = "[???]";

            llViewPerson.Enabled = false;
        }

        public void LoadByLocalDrivingLicenseApplicationID(int localDrivingLicenseApplicationID)
        {
            _localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(localDrivingLicenseApplicationID);

            if (_localDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Local Driving License Application with ID = " + localDrivingLicenseApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetLocalDrivingLicenseApplication();
                return;
            }

            _localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            _FillApplicationBasicInfo();
        }

        private void _FillApplicationBasicInfo()
        {
            lblApplicationID.Text = _localDrivingLicenseApplication.ApplicationID.ToString();
            lblFees.Text = _localDrivingLicenseApplication.PaidFees.ToString();
            lblDate.Text = _localDrivingLicenseApplication.ApplicationDate.ToString("g");
            lblCreatedBy.Text = clsUsers.FindUserByUserID(_localDrivingLicenseApplication.CreatedByUserID)?.UserName ?? "[Unknown]";
            lblType.Text = clsApplicationTypes.Find(_localDrivingLicenseApplication.ApplicationTypeID)?.ApplicationTypeTitle ?? "[Unknown]";
            lblStatusDate.Text = _localDrivingLicenseApplication.LastStatusDate.ToString("g");
            lblStatus.Text = _localDrivingLicenseApplication.StatusText;
            lblApplicant.Text = _localDrivingLicenseApplication.FullName;

            llViewPerson.Enabled = true;

            ctrlLocalLicenseInforamtion1._LoadInformationByLocalLicenseID(_localDrivingLicenseApplication.LocalDrivingLicenseApplicationID);
        }

        private void llViewPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_localDrivingLicenseApplication == null)
            {
                MessageBox.Show("No application info available to view person details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowPersonInfo frm = new frmShowPersonInfo(_localDrivingLicenseApplication.ApplicantPersonID);
            frm.ShowDialog();
            LoadByLocalDrivingLicenseApplicationID(_localDrivingLicenseApplicationID);
        }
    }
}