using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DVLD_DataAccess
{
    public class clsLicensesClassesData
    {
        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM LicenseClasses";

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
                // Console.WriteLine(ex.ToString());
            }

            return dt;
        }

        public static bool GetLicenseClassInfoByID(int licenseClassID, ref string className, ref string classDescription, ref byte minimumAllowedAge, ref byte defaultValidityLength, ref decimal classFees)
        {
            bool isFound = false;
            string query = "SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            className = reader["ClassName"].ToString();
                            classDescription = reader["ClassDescription"] != DBNull.Value ? reader["ClassDescription"].ToString() : "";
                            minimumAllowedAge = Convert.ToByte(reader["MinimumAllowedAge"]);
                            defaultValidityLength = Convert.ToByte(reader["DefaultValidityLength"]);
                            classFees = Convert.ToDecimal(reader["ClassFees"]);

                            isFound = true;
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

        public static bool GetLicenseClassInfoByName(string className, ref int licenseClassID, ref string classDescription, ref byte minimumAllowedAge, ref byte defaultValidityLength, ref decimal classFees)
        {
            bool isFound = false;
            string query = "SELECT * FROM LicenseClasses WHERE ClassName = @ClassName";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClassName", className);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            licenseClassID = (int)reader["LicenseClassID"];
                            classDescription = reader["ClassDescription"] != DBNull.Value ? reader["ClassDescription"].ToString() : "";
                            minimumAllowedAge = Convert.ToByte(reader["MinimumAllowedAge"]);
                            defaultValidityLength = Convert.ToByte(reader["DefaultValidityLength"]);
                            classFees = Convert.ToDecimal(reader["ClassFees"]);

                            isFound = true;
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

        public static bool IsLicenseExistByPersonID(int personID, int licenseClassID)
        {
            bool isExists = false;

            string query = @"SELECT TOP 1 Found = 1 
                             FROM Licenses 
                             INNER JOIN Applications 
                             ON Licenses.ApplicationID = Applications.ApplicationID
                             WHERE Applications.ApplicantPersonID = @ApplicantPersonID 
                             AND Licenses.LicenseClass = @LicenseClass 
                             AND Licenses.IsActive = 1";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicantPersonID", personID);
                    command.Parameters.AddWithValue("@LicenseClass", licenseClassID);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        isExists = true;
                    }
                }
            }
            catch (Exception ex)
            {
                isExists = false;
            }

            return isExists;
        }
    }
}