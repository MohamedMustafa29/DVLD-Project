using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.People.UserControl
{
    public partial class ctrlClsPeopleInfo : System.Windows.Forms.UserControl
    {
        private int _personID = -1;


        private clsPerson _Person;

        public int PersonID
        {
            get { return _personID; }
        }

        public ctrlClsPeopleInfo()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int personID)
        {
            _Person = clsPerson.FindPeopleByID(personID);
            

            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with ID = " + personID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _personID = personID;

            _fillPersonInfo();


        }

        public void LoadPersonInfo(string nationalNumber)
        {


            _Person = clsPerson.FindPeopleByNationalNo(nationalNumber);

            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with NationalNumber = " + nationalNumber, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _personID = _Person.PersonID;

            _fillPersonInfo();



        }



        private void _fillPersonInfo()
        {
            lblID.Text = _Person.PersonID.ToString();
            lblName.Text = $"{_Person.FirstName} {_Person.SecondName} {_Person.ThirdName} {_Person.LastName}".Trim();

            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblNationalNumber.Text = _Person.NationalNo;
            lblAddress.Text = _Person.Address;
            lblGender.Text = (_Person.Gender == 0) ? "Male" : "Female";
            lblDate.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountry.Text = clsCountries.Find(_Person.NationalityCountryID).CountryName;

            _LoadPersonImage();
        }

        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
            {
                pbPersonImage.Image = Properties.Resources.Male_512;
            }
            else
            {
                pbPersonImage.Image = Properties.Resources.Female_512;
            }

            string imagePath = _Person.ImagePath;
            if (imagePath != "")
                if (System.IO.File.Exists(imagePath))
                    pbPersonImage.ImageLocation = imagePath;
                else
                    MessageBox.Show("Image file not found: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public void ResetPersonInfo()
        {
            _personID = -1;
            _Person = null;
            lblID.Text = "??";
            lblName.Text = "??";
            lblEmail.Text = "??";
            lblPhone.Text = "??";
            lblNationalNumber.Text = "??";
            lblAddress.Text = "??";
            lblGender.Text = "??";
            lblDate.Text = "??";
            pbPersonImage.ImageLocation = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmAddUpdatePeople frm = new frmAddUpdatePeople(_personID);
            frm.ShowDialog();
            LoadPersonInfo(_personID);
        }



    }
}