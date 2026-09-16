using DVLD.Global;
using DVLD.Properties;
using DVLD_Business;
using DVLD_DataAccess;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static DVLD_Business.clsTestTypes;

namespace DVLD.Applications.Test.Sechdule_Test
{
    public partial class ctrlScheduleTest : UserControl
    {
        private enum enMode { addNew = 0, update = 1 }
        enMode _mode = enMode.addNew;

        private enum enCreationMode { FirstTime = 0, RetakeTestShedule = 1 }
        enCreationMode creationMode = enCreationMode.FirstTime;

        private clsLocalDrivingLicenseApplication _localDrivingLincesesApplication;
        private int _localDrivingLincesesApplicationID = -1;
        private clsTestAppointment _testAppointment;
        private int _testAppointmentID = -1;

        private clsTestTypes.enTestType _testTypeID = clsTestTypes.enTestType.VisionTest;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public clsTestTypes.enTestType TestTypeID
        {
            get
            {
                return _testTypeID;
            }
            set
            {
                _testTypeID = value;

                switch (_testTypeID)
                {
                    case clsTestTypes.enTestType.VisionTest:
                        lblTitle.Text = "Vision Test";
                        pbTestType.Image = Resources.Vision_512;
                        break;

                    case clsTestTypes.enTestType.WrittenTest:
                        lblTitle.Text = "Written Test";
                        pbTestType.Image = Resources.Written_Test_512;
                        break;

                    case clsTestTypes.enTestType.StreetTest:
                        lblTitle.Text = "Street Test";
                        pbTestType.Image = Resources.driving_test_512;
                        break;
                }
            }
        }

        public ctrlScheduleTest()
        {
            InitializeComponent();
        }

        private bool _HandleActiveTestAppointment()
        {
            if (_mode == enMode.addNew && clsLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(_localDrivingLincesesApplicationID, _testTypeID))
            {
                lblUserMessage.Text = "You already have an active scheduled test for this test type. Please cancel it first before scheduling a new one.";
                lblUserMessage.Visible = true;
                btnSave.Enabled = false;
                dtpScheduleTest.Enabled = false;
                return false;
            }
            return true;
        }

        private bool _HandleAppointmentPerviousConstraints()
        {
            switch (_testTypeID)
            {
                case clsTestTypes.enTestType.VisionTest:
                    lblUserMessage.Visible = false;
                    return true;

                case clsTestTypes.enTestType.WrittenTest:
                    if (!clsLocalDrivingLicenseApplication.DoesPassTestType(_localDrivingLincesesApplicationID, clsTestTypes.enTestType.VisionTest))
                    {
                        lblUserMessage.Text = "You must pass the Vision Test before scheduling the Written Test.";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpScheduleTest.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        return true;
                    }

                case clsTestTypes.enTestType.StreetTest:
                    if (!clsLocalDrivingLicenseApplication.DoesPassTestType(_localDrivingLincesesApplicationID, clsTestTypes.enTestType.WrittenTest))
                    {
                        lblUserMessage.Text = "You must pass the Written Test before scheduling the Street Test.";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpScheduleTest.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        return true;
                    }
            }
            return true;
        }

        private bool _HandleTestAppointmentLockedConstraint()
        {
            if (_testAppointment != null && _testAppointment.IsLocked == true)
            {
                lblUserMessage.Text = "This test appointment is locked and cannot be modified.";
                lblUserMessage.Visible = true;
                btnSave.Enabled = false;
                dtpScheduleTest.Enabled = false;
                return false;
            }
            return true;
        }

        private bool _HandleRetakeApplication()
        {
            if (_mode == enMode.addNew && creationMode == enCreationMode.RetakeTestShedule)
            {
                clsApplication Application = new clsApplication();

                Application.ApplicantPersonID = _localDrivingLincesesApplication.ApplicantPersonID;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationTypeID = (int)clsApplication.enApplicationType.RetakeTest;
                Application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = clsApplicationTypes.Find((int)clsApplication.enApplicationType.RetakeTest).ApplicationFees;
                Application.CreatedByUserID = clsGlobal.currentUser.UserID;

                if (!Application.Save())
                {
                    _testAppointment.RetakeTestApplicationID = -1;
                    MessageBox.Show("Failed to Create application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _testAppointment.RetakeTestApplicationID = Application.ApplicationID;
            }

            return true;
        }

        private bool _LoadTestTypes()
        {
            _testAppointment = clsTestAppointment.Find(_testAppointmentID);
            if (_testAppointment == null)
            {
                MessageBox.Show("Error: Test Appointment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            lblFees.Text = clsTestTypes.Find(_testTypeID).TestTypeFees.ToString();

            if (DateTime.Compare(_testAppointment.AppointmentDate, DateTime.Now) < 0)
                dtpScheduleTest.MinDate = _testAppointment.AppointmentDate;
            else
                dtpScheduleTest.MinDate = DateTime.Now;

            if (_testAppointment.RetakeTestApplicationID == -1)
            {
                lblRAppFess.Text = "0";
                lblRAppID.Text = "N/A";
            }
            else
            {
                lblRAppFess.Text = clsApplicationTypes.Find((int)clsApplication.enApplicationType.RetakeTest).ApplicationFees.ToString();
                gpRetakeTest.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
                lblRAppID.Text = _testAppointment.RetakeTestApplicationID.ToString();
            }
            return true;
        }

        public void LoadLocalDrivingLicenseApplication(int localDrivingLincesesApplicationID, int testAppointmentID)
        {
            if (testAppointmentID == -1)
                _mode = enMode.addNew;
            else
                _mode = enMode.update;

            _localDrivingLincesesApplicationID = localDrivingLincesesApplicationID;
            _testAppointmentID = testAppointmentID;

            _localDrivingLincesesApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(_localDrivingLincesesApplicationID);
            if (_localDrivingLincesesApplication == null)
            {
                MessageBox.Show("Local Driving License Application not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_mode == enMode.addNew && clsLocalDrivingLicenseApplication.DoesPassTestType(_localDrivingLincesesApplicationID, _testTypeID))
            {
                lblUserMessage.Text = "Person already passed this test before, you cannot schedule it again.";
                lblUserMessage.Visible = true;
                btnSave.Enabled = false;
                dtpScheduleTest.Enabled = false;
                return;
            }

            if (_localDrivingLincesesApplication.DoesAttendTestType(_testTypeID))
                creationMode = enCreationMode.RetakeTestShedule;
            else
                creationMode = enCreationMode.FirstTime;

            if (creationMode == enCreationMode.RetakeTestShedule)
            {
                lblRAppFess.Text = clsApplicationTypes.Find((int)clsApplication.enApplicationType.RetakeTest).ApplicationFees.ToString();
                lblTitle.Text = "Schedule Retake Test";
                gpRetakeTest.Enabled = true;
                lblRAppID.Text = "N/A";
            }
            else
            {
                lblRAppFess.Text = "0";
                gpRetakeTest.Enabled = false;
                lblRAppID.Text = "N/A";
            }

            lblAppID.Text = _localDrivingLincesesApplication.ApplicationID.ToString();
            lblName.Text = _localDrivingLincesesApplication.FullName;
            lblTrial.Text = _localDrivingLincesesApplication.TotalTrialsPerTest(_testTypeID).ToString();
            lblClassName.Text = clsLicenseClass.Find(_localDrivingLincesesApplication.LicenseClassID).ClassName;

            if (_mode == enMode.addNew)
            {
                lblFees.Text = clsTestTypes.Find(_testTypeID).TestTypeFees.ToString();
                dtpScheduleTest.MinDate = DateTime.Now.AddDays(1);
                lblRAppID.Text = "N/A";
                _testAppointment = new clsTestAppointment();
            }
            else
            {
                if (!_LoadTestTypes())
                    return;
            }

            lblTotalFees.Text = (Convert.ToSingle(lblFees.Text) + Convert.ToSingle(lblRAppFess.Text)).ToString();

            if (!_HandleActiveTestAppointment())
                return;

            if (_mode == enMode.update && !_HandleTestAppointmentLockedConstraint())
                return;

            if (!_HandleAppointmentPerviousConstraints())
                return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication())
                return;

            _testAppointment.TestTypeID = _testTypeID;
            _testAppointment.LocalDrivingLicenseApplicationID = _localDrivingLincesesApplicationID;
            _testAppointment.AppointmentDate = dtpScheduleTest.Value;
            _testAppointment.PaidFees = Convert.ToDecimal(lblFees.Text);
            _testAppointment.CreatedByUserID = clsGlobal.currentUser.UserID;

            if (_testAppointment.Save())
            {
                _mode = enMode.update;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}