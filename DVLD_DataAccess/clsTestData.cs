using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsTestData
    {


        public static bool GetTestInfoByID(int testID, ref int testAppointmentID, ref bool testResult, ref string notes, ref int createdByUserID)
        {
            bool isFound = false;

            string query = "SELECT * FROM Tests WHERE TestID = @TestID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestID", testID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                testAppointmentID = (int)reader["TestAppointmentID"];
                                testResult = (bool)reader["TestResult"];

                                notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                                createdByUserID = (int)reader["CreatedByUserID"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        isFound = false;
                    }
                }
            }

            return isFound;
        }


        public static DataTable GetAllTests()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Tests";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return dt;
        }

        public static bool GetLastTestByPersonAndTestTypeAndLicenseClass(
            int personID,
            int licenseClassID,
            int testTypeID,
            ref int testID,
            ref int testAppointmentID,
            ref bool testResult,
            ref string notes,
            ref int createdByUserID)
        {
            bool isFound = false;

            string query = @"SELECT TOP 1 
                        Tests.TestID, 
                        Tests.TestAppointmentID, 
                        Tests.TestResult, 
                        Tests.Notes, 
                        Tests.CreatedByUserID
                    FROM LocalDrivingLicenseApplications 
                    INNER JOIN Tests ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = Tests.TestAppointmentID -- أو جدول TestAppointments حسب ربط الداتا بيز عندك
                    INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                    INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                    WHERE (Applications.ApplicantPersonID = @PersonID) 
                      AND (LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID) 
                      AND (TestAppointments.TestTypeID = @TestTypeID)
                    ORDER BY Tests.TestAppointmentID DESC;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
                        command.Parameters.AddWithValue("@TestTypeID", testTypeID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                testID = Convert.ToInt32(reader["TestID"]);
                                testAppointmentID = Convert.ToInt32(reader["TestAppointmentID"]);
                                testResult = Convert.ToBoolean(reader["TestResult"]);
                                notes = reader["Notes"]?.ToString() ?? "";
                                createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return isFound;
        }

        public static int AddNewTest(int appointmentID, bool testResult, string notes, int createdByUserID)
        {
            int newTestID = -1;

            string query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                     VALUES (@AppointmentID, @TestResult, @Notes, @CreatedByUserID);

                     UPDATE TestAppointments
                     SET IsLocked = 1 WHERE TestAppointmentID = @AppointmentID;
                     
                     SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentID", appointmentID);
                        command.Parameters.AddWithValue("@TestResult", testResult);

                        if (string.IsNullOrEmpty(notes))
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Notes", notes);

                        command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            newTestID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return newTestID;
        }
        public static bool UpdateTest(int testID, int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE Tests
                    SET TestAppointmentID = @TestAppointmentID,
                        TestResult = @TestResult,
                        Notes = @Notes,
                        CreatedByUserID = @CreatedByUserID
                    WHERE TestID = @TestID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestID", testID);
                        command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                        command.Parameters.AddWithValue("@TestResult", testResult);

                        if (string.IsNullOrEmpty(notes))
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Notes", notes);

                        command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return (rowsAffected > 0);
        }

        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            byte PassedTestCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT TotalPassedTests = COUNT(TestAppointments.TestTypeID)
                    FROM Tests INNER JOIN
                         TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                    WHERE (TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                      AND (Tests.TestResult = 1)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte ptCount))
                {
                    PassedTestCount = ptCount;
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return PassedTestCount;
        }
    }
}
