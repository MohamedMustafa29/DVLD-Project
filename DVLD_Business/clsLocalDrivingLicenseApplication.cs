using DVLD_Business;
using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        enum _enMode { Add = 1, Update = 2 };
        _enMode Mode = _enMode.Add;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsLicenseClass LicenseClassInfo
        {
            get
            {
                return clsLicenseClass.Find(this.LicenseClassID);
            }
        }

        public clsLocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            LicenseClassID = -1;
            Mode = _enMode.Add;
        }

        private clsLocalDrivingLicenseApplication(int localDrivingLicenseApplications, int licenseClassID, int applicationID,
            int applicantPersonID, int applicationTypeID, enApplicationStatus applicationStatus,
            DateTime applicationDate, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplications;
            LicenseClassID = licenseClassID;
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

            Mode = _enMode.Update;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplications();
        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(
                this.ApplicationID,
                this.LicenseClassID
            );

            return (this.LocalDrivingLicenseApplicationID != -1);
        }

        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication(
                this.LocalDrivingLicenseApplicationID,
                this.ApplicationID,
                this.LicenseClassID
            );
        }
        public override bool Save()
        {
            base.Mode = (this.Mode == _enMode.Add) ? clsApplication._enMode.Add : clsApplication._enMode.Update;

            if (!base.Save())
            {
                return false;
            }

            
            this.ApplicationID = base.ApplicationID;

            switch (Mode)
            {
                case _enMode.Add:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                        Mode = _enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case _enMode.Update:
                    return _UpdateLocalDrivingLicenseApplication();

                default:
                    return false;
            }
        }

        public static clsLocalDrivingLicenseApplication FindByLocalDrivingLicenseApplicationID(int localDrivingLicenseApplicationID)
        {
            int applicationID = -1, licenseClassID = -1;

            bool isFound = clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByID(
                localDrivingLicenseApplicationID,
                ref applicationID,
                ref licenseClassID
            );

            if (isFound)
            {
                clsApplication application = clsApplication.Find(applicationID);

                if (application != null)
                {
                    return new clsLocalDrivingLicenseApplication
                    (
                        localDrivingLicenseApplicationID,
                        licenseClassID,
                        application.ApplicationID,
                        application.ApplicantPersonID,
                        application.ApplicationTypeID,
                        application.ApplicationStatus,
                        application.ApplicationDate,
                        application.LastStatusDate,
                        application.PaidFees,
                        application.CreatedByUserID
                    );
                }
            }

            return null;
        }

        public bool Delete()
        {
            bool IsLocalDrivingLicenseApplicationDeleted = clsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID);

            if (!IsLocalDrivingLicenseApplicationDeleted)
                return false;

            return base.Delete();
        }

        public static clsLocalDrivingLicenseApplication FindByApplicationID(int applicationID)
        {
            int localDrivingLicenseApplicationID = -1;
            int licenseClassID = -1;

            bool isFound = clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByApplicationID(
                applicationID,
                ref localDrivingLicenseApplicationID,
                ref licenseClassID
            );

            if (isFound)
            {
                clsApplication application = clsApplication.Find(applicationID);

                if (application != null)
                {
                    return new clsLocalDrivingLicenseApplication(
                        localDrivingLicenseApplicationID,
                        licenseClassID,
                        application.ApplicationID,
                        application.ApplicantPersonID,
                        application.ApplicationTypeID,
                        application.ApplicationStatus,
                        application.ApplicationDate,
                        application.LastStatusDate,
                        application.PaidFees,
                        application.CreatedByUserID
                    );
                }
            }

            return null;
        }

        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.DoesPassTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public static bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.DoesAttendTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public bool DoesPassTestType(clsTestTypes.enTestType TestTypeID)
        {
            return DoesPassTestType(this.LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public bool DoesAttendTestType(clsTestTypes.enTestType TestTypeID)
        {
            return DoesAttendTestType(this.LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public byte TotalTrialsPerTest(clsTestTypes.enTestType TestTypeID)
        {
            return TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.IsThereAnActiveScheduledTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public bool IsThereAnActiveScheduledTest(clsTestTypes.enTestType TestTypeID)
        {
            return IsThereAnActiveScheduledTest(this.LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationData.GetPassedTestCount(LocalDrivingLicenseApplicationID);
        }

        public byte GetPassedTestCount()
        {
            return GetPassedTestCount(this.LocalDrivingLicenseApplicationID);
        }

        public static bool PassedAllTests(int LocalDrivingLicenseApplicationID)
        {
            return GetPassedTestCount(LocalDrivingLicenseApplicationID) == 3;
        }

        public bool PassedAllTests()
        {
            return PassedAllTests(this.LocalDrivingLicenseApplicationID);
        }

        public int GetActiveLicenseID()
        {
            return clsLicense.GetActiveLicenseIDByPersonID(this.ApplicantPersonID, this.LicenseClassID);
        }
        public int IssuelicensefortheFirstTime(string notes, int createdByUserID)
        {
            int driverID = -1;
            clsDriver driver = clsDriver.FindByPersonID(this.ApplicantPersonID);

            if (driver == null)
            {
                driver = new clsDriver
                {
                    PersonID = this.ApplicantPersonID,
                    CreatedByUserID = createdByUserID
                };

                if (driver.Save())
                {
                    driverID = driver.DriverID;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                driverID = driver.DriverID;
            }

            clsLicense license = new clsLicense
            {
                ApplicationID = this.ApplicationID,
                DriverID = driverID,
                LicenseClass = this.LicenseClassID,
                IssueDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength),
                Notes = notes,
                PaidFees = (float)this.LicenseClassInfo.ClassFees,
                IsActive = true,
                IssueReason = clsLicense.enIssueReason.FirstTime,
                CreatedByUserID = createdByUserID
            };

            if (license.Save())
            {
                this.CompleteApplication();
                return license.LicenseID;
            }

            return -1;
        }

        public static bool IsLicenseIssued(int localDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationData.IsLicenseIssued(localDrivingLicenseApplicationID);
        }

        public bool IsLicenseIssued()
        {
            return IsLicenseIssued(this.LocalDrivingLicenseApplicationID);
        }
    }
}