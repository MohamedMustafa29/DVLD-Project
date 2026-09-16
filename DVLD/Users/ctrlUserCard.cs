using DVLD.People.UserControl;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class ctrlUserCard : UserControl
    {


        private int _userID = -1;


        private clsUsers _User;

        public int UserID
        {
            get { return _userID; }
        }


        public ctrlUserCard()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int userID)
        {
            _User = clsUsers.FindUserByUserID(userID);


            if (_User == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with ID = " + _userID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _userID = userID;

            _fillPersonInfo();
        }

        private void _fillPersonInfo()

        {
            ctrlClsPeopleInfo1.LoadPersonInfo(_User.PersonID);
            lblID.Text = _User.UserID.ToString();
            lblName.Text = _User.UserName.Trim();
            lblActive.Text=_User.IsActive.ToString();

            
           
        }


        private void ResetPersonInfo()
        {
            lblID.Text = "";
            lblName.Text = "";
            lblActive.Text = "";

        }


    }
}
