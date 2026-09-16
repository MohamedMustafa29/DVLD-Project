using DVLD.Properties;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using static DVLD_Business.clsTestTypes;

namespace DVLD.Applications.Test.Sechdule_Test
{
    public partial class ctrlScheduleTestInfo : UserControl
    {
        private clsLocalDrivingLicenseApplication _localDrivingLincesesApplication;
        private int _localDrivingLincesesApplicationID = -1;

        private clsTestAppointment _testAppointment;
        private int _testAppointmentID = -1;
        public int TestAppointmentID
        {
            get
            {
                return _testAppointmentID;
            }
        }

        public int TestID
        {
            get
            {
                return (_testAppointment != null) ? _testAppointment.TestID : -1;
            }
        }

        private clsTestTypes.enTestType _testTypeID = clsTestTypes.enTestType.VisionTest;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public clsTestTypes.enTestType TestTypeID
        {
            get => _testTypeID;
            set
            {
                _testTypeID = value;

                switch (_testTypeID)
                {
                    case clsTestTypes.enTestType.VisionTest:
                        gpTestType.Text = "Vision Test";
                        pbTestType.Image = Resources.Vision_512;
                        break;

                    case clsTestTypes.enTestType.WrittenTest:
                        gpTestType.Text = "Written Test";
                        pbTestType.Image = Resources.Written_Test_512;
                        break;

                    case clsTestTypes.enTestType.StreetTest:
                        gpTestType.Text = "Street Test";
                        pbTestType.Image = Resources.driving_test_512;
                        break;
                }
            }
        }

        public ctrlScheduleTestInfo()
        {
            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            lbLocalAppID.Text = "[??]";
            lblDrivingClass.Text = "[??]";
            lblName.Text = "[??]";
            lblTrial.Text = "[??]";
            lblDate.Text = "[??]";
            lblFees.Text = "[??]";
            lblTestID.Text = "Not Taken Yet";
        }

        public void LoadInfo(int testAppointmentID)
        {
            _testAppointmentID = testAppointmentID;

            _testAppointment = clsTestAppointment.Find(_testAppointmentID);

            if (_testAppointment == null)
            {
                MessageBox.Show("No Appointment with ID = " + _testAppointmentID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaultValues();
                return;
            }

            _localDrivingLincesesApplicationID = _testAppointment.LocalDrivingLicenseApplicationID;
            _localDrivingLincesesApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(_localDrivingLincesesApplicationID);

            if (_localDrivingLincesesApplication == null)
            {
                MessageBox.Show("No Local Driving License Application with ID = " + _localDrivingLincesesApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaultValues();
                return;
            }

            lbLocalAppID.Text = _localDrivingLincesesApplication.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = clsLicenseClass.Find(_localDrivingLincesesApplication.LicenseClassID).ClassName;
            lblName.Text = _localDrivingLincesesApplication.FullName;
            lblTrial.Text = _localDrivingLincesesApplication.TotalTrialsPerTest(_testTypeID).ToString();

            lblDate.Text = _testAppointment.AppointmentDate.ToString("dd/MMM/yyyy");

            lblFees.Text = _testAppointment.PaidFees.ToString("0.##");

            int testID = _testAppointment.TestID;
            lblTestID.Text = (testID == -1) ? "Not Taken Yet" : testID.ToString();
        }
    }
}