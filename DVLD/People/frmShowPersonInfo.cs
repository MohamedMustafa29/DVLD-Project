using DVLD.People.UserControl;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmShowPersonInfo : Form
    {
        private int _personID;

        public frmShowPersonInfo(int personID)
        {
            InitializeComponent();
            _personID = personID;

            ctrlClsPeopleInfo1.LoadPersonInfo(_personID);
        }

        public frmShowPersonInfo(string nationalNo)
        {
            InitializeComponent();

            ctrlClsPeopleInfo1.LoadPersonInfo(nationalNo);


        }




        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}