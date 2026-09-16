using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace DVLD_Business
{
    public class clsApplicationTypes
    {


        public int ApplicationTypeID { set; get; }
         public  string ApplicationTypeTitle { set; get; }
        public decimal ApplicationFees { set; get; }


        private clsApplicationTypes(int applicationTypeID, string applicationTypeTitle, decimal applicationFees)
        {
            ApplicationTypeID = applicationTypeID;
            ApplicationTypeTitle = applicationTypeTitle;
            ApplicationFees = applicationFees;
        }

        public clsApplicationTypes()
        {
            ApplicationTypeID = -1;
            ApplicationTypeTitle = "";
            ApplicationFees = 0;
        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypesData.GetAllApplicationTypes();
        }

      private bool _UpdateApplication()
        {
            return clsApplicationTypesData.UpdateApplicationType(
              this. ApplicationTypeID,
              this.ApplicationTypeTitle,
              this.ApplicationFees

                );
        }

        public static clsApplicationTypes Find(int applicationTypeID)
        {
            string applicationTypeTitle = "";
            decimal applicationFees = 0;

            if (clsApplicationTypesData.GetApplicationTypeInfoByID(applicationTypeID, ref applicationTypeTitle, ref applicationFees))
            {
                return new clsApplicationTypes(
                    applicationTypeID,
                    applicationTypeTitle,
                    applicationFees);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            return _UpdateApplication();
        }


    }
}
