using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DVLD_DataAccess
{
    public class clsLicenseData
    {
        public static bool GetLicenseInfoByID(int licenseID, ref int applicationID, ref int driverID, ref int licenseClass,
            ref DateTime issueDate, ref DateTime expirationDate, ref string notes,
            ref float paidFees, ref bool isActive, ref byte issueReason, ref int createdByUserID)
        {
            bool isFound = false;

            string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", licenseID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            applicationID = (int)reader["ApplicationID"];
                            driverID = (int)reader["DriverID"];
                            licenseClass = (int)reader["LicenseClass"];
                            issueDate = (DateTime)reader["IssueDate"];
                            expirationDate = (DateTime)reader["ExpirationDate"];

                            notes = reader["Notes"] == DBNull.Value ? "" : (string)reader["Notes"];
                            paidFees = Convert.ToSingle(reader["PaidFees"]);
                            isActive = (bool)reader["IsActive"];
                            issueReason = Convert.ToByte(reader["IssueReason"]);
                            createdByUserID = (int)reader["CreatedByUserID"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }

            return isFound;
        }

        public static DataTable GetAllLicenses()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Licenses";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Logging error
            }

            return dt;
        }

        public static DataTable GetDriverLicenses(int driverID)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT    
                               Licenses.LicenseID,
                               ApplicationID,
                               LicenseClasses.ClassName, 
                               Licenses.IssueDate, 
                               Licenses.ExpirationDate, 
                               Licenses.IsActive
                               FROM Licenses INNER JOIN
                                    LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
                               WHERE DriverID = @DriverID
                               ORDER BY IsActive DESC, ExpirationDate DESC";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverID", driverID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Logging error
            }

            return dt;
        }

        public static int AddNewLicense(int applicationID, int driverID, int licenseClass,
             DateTime issueDate, DateTime expirationDate, string notes,
             float paidFees, bool isActive, byte issueReason, int createdByUserID)
        {
            int licenseID = -1;

            string query = @"INSERT INTO Licenses
                               (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                             VALUES
                               (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    command.Parameters.AddWithValue("@DriverID", driverID);
                    command.Parameters.AddWithValue("@LicenseClass", licenseClass);
                    command.Parameters.AddWithValue("@IssueDate", issueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                    command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(notes) ? DBNull.Value : notes);
                    command.Parameters.AddWithValue("@PaidFees", paidFees);
                    command.Parameters.AddWithValue("@IsActive", isActive);
                    command.Parameters.AddWithValue("@IssueReason", issueReason);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        licenseID = insertedID;
                    }
                }
            }
            catch (Exception ex)
            {
                // Logging error
            }

            return licenseID;
        }

        public static bool UpdateLicense(int licenseID, int applicationID, int driverID, int licenseClass,
             DateTime issueDate, DateTime expirationDate, string notes,
             float paidFees, bool isActive, byte issueReason, int createdByUserID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE Licenses
                             SET ApplicationID = @ApplicationID, 
                                 DriverID = @DriverID,
                                 LicenseClass = @LicenseClass,
                                 IssueDate = @IssueDate,
                                 ExpirationDate = @ExpirationDate,
                                 Notes = @Notes,
                                 PaidFees = @PaidFees,
                                 IsActive = @IsActive,
                                 IssueReason = @IssueReason,
                                 CreatedByUserID = @CreatedByUserID
                             WHERE LicenseID = @LicenseID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", licenseID);
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    command.Parameters.AddWithValue("@DriverID", driverID);
                    command.Parameters.AddWithValue("@LicenseClass", licenseClass);
                    command.Parameters.AddWithValue("@IssueDate", issueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                    command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(notes) ? DBNull.Value : notes);
                    command.Parameters.AddWithValue("@PaidFees", paidFees);
                    command.Parameters.AddWithValue("@IsActive", isActive);
                    command.Parameters.AddWithValue("@IssueReason", issueReason);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return (rowsAffected > 0);
        }

        public static int GetActiveLicenseIDByPersonID(int personID, int licenseClassID)
        {
            int licenseID = -1;

            string query = @"SELECT TOP 1 Licenses.LicenseID
                             FROM Licenses INNER JOIN
                                  Drivers ON Licenses.DriverID = Drivers.DriverID
                             WHERE Licenses.LicenseClass = @LicenseClass 
                               AND Drivers.PersonID = @PersonID
                               AND IsActive = 1;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
                    command.Parameters.AddWithValue("@LicenseClass", licenseClassID);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int foundID))
                    {
                        licenseID = foundID;
                    }
                }
            }
            catch (Exception ex)
            {
                // Logging error
            }

            return licenseID;
        }

        public static bool DeactivateLicense(int licenseID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE Licenses
                             SET IsActive = 0
                             WHERE LicenseID = @LicenseID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", licenseID);

                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return (rowsAffected > 0);
        }
    }
}