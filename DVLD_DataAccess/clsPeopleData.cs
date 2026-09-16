using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DVLD_DataAccess
{
    public class clsPeopleData
    {
        public static DataTable Getallcontacts()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT People.PersonID, People.NationalNo,
                            People.FirstName, People.SecondName, People.ThirdName, People.LastName,
                            People.DateOfBirth, People.Gendor, 
                                    CASE
                                    WHEN People.Gendor = 0 THEN 'Male'
                                    ELSE 'Female'
                                    END as GendorCaption ,
                            People.Address, People.Phone, People.Email,
                            People.NationalityCountryID, Countries.CountryName, People.ImagePath
                            FROM People INNER JOIN
                           Countries ON People.NationalityCountryID = Countries.CountryID
                           ORDER BY People.FirstName";

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

        public static bool GetPersonByPersonID(int personID, ref string nationalNo, ref string firstName, ref string secondName, ref string thirdName,
            ref string lastName, ref DateTime dateOfBirth, ref byte gender, ref string address,
            ref string phone, ref string email, ref int nationalityCountryID, ref string imagePath)
        {
            bool isFound = false;
            string query = @"SELECT * FROM People WHERE PersonID = @PersonID";

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);

                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            nationalNo = reader["NationalNo"].ToString();
                            firstName = reader["FirstName"].ToString();
                            secondName = reader["SecondName"].ToString();
                            lastName = reader["LastName"].ToString();
                            dateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                            gender = Convert.ToByte(reader["Gendor"]);
                            address = reader["Address"].ToString();
                            phone = reader["Phone"].ToString();
                            nationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);

                            thirdName = reader["ThirdName"] != DBNull.Value ? reader["ThirdName"].ToString() : string.Empty;
                            email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty;
                            imagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : string.Empty;
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

        public static bool GetPersonByNationalNo(string nationalNo, ref int personID, ref string firstName, ref string secondName, ref string thirdName,
         ref string lastName, ref DateTime dateOfBirth, ref byte gender, ref string address,
         ref string phone, ref string email, ref int nationalityCountryID, ref string imagePath)
        {
            bool isFound = false;
            string query = @"SELECT * FROM People WHERE NationalNo = @NationalNo";

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@NationalNo", nationalNo);

                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            personID = Convert.ToInt32(reader["PersonID"]);
                            firstName = reader["FirstName"].ToString();
                            secondName = reader["SecondName"].ToString();
                            lastName = reader["LastName"].ToString();
                            dateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                            gender = Convert.ToByte(reader["Gendor"]);
                            address = reader["Address"].ToString();
                            phone = reader["Phone"].ToString();
                            nationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);

                            thirdName = reader["ThirdName"] != DBNull.Value ? reader["ThirdName"].ToString() : string.Empty;
                            email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty;
                            imagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : string.Empty;
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

        public static bool Delete(int personID)
        {
            bool isDeleted = false;
            string query = @"DELETE FROM People WHERE PersonID = @PersonID";

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);

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

        public static int AddPerson(string nationalNo, string firstName, string secondName, string thirdName,
             string lastName, DateTime dateOfBirth, byte gender, string address,
             string phone, string email, int nationalityCountryID, string imagePath)
        {
            int personID = -1;

            string query = @"INSERT INTO People (
                                NationalNo, FirstName, SecondName, ThirdName, LastName, 
                                DateOfBirth, Gendor, Address, Phone, Email, 
                                NationalityCountryID, ImagePath)
                             VALUES (
                                @NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, 
                                @DateOfBirth, @Gendor, @Address, @Phone, @Email, 
                                @NationalityCountryID, @ImagePath);
                             SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@NationalNo", nationalNo);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@SecondName", secondName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@Gendor", gender);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);

                    command.Parameters.AddWithValue("@ThirdName", (object)thirdName ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Email", (object)email ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ImagePath", (object)imagePath ?? DBNull.Value);

                    conn.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        personID = insertedID;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return personID;
        }

        public static bool UpdatePerson(int personID, string nationalNo, string firstName, string secondName, string thirdName,
            string lastName, DateTime dateOfBirth, byte gender, string address,
            string phone, string email, int nationalityCountryID, string imagePath)
        {
            int rowsAffected = 0;

            string query = @"UPDATE People 
                             SET NationalNo = @NationalNo,
                                 FirstName = @FirstName,
                                 SecondName = @SecondName,
                                 ThirdName = @ThirdName,
                                 LastName = @LastName,
                                 DateOfBirth = @DateOfBirth,
                                 Gendor = @Gendor,
                                 Address = @Address,
                                 Phone = @Phone,
                                 Email = @Email,
                                 NationalityCountryID = @NationalityCountryID,
                                 ImagePath = @ImagePath
                             WHERE PersonID = @PersonID";

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
                    command.Parameters.AddWithValue("@NationalNo", nationalNo);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@SecondName", secondName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@Gendor", gender);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);

                    command.Parameters.AddWithValue("@ThirdName", (object)thirdName ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Email", (object)email ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ImagePath", (object)imagePath ?? DBNull.Value);

                    conn.Open();
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

        public static bool IsPersonExist(string nationalNo)
        {
            bool exists = false;
            string query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", nationalNo);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    exists = (result != null);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return exists;
        }

        public static bool IsPersonExist(int personID)
        {
            bool exists = false;
            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    exists = (result != null);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return exists;
        }
    }
}