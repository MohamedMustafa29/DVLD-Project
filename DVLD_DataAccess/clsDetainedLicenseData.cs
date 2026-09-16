using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DVLD_DataAccess
{
    public class clsDetainedLicenseData
    {
        public static bool GetDetainedLicenseInfoByID(int detainID,
            ref int licenseID, ref DateTime detainDate,
            ref float fineFees, ref int createdByUserID,
            ref bool isReleased, ref DateTime releaseDate,
            ref int releasedByUserID, ref int releaseApplicationID)
        {
            bool isFound = false;
            string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DetainID", detainID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            licenseID = (int)reader["LicenseID"];
                            detainDate = (DateTime)reader["DetainDate"];
                            fineFees = Convert.ToSingle(reader["FineFees"]);
                            createdByUserID = (int)reader["CreatedByUserID"];
                            isReleased = (bool)reader["IsReleased"];

                            releaseDate = (reader["ReleaseDate"] == DBNull.Value) ? DateTime.MaxValue : (DateTime)reader["ReleaseDate"];
                            releasedByUserID = (reader["ReleasedByUserID"] == DBNull.Value) ? -1 : (int)reader["ReleasedByUserID"];
                            releaseApplicationID = (reader["ReleaseApplicationID"] == DBNull.Value) ? -1 : (int)reader["ReleaseApplicationID"];
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

        public static bool GetDetainedLicenseInfoByLicenseID(int licenseID,
            ref int detainID, ref DateTime detainDate,
            ref float fineFees, ref int createdByUserID,
            ref bool isReleased, ref DateTime releaseDate,
            ref int releasedByUserID, ref int releaseApplicationID)
        {
            bool isFound = false;
            string query = "SELECT TOP 1 * FROM DetainedLicenses WHERE LicenseID = @LicenseID ORDER BY DetainID DESC";

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

                            detainID = (int)reader["DetainID"];
                            detainDate = (DateTime)reader["DetainDate"];
                            fineFees = Convert.ToSingle(reader["FineFees"]);
                            createdByUserID = (int)reader["CreatedByUserID"];
                            isReleased = (bool)reader["IsReleased"];

                            releaseDate = (reader["ReleaseDate"] == DBNull.Value) ? DateTime.MaxValue : (DateTime)reader["ReleaseDate"];
                            releasedByUserID = (reader["ReleasedByUserID"] == DBNull.Value) ? -1 : (int)reader["ReleasedByUserID"];
                            releaseApplicationID = (reader["ReleaseApplicationID"] == DBNull.Value) ? -1 : (int)reader["ReleaseApplicationID"];
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

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM DetainedLicenses_View ORDER BY IsReleased, DetainID;";

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

        public static int AddNewDetainedLicense(int licenseID, DateTime detainDate, float fineFees, int createdByUserID)
        {
            int detainID = -1;

            string query = @"INSERT INTO dbo.DetainedLicenses 
                            (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased) 
                            VALUES 
                            (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, 0); 
                            SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", licenseID);
                    command.Parameters.AddWithValue("@DetainDate", detainDate);
                    command.Parameters.AddWithValue("@FineFees", fineFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        detainID = insertedID;
                    }
                }
            }
            catch (Exception ex)
            {
                // Logging error
            }

            return detainID;
        }

        public static bool UpdateDetainedLicense(int detainID, int licenseID, DateTime detainDate, float fineFees, int createdByUserID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE dbo.DetainedLicenses 
                            SET LicenseID = @LicenseID, 
                                DetainDate = @DetainDate, 
                                FineFees = @FineFees, 
                                CreatedByUserID = @CreatedByUserID 
                            WHERE DetainID = @DetainID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DetainID", detainID);
                    command.Parameters.AddWithValue("@LicenseID", licenseID);
                    command.Parameters.AddWithValue("@DetainDate", detainDate);
                    command.Parameters.AddWithValue("@FineFees", fineFees);
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

        public static bool ReleaseDetainedLicense(int detainID, int releasedByUserID, int releaseApplicationID)
        {
            int rowsAffected = 0;

            // تم الاعتماد على GETDATE() من SQL مباشرة
            string query = @"UPDATE dbo.DetainedLicenses 
                            SET IsReleased = 1, 
                                ReleaseDate = GETDATE(), 
                                ReleaseApplicationID = @ReleaseApplicationID,
                                ReleasedByUserID = @ReleasedByUserID
                            WHERE DetainID = @DetainID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DetainID", detainID);
                    command.Parameters.AddWithValue("@ReleasedByUserID", releasedByUserID);
                    command.Parameters.AddWithValue("@ReleaseApplicationID", releaseApplicationID);

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

        public static bool IsLicenseDetained(int licenseID)
        {
            bool isDetained = false;

            string query = @"SELECT TOP 1 1 
                            FROM DetainedLicenses 
                            WHERE LicenseID = @LicenseID 
                            AND IsReleased = 0;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", licenseID);
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        isDetained = true;
                    }
                }
            }
            catch (Exception ex)
            {
                isDetained = false;
            }

            return isDetained;
        }
    }
}