using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsTestTypesData
    {
        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM TestTypes";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
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
                    catch (Exception ex)
                    {
                    }
                }
            }

            return dt;
        }

        public static bool GetTestTypeInfoByID(int testTypeID, ref string testTypeTitle, ref string testTypeDescription, ref decimal testTypeFees)
        {
            bool isFound = false;
            string query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", testTypeID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                testTypeTitle = (string)reader["TestTypeTitle"];
                                testTypeDescription = (string)reader["TestTypeDescription"];
                                testTypeFees = (decimal)reader["TestTypeFees"];
                            }
                            else
                            {
                                isFound = false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                    }
                }
            }

            return isFound;
        }

        public static bool UpdateTestType(int testTypeID, string testTypeTitle, string testTypeDescription, decimal testTypeFees)
        {
            int rowsAffected = 0;
            string query = @"UPDATE TestTypes 
                             SET TestTypeTitle = @TestTypeTitle,                    
                                 TestTypeDescription = @TestTypeDescription,
                                 TestTypeFees = @TestTypeFees                
                             WHERE TestTypeID = @TestTypeID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", testTypeID);
                    command.Parameters.AddWithValue("@TestTypeTitle", testTypeTitle);
                    command.Parameters.AddWithValue("@TestTypeDescription", testTypeDescription);
                    command.Parameters.AddWithValue("@TestTypeFees", testTypeFees);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }

            return (rowsAffected > 0);
        }
    }
}