using DVLD.General;
using DVLD.general;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.People
{
    public delegate void PersonInfoUpdatedEventHandler(object sender, int PersonID);

    public partial class frmAddUpdatePeople : Form
    {
        public event PersonInfoUpdatedEventHandler DataBack;


        private int _PersonID;
        private enum enMode { Add = 1, Update = 2 };

        private clsPerson _Person;
        enMode _mode = enMode.Add;

        public frmAddUpdatePeople()
        {
            InitializeComponent();

            _mode = enMode.Add;
        }


        public frmAddUpdatePeople(int personID)
        {
            InitializeComponent();

            _mode = enMode.Update;
            this._PersonID = personID;
        }


        private void _ResetDefaultValues()
        {
            _FillCountriesInComoboBox();


            if (_mode == enMode.Add)
            {
                lblAddOrUpdate.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                lblAddOrUpdate.Text = "Edit Person Info";
            }

            if (rbnMan.Checked)
                pbMaleOrFemale.Image = Properties.Resources.Male_512;
            else
                pbMaleOrFemale.Image = Properties.Resources.Female_512;

            llRemove.Visible = (pbMaleOrFemale.ImageLocation != null);

            cbCountry.SelectedIndex = cbCountry.FindString("United States");

            dtDate.MaxDate = DateTime.Now.AddYears(-18);
            dtDate.Value = dtDate.MaxDate;
            dtDate.MinDate = DateTime.Now.AddYears(-100);

            txtFrist.Text = "";
            txtSecond.Text = "";
            txtLast.Text = "";
            txtThird.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            rtxtAddress.Text = "";
            txtNationalNumber.Text = "";
            rbnMan.Checked = true;




        }

        private void _FillCountriesInComoboBox()
        {
            cbCountry.Items.Clear();
            DataTable dtCountries = clsCountries.GetAllCountries();
            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }

        private void _Load()
        {


            _Person = clsPerson.FindPeopleByID(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblPersonID.Text = _Person.PersonID.ToString();
            txtFrist.Text = _Person.FirstName;
            txtSecond.Text = _Person.SecondName;
            txtThird.Text = _Person.ThirdName;
            txtLast.Text = _Person.LastName;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtNationalNumber.Text = _Person.NationalNo;
            rtxtAddress.Text = _Person.Address;
            
            

            dtDate.Value = _Person.DateOfBirth;

            if (_Person.ImagePath != "")
            {
                pbMaleOrFemale.ImageLocation = _Person.ImagePath;
                
            }

            llRemove.Visible = (_Person.ImagePath != "");


            if (_Person.Gender == 0)
                rbnMan.Checked = true;
            else
                rbnFemale.Checked = true;


            cbCountry.SelectedIndex = cbCountry.FindString(_Person.NationalityInfo.CountryName);


        }


        private bool _HandleImage()
        {
            if (_Person.ImagePath != pbMaleOrFemale.ImageLocation)

            {
                try
                {
                    if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
                    {
                        File.Delete(_Person.ImagePath);
                    }
                }
                catch (IOException)
                {

                    // Handle the exception (e.g., log it, show a message to the user, etc.)
                }
            }
            if (pbMaleOrFemale.ImageLocation != null)
            {
                string sourceFile = pbMaleOrFemale.ImageLocation.ToString();
                if (clsUtil.CopyImageToFolder(ref sourceFile))
                {
                    pbMaleOrFemale.ImageLocation = sourceFile;
                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to copy image.");
                    return false; 
                }
            }
            return true;
        }







        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbnMan_CheckedChanged(object sender, EventArgs e)
        {
            if (pbMaleOrFemale.ImageLocation==null)
            {
                pbMaleOrFemale.Image = Properties.Resources.Male_512;

            }
        }

        private void rbnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if  (pbMaleOrFemale.ImageLocation == null)
            {
                pbMaleOrFemale.Image = Properties.Resources.Female_512;
            }
        }

        private void llSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbMaleOrFemale.ImageLocation = openFileDialog1.FileName;
                llRemove.Visible = true;
            }
        }



        private void frmAddUpdatePeople_Load_1(object sender, EventArgs e)
        {
            _ResetDefaultValues();


            if (_mode == enMode.Update)
            {
                _Load();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_HandleImage())
                return;

            int CountryID = clsCountries.Find(cbCountry.Text).CountryID;

            _Person.FirstName = txtFrist.Text.Trim();
            _Person.SecondName = txtSecond.Text.Trim();
            _Person.ThirdName = txtThird.Text.Trim();
            _Person.LastName = txtLast.Text.Trim();
            _Person.NationalNo = txtNationalNumber.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Address = rtxtAddress.Text.Trim();
            _Person.DateOfBirth = dtDate.Value;
            _Person.NationalityCountryID = CountryID;

            _Person.Gender = (byte)(rbnMan.Checked ? 0 : 1);


            if (pbMaleOrFemale.ImageLocation != null)
                _Person.ImagePath = pbMaleOrFemale.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {

                lblPersonID.Text = _Person.PersonID.ToString();

                _mode = enMode.Update;
                lblAddOrUpdate.Text = "Edit Person Info";

                MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbMaleOrFemale.ImageLocation = null;

            if (rbnMan.Checked)
                pbMaleOrFemale.Image = Properties.Resources.Male_512;
            else
                pbMaleOrFemale.Image = Properties.Resources.Female_512;

            llRemove.Visible = false;
        }

        private void txtLast_Validating(object sender, CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
                return;

            if (!clsValidation.IsValidEmail(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }

        }

        private void txtNationalNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNumber, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtNationalNumber, null);
            }

            if (txtNationalNumber.Text.Trim() != _Person.NationalNo && clsPerson.IsPersonExist(txtNationalNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNumber, "This National Number Already Exists!");
            }
            else
            {
                errorProvider1.SetError(txtNationalNumber, null);
            }
        }

        private void rtxtAddress_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(rtxtAddress.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(rtxtAddress, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(rtxtAddress, null);
            }

        }
    }
}
