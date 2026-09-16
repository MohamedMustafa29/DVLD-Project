using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.Drivers
{
    public partial class frmShowPersonLicenseHistory : Form
    {
        private int _personId;
        public frmShowPersonLicenseHistory(int personID)
        {
            InitializeComponent();
            _personId = personID;
        }

        public frmShowPersonLicenseHistory()
        {
            InitializeComponent();

        }


        private void frmPersonLicenseHistory_Load(object sender, EventArgs e)
        {

            if (_personId != -1)
            {
                ctrlClsPeopleWithFilter1.LoadPersonInfo(_personId);
                ctrlClsPeopleWithFilter1.FiltererEnabled = false;
                ctrlDriverLicenses1.LoadInfoBypersonID(_personId);
            }
            else
            {
                ctrlClsPeopleWithFilter1.FiltererEnabled = true;
                ctrlClsPeopleWithFilter1.FilterFocus();
            }
        }

        private void ctrlClsPeopleWithFilter1_OnPersonSelected(int obj)
        {
            _personId = obj;

            if (_personId == -1)
            {
                ctrlDriverLicenses1.Clear();
            }
            else
            {
                ctrlDriverLicenses1.LoadInfoBypersonID(_personId);
            }
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
