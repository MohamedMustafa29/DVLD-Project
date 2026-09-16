using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DVLD_DataAccess
{
    public class clsApplicationTypesData
    {
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM ApplicationTypes ORDER BY ApplicationTypeID";

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
                Console.WriteLine(ex.ToString());
            }

            return dt;
        }

        public static bool UpdateApplicationType(int applicationTypeID, string applicationTypeTitle, decimal applicationFees)
        {
            int rowsAffected = 0;

            string query = @"UPDATE ApplicationTypes 
                             SET ApplicationTypeTitle = @ApplicationTypeTitle,                    
                                 ApplicationFees = @ApplicationFees                
                             WHERE ApplicationTypeID = @ApplicationTypeID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                    command.Parameters.AddWithValue("@ApplicationTypeTitle", applicationTypeTitle);
                    command.Parameters.AddWithValue("@ApplicationFees", applicationFees);

                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }

            return (rowsAffected > 0);
        }

        public static bool GetApplicationTypeInfoByID(int applicationTypeID, ref string applicationTypeTitle, ref decimal applicationFees)
        {
            bool isFound = false;

            string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            applicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                            applicationFees = (decimal)reader["ApplicationFees"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }

            return isFound;
        }
    }
}