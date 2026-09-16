using DVLD.Global;
using DVLD_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Applications.Manage_Application
{
    public partial class frmAddLocalLicense : Form
    {
        private int _localApplicationID = -1;
        private int _selectedPersonID = -1;
        private enum enMode { Add = 1, Update = 2 };
        enMode _mode = enMode.Add;
        private clsLocalDrivingLicenseApplication _localDrivingLicenseApplication;

        public frmAddLocalLicense()
        {
            InitializeComponent();
            _mode = enMode.Add;
        }

        public frmAddLocalLicense(int localApplicationID)
        {
            InitializeComponent();
            _mode = enMode.Update;
            _localApplicationID = localApplicationID;
        }

        private void _fillLicenseClasses()
        {
            DataTable dtAlllicenses = clsLicenseClass.GetAllLicenseClasses();
            if (dtAlllicenses != null)
            {
                foreach (DataRow row in dtAlllicenses.Rows)
                {
                    cbLicensesClass.Items.Add(row["ClassName"]);
                }
            }
        }

        private void _ResetDefaultValues()
        {
            _fillLicenseClasses();

            if (_mode == enMode.Add)
            {
                lblAddOrUpdate.Text = "Add New Local License";
                this.Text = "Add New Local License";
                _localDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
                ctrlClsPeopleWithFilter1.Focus();
                tabApplicationInfo.Enabled = false;
                lblDate.Text = DateTime.Now.ToString();
                cbLicensesClass.SelectedIndex = 2;

                clsApplicationTypes appType = clsApplicationTypes.Find((int)clsApplication.enApplicationType.NewDrivingLicense);
                lblApplicationFees.Text = (appType != null) ? appType.ApplicationFees.ToString() : "0";

                lblCreatedBy.Text = (clsGlobal.currentUser != null) ? clsGlobal.currentUser.UserName : "";
            }
            else
            {
                lblAddOrUpdate.Text = "Update Local License";
                this.Text = "Update Local License";
                tabApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void _Load()
        {
            ctrlClsPeopleWithFilter1.Enabled = false;
            _localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(_localApplicationID);

            if (_localDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Local License with ID = " + _localApplicationID, "Local License Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlClsPeopleWithFilter1.LoadPersonInfo(_localDrivingLicenseApplication.ApplicantPersonID);
            lblID.Text = _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblDate.Text = _localDrivingLicenseApplication.ApplicationDate.ToString();
            lblApplicationFees.Text = _localDrivingLicenseApplication.PaidFees.ToString();

            clsUsers creatorUser = clsUsers.FindUserByUserID(_localDrivingLicenseApplication.CreatedByUserID);
            lblCreatedBy.Text = (creatorUser != null) ? creatorUser.UserName : "Unknown";

            clsLicenseClass licenseClass = clsLicenseClass.Find(_localDrivingLicenseApplication.LicenseClassID);
            if (licenseClass != null)
            {
                cbLicensesClass.SelectedIndex = cbLicensesClass.FindString(licenseClass.ClassName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsLicenseClass selectedClass = clsLicenseClass.Find(cbLicensesClass.Text);
            if (selectedClass == null)
            {
                MessageBox.Show("Please select a valid License Class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int licenseClassID = selectedClass.LicenseClassID;

            int activeApplicationID = clsApplication.GetActiveApplicationIDForLicenseClass(
                ctrlClsPeopleWithFilter1.PersonID,
                (int)clsApplication.enApplicationType.NewDrivingLicense,
                licenseClassID
            );

            if (activeApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class, the selected person already has an active application for this class with ID = " + activeApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLicensesClass.Focus();
                return;
            }

            if (clsLicense.IsLicenseExistByPersonID(ctrlClsPeopleWithFilter1.PersonID, licenseClassID))
            {
                MessageBox.Show("This person already has a license for this class, choose another class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _localDrivingLicenseApplication.ApplicantPersonID = ctrlClsPeopleWithFilter1.PersonID;
            _localDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _localDrivingLicenseApplication.ApplicationTypeID = (int)clsApplication.enApplicationType.NewDrivingLicense;
            _localDrivingLicenseApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _localDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _localDrivingLicenseApplication.PaidFees = Convert.ToDecimal(lblApplicationFees.Text);
            _localDrivingLicenseApplication.CreatedByUserID = (clsGlobal.currentUser != null) ? clsGlobal.currentUser.UserID : 1;
            _localDrivingLicenseApplication.LicenseClassID = licenseClassID;

            if (_localDrivingLicenseApplication.Save())
            {
                lblID.Text = _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                MessageBox.Show("Local License Application Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _mode = enMode.Update;
                lblAddOrUpdate.Text = "Update Local License";
                this.Close();
            }
            else
            {
                MessageBox.Show("Error while saving Local License Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddLocalLicense_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_mode == enMode.Update)
            {
                _Load();
            }
        }

        private void ctrlClsPeopleWithFilter1_OnPersonSelected(int obj)
        {
            _selectedPersonID = obj;
        }

        private void frmAddLocalLicense_Activated(object sender, EventArgs e)
        {
            ctrlClsPeopleWithFilter1.FilterFocus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlClsPeopleWithFilter1.PersonID == -1)
            {
                MessageBox.Show("Please select a person first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_mode == enMode.Update || ctrlClsPeopleWithFilter1.PersonID != -1)
            {
                btnSave.Enabled = true;
                tabApplicationInfo.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tabApplicationInfo"];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}