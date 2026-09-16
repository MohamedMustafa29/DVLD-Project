using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_Business
{
    public class clsTestAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TestAppointmentID { get; set; }
        public clsTestTypes.enTestType TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }

        public int TestID
        {
            get { return clsTestAppointmentData.GetTestID(TestAppointmentID); }
        }

        public clsTestAppointment()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = clsTestTypes.enTestType.VisionTest;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;

            Mode = enMode.AddNew;
        }

        public clsTestAppointment(int TestAppointmentID, clsTestTypes.enTestType TestTypeID,
            int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees,
            int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;

            Mode = enMode.Update;
        }

        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentData.AddNewTestAppointment(
                (int)this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, Convert.ToSingle(this.PaidFees), this.CreatedByUserID, this.RetakeTestApplicationID);

            return (this.TestAppointmentID != -1);
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentData.UpdateTestAppointment(
                this.TestAppointmentID, (int)this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, Convert.ToSingle(this.PaidFees), this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
        }

        public static clsTestAppointment Find(int testAppointmentID)
        {
            int testTypeID = -1, localLicenseID = -1, createdBy = -1, retakeTestAppID = -1;
            DateTime appointmentDate = DateTime.Now;
            decimal paidFees = 0;
            bool isLocked = false;

            // في حال كانت دالة DataAccess تتطلب float، يتم التعامل مع التحويل داخلياً
            float tempPaidFees = 0;

            bool isFound = clsTestAppointmentData.GetTestAppointmentInfoByID(
                testAppointmentID,
                ref localLicenseID,
                ref appointmentDate,
                ref tempPaidFees,
                ref createdBy,
                ref isLocked,
                ref testTypeID,
                ref retakeTestAppID);

            paidFees = Convert.ToDecimal(tempPaidFees);

            if (isFound)
            {
                return new clsTestAppointment(
                    testAppointmentID,
                    (clsTestTypes.enTestType)testTypeID,
                    localLicenseID,
                    appointmentDate,
                    paidFees,
                    createdBy,
                    isLocked,
                    retakeTestAppID);
            }
            else
            {
                return null;
            }
        }

        public static clsTestAppointment GetLastTestAppointment(int localDrivingLicenseApplicationID, clsTestTypes.enTestType testTypeID)
        {
            int testAppointmentID = -1, createdByUserID = -1, retakeTestAppID = -1;
            DateTime appointmentDate = DateTime.Now;
            float tempPaidFees = 0;
            bool isLocked = false;

            bool isFound = clsTestAppointmentData.GetLastTestAppointment(
                localDrivingLicenseApplicationID,
                (int)testTypeID,
                ref testAppointmentID,
                ref appointmentDate,
                ref tempPaidFees,
                ref createdByUserID,
                ref isLocked,
                ref retakeTestAppID);

            if (isFound)
            {
                return new clsTestAppointment(
                    testAppointmentID,
                    testTypeID,
                    localDrivingLicenseApplicationID,
                    appointmentDate,
                    Convert.ToDecimal(tempPaidFees),
                    createdByUserID,
                    isLocked,
                    retakeTestAppID);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetTestAppointmentsPerTestType(int localDrivingLicenseApplicationID, clsTestTypes.enTestType testTypeID)
        {
            return clsTestAppointmentData.GetTestAppointments((int)testTypeID, localDrivingLicenseApplicationID);
        }

        public static DataTable GetAllTestAppointments()
        {
            return clsTestAppointmentData.GetAllTestAppointments();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateTestAppointment();
            }

            return false;
        }
    }
}