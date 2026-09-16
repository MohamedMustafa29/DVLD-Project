using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.Applications.Test.Sechdule_Test
{
    public partial class frmScheduleTest : Form
    {
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsTestTypes.enTestType _testTypeID = clsTestTypes.enTestType.VisionTest;
        private int _testAppointmentID = -1;
        public frmScheduleTest(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType testTypeID, int testAppointmentID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _testTypeID = testTypeID;
            _testAppointmentID = testAppointmentID;
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            ctrlScheduleTest2.TestTypeID = _testTypeID;
            ctrlScheduleTest2.LoadLocalDrivingLicenseApplication(_LocalDrivingLicenseApplicationID, _testAppointmentID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
