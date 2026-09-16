using DVLD.Properties;
using DVLD_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Applications.Test.Sechdule_Test
{
    public partial class frmscheduleTests : Form
    {
        private DataTable dtSechudleTestList;
        private int _localDrivingID = -1;
        private clsTestTypes.enTestType _testTypeID = clsTestTypes.enTestType.VisionTest;

        public frmscheduleTests(int localDrivingID, clsTestTypes.enTestType testTypeID)
        {
            InitializeComponent();
            _localDrivingID = localDrivingID;
            _testTypeID = testTypeID;

            ctrlLocalDrivingLicenseApplicationInfo1.LoadByLocalDrivingLicenseApplicationID(localDrivingID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshSechudleTestList()
        {
            dtSechudleTestList = clsTestAppointment.GetTestAppointmentsPerTestType(_localDrivingID, _testTypeID);
            dgvTestAppointments.DataSource = dtSechudleTestList;

            int count = (dtSechudleTestList != null) ? dtSechudleTestList.Rows.Count : 0;
            lblNumber.Text = count.ToString();

            if (dtSechudleTestList != null && dgvTestAppointments.Rows.Count > 0)
            {
                dgvTestAppointments.Columns["TestAppointmentID"].HeaderText = "Appointment ID";
                dgvTestAppointments.Columns["TestAppointmentID"].Width = 120;

                dgvTestAppointments.Columns["AppointmentDate"].HeaderText = "Appointment Date";
                dgvTestAppointments.Columns["AppointmentDate"].Width = 180;

                dgvTestAppointments.Columns["PaidFees"].HeaderText = "Paid Fees";
                dgvTestAppointments.Columns["PaidFees"].Width = 110;

                dgvTestAppointments.Columns["IsLocked"].HeaderText = "Is Locked";
                dgvTestAppointments.Columns["IsLocked"].Width = 100;
            }
        }

        private void _LoadTestTypeImageAndTitle()
        {
            switch (_testTypeID)
            {
                case clsTestTypes.enTestType.VisionTest:
                    pbTestTypeImage.Image = Resources.Vision_512;
                    lblTitle.Text = "Vision Test Appointments";
                    break;

                case clsTestTypes.enTestType.WrittenTest:
                    pbTestTypeImage.Image = Resources.Written_Test_512;
                    lblTitle.Text = "Written Test Appointments";
                    break;

                case clsTestTypes.enTestType.StreetTest:
                    pbTestTypeImage.Image = Resources.driving_test_512;
                    lblTitle.Text = "Street Test Appointments";
                    break;
            }
        }

        private void frmSechudleVisionTest_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();
            _RefreshSechudleTestList();
        }

        private void btnAddAppoint_Click(object sender, EventArgs e)
        {
            frmScheduleTest frm = new frmScheduleTest(_localDrivingID, _testTypeID, -1);
            frm.ShowDialog();
            _RefreshSechudleTestList();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (dgvTestAppointments.CurrentRow == null || dgvTestAppointments.CurrentRow.Cells["TestAppointmentID"].Value == DBNull.Value)
                return;

            int testAppointmentID = Convert.ToInt32(dgvTestAppointments.CurrentRow.Cells["TestAppointmentID"].Value);

            frmScheduleTest frm = new frmScheduleTest(_localDrivingID, _testTypeID, testAppointmentID);
            frm.ShowDialog();
            _RefreshSechudleTestList();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvTestAppointments.CurrentRow == null || dgvTestAppointments.CurrentRow.Cells["TestAppointmentID"].Value == DBNull.Value)
                return;

            int testAppointmentID = Convert.ToInt32(dgvTestAppointments.CurrentRow.Cells["TestAppointmentID"].Value);

            frmTakeTest frm = new frmTakeTest(testAppointmentID, _testTypeID);
            frm.ShowDialog();

            _RefreshSechudleTestList();
        }
    }
}