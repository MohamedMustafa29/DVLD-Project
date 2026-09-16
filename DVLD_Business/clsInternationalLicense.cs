using System;
using System.Data;
using DVLD_DataAccess;
using static DVLD_Business.clsApplication;

namespace DVLD_Business
{
    public class clsInternationalLicense : clsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsDriver DriverInfo { set; get; }
        public int InternationalLicenseID { set; get; }
        public int DriverID { set; get; }
        public int IssuedUsingLocalLicenseID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool IsActive { set; get; }

        public clsInternationalLicense()
        {
            this.ApplicationTypeID = (int)clsApplication.enApplicationType.NewInternationalDrivingLicense;

            this.InternationalLicenseID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = true;

            Mode = enMode.AddNew;
        }

        public clsInternationalLicense(int applicationID, int applicantPersonID,
            DateTime applicationDate,
            enApplicationStatus applicationStatus, DateTime lastStatusDate,
            decimal paidFees, int createdByUserID,
            int internationalLicenseID, int driverID, int issuedUsingLocalLicenseID,
            DateTime issueDate, DateTime expirationDate, bool isActive)
        {
            base.ApplicationID = applicationID;
            base.ApplicantPersonID = applicantPersonID;
            base.ApplicationDate = applicationDate;
            base.ApplicationTypeID = (int)clsApplication.enApplicationType.NewInternationalDrivingLicense;
            base.ApplicationStatus = applicationStatus;
            base.LastStatusDate = lastStatusDate;
            base.PaidFees = paidFees;
            base.CreatedByUserID = createdByUserID;

            this.InternationalLicenseID = internationalLicenseID;
            this.DriverID = driverID;
            this.IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.IsActive = isActive;

            this.DriverInfo = clsDriver.FindByDriverID(this.DriverID);

            Mode = enMode.Update;
        }

        private bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID =
                clsInternationalLicenseData.AddNewInternationalLicense(
                    this.ApplicationID,
                    this.DriverID,
                    this.IssuedUsingLocalLicenseID,
                    this.IssueDate,
                    this.ExpirationDate,
                    this.IsActive,
                    this.CreatedByUserID
                );

            return (this.InternationalLicenseID != -1);
        }

        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicenseData.UpdateInternationalLicense(
                this.InternationalLicenseID,
                this.ApplicationID,
                this.DriverID,
                this.IssuedUsingLocalLicenseID,
                this.IssueDate,
                this.ExpirationDate,
                this.IsActive,
                this.CreatedByUserID
            );
        }

        public static clsInternationalLicense Find(int internationalLicenseID)
        {
            int applicationID = -1;
            int driverID = -1;
            int issuedUsingLocalLicenseID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            bool isActive = true;
            int createdByUserID = -1;

            if (clsInternationalLicenseData.GetInternationalLicenseInfoByID(internationalLicenseID, ref applicationID, ref driverID,
                ref issuedUsingLocalLicenseID, ref issueDate, ref expirationDate, ref isActive, ref createdByUserID))
            {
                clsApplication application = clsApplication.Find(applicationID);

                if (application == null)
                    return null;

                return new clsInternationalLicense(
                    application.ApplicationID,
                    application.ApplicantPersonID,
                    application.ApplicationDate,
                    (enApplicationStatus)application.ApplicationStatus,
                    application.LastStatusDate,
                    application.PaidFees,
                    application.CreatedByUserID,
                    internationalLicenseID,
                    driverID,
                    issuedUsingLocalLicenseID,
                    issueDate,
                    expirationDate,
                    isActive
                );
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenseData.GetAllInternationalLicenses();
        }

        public override bool Save()
        {
            base.Mode = (this.Mode == enMode.AddNew) ? clsApplication._enMode.Add : clsApplication._enMode.Update;

            if (!base.Save())
                return false;

            this.ApplicationID = base.ApplicationID;

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateInternationalLicense();
            }

            return false;
        }

        public static int GetActiveInternationalLicenseIDByDriverID(int driverID)
        {
            return clsInternationalLicenseData.GetActiveInternationalLicenseIDByDriverID(driverID);
        }

        public static DataTable GetDriverInternationalLicenses(int driverID)
        {
            return clsInternationalLicenseData.GetDriverInternationalLicenses(driverID);
        }
    }
}