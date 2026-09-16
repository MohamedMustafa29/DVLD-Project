using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_Business
{
    public class clsDetainedLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int DetainID { set; get; }
        public int LicenseID { set; get; }
        public DateTime DetainDate { set; get; }
        public float FineFees { set; get; }
        public int CreatedByUserID { set; get; }
        public clsUsers CreatedByUserInfo { set; get; }
        public bool IsReleased { set; get; }
        public DateTime ReleaseDate { set; get; }
        public int ReleasedByUserID { set; get; }
        public clsUsers ReleasedByUserInfo { set; get; }
        public int ReleaseApplicationID { set; get; }

        public clsDetainedLicense()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MaxValue;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;

            Mode = enMode.AddNew;
        }

        public clsDetainedLicense(int detainID,
            int licenseID, DateTime detainDate,
            float fineFees, int createdByUserID,
            bool isReleased, DateTime releaseDate,
            int releasedByUserID, int releaseApplicationID)
        {
            this.DetainID = detainID;
            this.LicenseID = licenseID;
            this.DetainDate = detainDate;
            this.FineFees = fineFees;
            this.CreatedByUserID = createdByUserID;
            this.CreatedByUserInfo = clsUsers.FindUserByUserID(this.CreatedByUserID);
            this.IsReleased = isReleased;
            this.ReleaseDate = releaseDate;
            this.ReleasedByUserID = releasedByUserID;
            this.ReleaseApplicationID = releaseApplicationID;
            this.ReleasedByUserInfo = clsUsers.FindUserByUserID(this.ReleasedByUserID);

            Mode = enMode.Update;
        }

        private bool _AddNewDetainedLicense()
        {
            this.DetainID = clsDetainedLicenseData.AddNewDetainedLicense(
                this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);

            return (this.DetainID != -1);
        }

        private bool _UpdateDetainedLicense()
        {
            return clsDetainedLicenseData.UpdateDetainedLicense(
                this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);
        }

        public static clsDetainedLicense Find(int detainID)
        {
            int licenseID = -1;
            DateTime detainDate = DateTime.Now;
            float fineFees = 0;
            int createdByUserID = -1;
            bool isReleased = false;
            DateTime releaseDate = DateTime.MaxValue;
            int releasedByUserID = -1;
            int releaseApplicationID = -1;

            if (clsDetainedLicenseData.GetDetainedLicenseInfoByID(detainID,
                ref licenseID, ref detainDate,
                ref fineFees, ref createdByUserID,
                ref isReleased, ref releaseDate,
                ref releasedByUserID, ref releaseApplicationID))

                return new clsDetainedLicense(detainID,
                     licenseID, detainDate,
                     fineFees, createdByUserID,
                     isReleased, releaseDate,
                     releasedByUserID, releaseApplicationID);
            else
                return null;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicenseData.GetAllDetainedLicenses();
        }

        public static clsDetainedLicense FindByLicenseID(int licenseID)
        {
            int detainID = -1;
            DateTime detainDate = DateTime.Now;
            float fineFees = 0;
            int createdByUserID = -1;
            bool isReleased = false;
            DateTime releaseDate = DateTime.MaxValue;
            int releasedByUserID = -1;
            int releaseApplicationID = -1;

            if (clsDetainedLicenseData.GetDetainedLicenseInfoByLicenseID(licenseID,
                ref detainID, ref detainDate,
                ref fineFees, ref createdByUserID,
                ref isReleased, ref releaseDate,
                ref releasedByUserID, ref releaseApplicationID))

                return new clsDetainedLicense(detainID,
                     licenseID, detainDate,
                     fineFees, createdByUserID,
                     isReleased, releaseDate,
                     releasedByUserID, releaseApplicationID);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainedLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateDetainedLicense();
            }

            return false;
        }

        public static bool IsLicenseDetained(int licenseID)
        {
            return clsDetainedLicenseData.IsLicenseDetained(licenseID);
        }

        public bool ReleaseDetainedLicense(int releasedByUserID, int releaseApplicationID)
        {
            return clsDetainedLicenseData.ReleaseDetainedLicense(this.DetainID,
                   releasedByUserID, releaseApplicationID);
        }
    }
}