using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DVLD_DataAccess
{
    public class clsUsersData
    {
        public static DataTable GetAllUesr()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT 
                                Users.UserID, 
                                Users.PersonID, 
                                CONCAT_WS(' ', People.FirstName, People.SecondName, People.ThirdName, People.LastName) AS FullName,
                                Users.UserName, 
                                Users.IsActive
                            FROM Users
                            INNER JOIN People ON Users.PersonID = People.PersonID";

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

        public static bool Delete(int UserID)
        {
            bool isDeleted = false;
            string query = @"DELETE FROM Users WHERE UserID = @UserID";

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    isDeleted = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return isDeleted;
        }

        public static int AddUser(int personID, string userName, string password, bool isActive)
        {
            int ussrID = -1;

            string query = @"INSERT INTO [dbo].[Users] 
                                ([PersonID], [UserName], [Password], [IsActive])
                             VALUES 
                                (@PersonID, @UserName, @Password, @IsActive);
                             SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@IsActive", isActive);

                    conn.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        ussrID = insertedID;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return ussrID;
        }

        public static bool UpdateUser(int userID, int personID, string userName, string password, bool isActive)
        {
            int rowsAffected = 0;

            string query = @"UPDATE [dbo].[Users]
                             SET [PersonID] = @PersonID,
                                 [UserName] = @UserName,
                                 [Password] = @Password,
                                 [IsActive] = @IsActive
                             WHERE UserID = @UserID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@PersonID", personID);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@IsActive", isActive);

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

        public static bool IsUserExistForPersonID(int personID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Users WHERE PersonID = @PersonID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        isFound = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                isFound = false;
            }

            return isFound;
        }

        public static bool GetUserByUserID(int userID, ref int personID, ref string userName, ref string password, ref bool isActive)
        {
            bool isFound = false;
            string query = @"SELECT * FROM Users WHERE UserID = @UserID";

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            personID = Convert.ToInt32(reader["PersonID"]);
                            userName = reader["UserName"].ToString();
                            password = reader["Password"].ToString();
                            isActive = Convert.ToBoolean(reader["IsActive"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                isFound = false;
            }

            return isFound;
        }

        public static bool IsUserExistByName(string userName)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        isFound = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                isFound = false;
            }

            return isFound;
        }

        public static bool GetUserByUsernameAndPassword(string userName, string password, ref int userID, ref int personID, ref bool isActive)
        {
            bool isFound = false;
            string query = @"SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password";

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            userID = Convert.ToInt32(reader["UserID"]);
                            personID = Convert.ToInt32(reader["PersonID"]);
                            isActive = Convert.ToBoolean(reader["IsActive"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                isFound = false;
            }

            return isFound;
        }
    }
}