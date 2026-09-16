using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class frmUserCard : Form
    {

        private int _UserID;

        public frmUserCard(int userID)
        {
            InitializeComponent();
            _UserID = userID;
            ctrlUserCard1.LoadUserInfo(_UserID);
        }
    }
}
