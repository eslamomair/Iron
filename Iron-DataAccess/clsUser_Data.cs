using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_DataAccess
{
    public class clsUser_Data
    {

        public static bool FindByUserID(int ID , ref int PersonID ,ref string UserName,
            ref string Password, ref DateTime DataCreated , ref bool IsActive)
        {

            bool IsFound = false;

            SqlConnection connection =new SqlConnection(clsDataAccessSettings.Connection);
            string Query = "Select * from Users where ID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    DataCreated = (DateTime)reader["DataCreated"];
                    IsActive = (bool)reader["IsActive"];
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

        public static bool FindByUserNameAPssword(ref int ID, ref int PersonID,  string UserName,
            string Password, ref DateTime DataCreated, ref bool IsActive)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);
            string Query = "Select * from Users where UserName = @UserName And Password = @Password";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    ID = (int)reader["ID"];
                    DataCreated = (DateTime)reader["DataCreated"];
                    UserName = (string)reader["UserName"];
                    Password  = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
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

        public static int AddNewUser(  int PersonID, string UserName,
            string Password,   DateTime DataCreated,   bool IsActive)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);
            string Query = @"INSERT INTO Users (   PersonID,  UserName,
             Password,    DataCreated,  IsActive ) 
              Values (@PersonID,  @UserName,  @Password, @DataCreated, @IsActive );
               SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@DataCreated", DataCreated);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();

                object Re = command.ExecuteScalar();

                if(Re != null && int.TryParse(Re.ToString(),out int ID))
                {
                    UserID = ID; 
                }

            }
            catch (Exception)
            {
                UserID = -1;
                throw;
            }
            finally
            { connection.Close(); }
            return UserID;
        }

        public static bool UpdateUser(int ID, int PersonID, string UserName,
            string Password, DateTime DataCreated, bool IsActive)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"Update Users 
                            SET   PersonID = @PersonID,
                                  UserName = @UserName,
                                  Password = @Password,
                               DataCreated = @DataCreated,
                                  IsActive = @IsActive
                                  WHERE ID = @ID;";

            SqlCommand command = new SqlCommand ( Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@DataCreated", DataCreated);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open ();
                RowEffected = command.ExecuteNonQuery();


            }
            catch (Exception)
            {
                RowEffected = 0; 
                throw;
            }
            finally { connection.Close(); }
            return (RowEffected > 0);
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);
            string Query = @"SELECT  Users.ID, Users.PersonID,
                            FullName = People.FirstName + ' ' + People.SecondName + ' ' + ISNULL( People.ThirdName,'') +' ' + People.LastName,
                             Users.UserName, Users.IsActive
                             FROM  Users INNER JOIN
                                    People ON Users.PersonID = People.ID";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open ();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
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
            return dt;
        }
        public static bool DeleteUser(int ID)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);
            string Query = "DELETE Users where ID = @ID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                RowEffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close() ;
            }
            return RowEffected > 0;
        }

        public static bool IsExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string query = "SELECT Found=1 FROM Users WHERE ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        //-----------------------------------------

        public static bool IsExist(string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsUserExistForPerson1ID(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string query = "SELECT Found=1 FROM Users WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

       
        public static bool ChangePassword(int UserID, string NewPassword)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string query = @"Update  Users  
                            set Password = @Password
                            where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }



    }
}
