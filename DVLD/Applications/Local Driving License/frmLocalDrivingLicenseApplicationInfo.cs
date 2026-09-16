using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.Applications.Manage_Application
{
    public partial class frmLocalDrivingLicenseApplicationInfo : Form
    {
        private int _localDrivingLicenseApplicationID = -1;
        public frmLocalDrivingLicenseApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _localDrivingLicenseApplicationID= LocalDrivingLicenseApplicationID;
            ctrlLocalDrivingLicenseApplicationInfo1.LoadByLocalDrivingLicenseApplicationID(_localDrivingLicenseApplicationID);
            
        }


    }
}
