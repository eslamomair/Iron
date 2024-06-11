using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_DataAccess
{
    public class clsPeoplesData
    {

        public static bool Find(int ID
            , ref string FirstName, ref string SecondName, ref string ThirdName,
            ref string LastName, ref string NationalN, ref string Phone,
            ref string ImagePath, ref string Email , ref string Address)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "Select * from People where ID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID", ID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    
                    Phone = (string)reader["Phone"];
                    if (reader["NationalN"] == System.DBNull.Value)
                    {
                        NationalN = "";
                    }
                    else
                        NationalN = (string)reader["NationalN"];

                    if (reader["Email"] == System.DBNull.Value)
                    {
                        Email = "";
                    }
                    else
                        Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    if (reader["ImagePath"] == System.DBNull.Value)
                    {
                        ImagePath = "";
                    }
                    else
                        ImagePath = (string)reader["ImagePath"];
                    IsFound = true;

                }
                reader.Close();
            }
            catch (Exception)
            {
                IsFound = false;
                throw;
            }
            finally
            { connection.Close(); }
            return IsFound;
        }

        public static bool Find( ref int ID
           , ref string FirstName, ref string SecondName, ref string ThirdName,
           ref string LastName, string NationalN, ref string Phone,
           ref string ImagePath, ref string Email, ref string Address)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "Select * from People where NationalN = @NationalN";

            SqlCommand command = new SqlCommand(Query, connection);

            if (NationalN != "")
            {
                command.Parameters.AddWithValue("@NationalN", NationalN);
            }
            else
                command.Parameters.AddWithValue("@NationalN", System.DBNull.Value);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int ) reader["ID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];

                    Phone = (string)reader["Phone"];
                   

                    if (reader["Email"] == System.DBNull.Value)
                    {
                        Email = "";
                    }
                    else
                        Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    if (reader["ImagePath"] == System.DBNull.Value)
                    {
                        ImagePath = "";
                    }
                    else
                        ImagePath = (string)reader["ImagePath"];
                    IsFound = true;

                }
                reader.Close();
            }
            catch (Exception)
            {
                IsFound = false;
                throw;
            }
            finally
            { connection.Close(); }
            return IsFound;
        }

        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName,
             string LastName, string NationalN, string Phone,
             string ImagePath, string Email, string Address)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"Insert INTO People (FirstName,SecondName,ThirdName,LastName,NationalN,Phone,ImagePath,Email,Address )
                                         VALUES (@FirstName,@SecondName,@ThirdName,@LastName,@NationalN,@Phone,@ImagePath,@Email,@Address)
                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);

            if (NationalN != "")
                command.Parameters.AddWithValue("@NationalN", NationalN);
            else
                command.Parameters.AddWithValue("@NationalN", System.DBNull.Value);


            command.Parameters.AddWithValue("@Phone", Phone);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);


            command.Parameters.AddWithValue("@Address", Address);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if ( Result!= null && int.TryParse(Result.ToString(),out int PersonID))
                {
                    ID = PersonID;
                }
            }
            catch (Exception)
            {

                ID = -1;
            }
            finally { connection.Close(); }
            return ID;
        }

        public static bool UpdatePerson(int PersonID ,string FirstName, string SecondName,
            string ThirdName,  string LastName, string NationalN, string Phone,
             string ImagePath, string Email, string Address)
        {
            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"Update People
                           Set FirstName = @FirstName,
                               SecondName = @SecondName,
                               ThirdName = @ThirdName,
                               LastName = @LastName,
                               NationalN = @NationalN,
                               Phone = @Phone,
                               ImagePath = @ImagePath,
                               Email = @Email,
                               Address = @Address
                               where ID = @PersonID; ";

            SqlCommand command  = new SqlCommand(Query,connection);

            command.Parameters.AddWithValue("@PersonID",PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);

            if (NationalN != "")
                command.Parameters.AddWithValue("@NationalN", NationalN);
            else
                command.Parameters.AddWithValue("@NationalN", System.DBNull.Value);


            command.Parameters.AddWithValue("@Phone", Phone);


            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);


            command.Parameters.AddWithValue("@Address", Address);
            try
            {
                connection.Open();
                RowsEffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                RowsEffected = 0;
            }
            finally { connection.Close(); }
            return (RowsEffected > 0);
        }

        public static bool DeletePerson(int PersonID)
        {
            int RowEffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "Delete People where ID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                RowEffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                RowEffected = 0;
            }
            finally { connection.Close(); }
            return (RowEffected > 0);
        }

        public static DataTable GetAllPeople()
        {
            DataTable result = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"Select * from People";

            SqlCommand command = new SqlCommand(Query,connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    result.Load(reader);
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public static bool IsPersonExist(int ID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "Select Found = 1 from People where ID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
               SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception)
            {

                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }


        public static bool IsPersonExist(string NationalN)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "Select Found = 1 from People where NationalN = @NationalN";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@NationalN", NationalN);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception)
            {

                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

    }
}
