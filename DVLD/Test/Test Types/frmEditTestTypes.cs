using DVLD.general;
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
    public partial class frmEditTestTypes : Form
    {
        private clsTestTypes.enTestType _testTypeID = clsTestTypes.enTestType.VisionTest;
        private clsTestTypes _testType;

        public frmEditTestTypes(clsTestTypes.enTestType testTypeID)
        {
            InitializeComponent();
            _testTypeID = testTypeID;
        }

        private void _ResetDefaultValues()
        {
            lblTestID.Text = "";
            txtTestTitle.Text = "";
            rtxtDescription.Text = "";
            txtFeesTest.Text = "";
        }

        private void _Load()
        {
            // تم تمرير الـ Enum مباشرة للـ Find
            _testType = clsTestTypes.Find(_testTypeID);

            if (_testType == null)
            {
                MessageBox.Show("No Test Type with ID = " + (int)_testTypeID, "Test Type Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblTestID.Text = ((int)_testType.ID).ToString();
            txtTestTitle.Text = _testType.TestTypeTitle;
            rtxtDescription.Text = _testType.TestTypeDescription;
            txtFeesTest.Text = _testType.TestTypeFees.ToString();
        }

        private void frmEditTestTypes_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            _Load();
        }

        private void btnSaveTest_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _testType.TestTypeTitle = txtTestTitle.Text;
            _testType.TestTypeDescription = rtxtDescription.Text;
            _testType.TestTypeFees = Convert.ToDecimal(txtFeesTest.Text);

            if (_testType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTestTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTestTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTestTitle, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtTestTitle, null);
            }
        }

        private void rtxtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(rtxtDescription, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(rtxtDescription, null);
            }
        }

        private void txtFeesTest_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFeesTest.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFeesTest, "Fees cannot be blank.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFeesTest, null);
            }

            if (!clsValidation.IsNumber(txtFeesTest.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFeesTest, "Invalid Number.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFeesTest, null);
            }
        }

        private void btnCloseTest_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}