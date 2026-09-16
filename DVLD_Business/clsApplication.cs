using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_Business
{
    public class clsApplication
    {
        public enum _enMode { Add = 1, Update = 2 };
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicense = 5, NewInternationalDrivingLicense = 6, RetakeTest = 7
        };
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };

        public _enMode Mode = _enMode.Add;

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public clsPerson PersonInfo { get; set; }
        public int ApplicationTypeID { get; set; }
        public clsApplicationTypes ApplicationTypeInfo { get; set; }
        public enApplicationStatus ApplicationStatus { get; set; }


        public string StatusText
        {
            get
            {
                switch (ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "";
                }
            }
        }

        public string FullName
        {
            get
            {
                if (PersonInfo != null)
                    return PersonInfo.FullName;
                else
                    return "";
            }
        }

        public DateTime ApplicationDate { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUsers userInfo { get; set; }

        public clsApplication()
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = enApplicationStatus.New;
            this.ApplicationDate = DateTime.Now;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.Mode = _enMode.Add;
        }

        private clsApplication(int applicationID, int applicantPersonID, int applicationTypeID, enApplicationStatus applicationStatus, DateTime applicationDate, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {
            this.ApplicationID = applicationID;
            this.ApplicantPersonID = applicantPersonID;
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationStatus = applicationStatus;
            this.ApplicationDate = applicationDate;
            this.LastStatusDate = lastStatusDate;
            this.PaidFees = paidFees;
            this.CreatedByUserID = createdByUserID;

            this.PersonInfo = clsPerson.FindPeopleByID(applicantPersonID);
            this.ApplicationTypeInfo = clsApplicationTypes.Find(applicationTypeID);
            this.userInfo = clsUsers.FindUserByUserID(createdByUserID);

            this.Mode = _enMode.Update;
        }

        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationData.AddNewApplication(
                this.ApplicantPersonID,
                this.ApplicationDate,
                this.ApplicationTypeID,
                (byte)this.ApplicationStatus,
                this.LastStatusDate,
                this.PaidFees,
                this.CreatedByUserID
            );

            return (this.ApplicationID != -1);
        }

        private bool _UpdateApplication()
        {
            return clsApplicationData.UpdateApplication(
                this.ApplicationID,
                this.ApplicantPersonID,
                this.ApplicationDate,
                this.ApplicationTypeID,
                (byte)this.ApplicationStatus,
                this.LastStatusDate,
                this.PaidFees,
                this.CreatedByUserID
            );
        }

        public virtual bool Save()
        {
            switch (Mode)
            {
                case _enMode.Add:
                    if (_AddNewApplication())
                    {
                        Mode = _enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case _enMode.Update:
                    return _UpdateApplication();

                default:
                    return false;
            }
        }

        public static DataTable GetAllApplications()
        {
            return clsApplicationData.GetAllApplications();
        }

        public static clsApplication Find(int applicationID)
        {
            int applicantPersonID = -1;
            byte applicationStatus = 1;
            DateTime applicationDate = DateTime.Now;
            int applicationTypeID = -1;
            DateTime lastStatusDate = DateTime.Now;
            decimal paidFees = 0;
            int createdByUserID = -1;

            bool isFound = clsApplicationData.GetApplicationByApplicationID(
                applicationID,
                ref applicantPersonID,
                ref applicationStatus,
                ref applicationDate,
                ref applicationTypeID,
                ref lastStatusDate,
                ref paidFees,
                ref createdByUserID
            );

            if (isFound)
            {
                return new clsApplication(
                    applicationID,
                    applicantPersonID,
                    applicationTypeID,
                    (enApplicationStatus)applicationStatus,
                    applicationDate,
                    lastStatusDate,
                    paidFees,
                    createdByUserID
                );
            }
                     
                return null;
            
        }

        public bool Delete()
        {
            return clsApplicationData.DeleteApplication(this.ApplicationID);
        }

        public static bool IsApplicationExist(int applicationID)
        {
            return clsApplicationData.IsApplicationExist(applicationID);
        }

        public static bool CancelApplication(int applicationID)
        {
            return clsApplicationData.UpdateStatus(applicationID,2);
        }

        public bool CompleteApplication()
        {
            return clsApplicationData.UpdateStatus(this.ApplicationID, 3);
        }

        public static bool DoesPersonHaveActiveApplication(int personID, int applicationTypeID)
        {
            return GetActiveApplicationID(personID, applicationTypeID) != -1;
        }

        
        public static int GetActiveApplicationID(int personID, int applicationTypeID)
        {
            return clsApplicationData.GetActiveApplicationID(personID, applicationTypeID);
        }

        public static int GetActiveApplicationIDForLicenseClass(int personID, int applicationTypeID, int licenseClassID)
        {
            int active= clsApplicationData.GetActiveApplicationIDForLicenseClass(personID, applicationTypeID, licenseClassID);
            return active;
        }
    }
}