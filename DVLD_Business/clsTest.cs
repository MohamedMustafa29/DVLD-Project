using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_Business
{
    public class clsTest
    {
        private enum enMode { Add = 0, Update = 1 };
        enMode Mode = enMode.Add;
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public clsTestAppointment TestAppointmentInfo { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTest()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            TestAppointmentInfo = new clsTestAppointment();
            Notes = string.Empty;
            CreatedByUserID = -1;

            Mode = enMode.Add;
        }
        public clsTest(int testID, int appoinmentID, bool testResult, string notes, int createdByUser)
        {
            TestID = testID;
            TestAppointmentID = appoinmentID;
            TestResult = testResult;
            TestAppointmentInfo = clsTestAppointment.Find(appoinmentID);
            Notes = notes;
            CreatedByUserID = createdByUser;

            Mode = enMode.Update;


        }


        public static clsTest Find(int testID)
        {
            int appoinmentID = -1;
            int createdByUser = -1;
            bool testResult = false;
            string notes = string.Empty;

            if (clsTestData.GetTestInfoByID(testID, ref appoinmentID, ref testResult, ref notes, ref createdByUser))
            {
                return new clsTest(testID, appoinmentID, testResult, notes, createdByUser);
            }
            else
            {
                return null;
            }


        }

        public static clsTest FindByPersonAndTestTypeAndLicenseClass(int personID,
            int licenseClassID, int testTypeID)
        {
            int testID = -1; int appoinmentID = -1; bool testResult = false;
            string notes = string.Empty; int createdByUserID = -1;
            if (clsTestData.GetLastTestByPersonAndTestTypeAndLicenseClass(personID, licenseClassID, testTypeID,
                ref testID, ref appoinmentID, ref testResult, ref notes, ref createdByUserID))
            {
                return new clsTest(testID, appoinmentID, testResult, notes, createdByUserID);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllTests()
        {
            return clsTestData.GetAllTests();
        }

        private bool _AddNewTest()
        {
            this.TestID = clsTestData.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
            return this.TestID > 0;
        }

        private bool _UpdateTest()
        {
            return clsTestData.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddNewTest())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateTest();
                default:
                    return false;
            }
        }

        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return clsTestData.GetPassedTestCount(LocalDrivingLicenseApplicationID);
        }
        
        public static bool IsTestPassed(int LocalDrivingLicenseApplicationID)
        {
            return clsTestData.GetPassedTestCount(LocalDrivingLicenseApplicationID)==3;
        }

    }
}
