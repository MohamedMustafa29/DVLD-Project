using DVLD.Global;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.Applications.Test
{
    public partial class frmTakeTest : Form
    {
        private int _testAppointmentID = -1;
        private clsTest _test;
        private clsTestTypes.enTestType _testTypeID = clsTestTypes.enTestType.VisionTest;

        public frmTakeTest(int testAppointmentID, clsTestTypes.enTestType testType)
        {
            InitializeComponent();
            _testAppointmentID = testAppointmentID;
            _testTypeID = testType;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlScheduleTestInfo1.TestTypeID = _testTypeID;
            ctrlScheduleTestInfo1.LoadInfo(_testAppointmentID);

            if (ctrlScheduleTestInfo1.TestAppointmentID == -1)
            {
                btnSave.Enabled = false;
                return;
            }

            int testID = ctrlScheduleTestInfo1.TestID;

            if (testID != -1)
            {
                _test = clsTest.Find(testID);
                if (_test == null)
                    _test = new clsTest();

                if (_test.TestResult)
                    rbnPass.Checked = true;
                else
                    rbnFail.Checked = true;

                txtNotes.Text = _test.Notes;

                lblUserMessage.Visible = true;
                rbnPass.Enabled = false;
                rbnFail.Enabled = false;
                btnSave.Enabled = false;
                txtNotes.Enabled = false;
            }
            else
            {
                _test = new clsTest();
                lblUserMessage.Visible = false;
                rbnPass.Enabled = true;
                rbnFail.Enabled = true;
                btnSave.Enabled = true;
                txtNotes.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save!.",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            _test.TestAppointmentID = ctrlScheduleTestInfo1.TestAppointmentID;
            _test.TestResult = rbnPass.Checked;
            _test.Notes = txtNotes.Text.Trim();
            _test.CreatedByUserID = clsGlobal.currentUser.UserID;

            if (_test.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                ctrlScheduleTestInfo1.LoadInfo(_testAppointmentID);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}