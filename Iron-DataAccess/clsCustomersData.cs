using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Iron_DataAccess
{
    public  class clsCustomersData
    {
        public static bool Find(int ID , ref int PersonID, ref int CreatedByUserID )
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"Select * from Customers where ID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID" , ID );

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsFound = true;
                }
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

        public static bool FindByPersonID(ref int ID,   int PersonID, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"Select * from Customers where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["ID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsFound = true;
                }
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

        public static int AddNewCustomer(int PersonID,  int CreatedByUserID)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"INSERT INTO Customers ( PersonID,   CreatedByUserID)
                            Values ( @PersonID, @CreatedByUserID) ;
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int CID))
                {
                    ID = CID;
                }
            }
            catch (Exception)
            {

                ID = -1;
            }
            finally { connection.Close(); }
            return ID;
        }

        public static bool UpdateCustomer(int ID, int PersonID, int CreatedByUserID)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);
            string Query = @"Update Customers
                            set PersonID = @PersonID,
                                CreatedByUserID = @CreatedByUserID
                                where ID = @ID;";
            SqlCommand command = new SqlCommand (Query,connection);

            command.Parameters.AddWithValue("@ID",ID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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
            return RowEffected > 0;
        }

        public static DataTable GetAllCustomers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection (clsDataAccessSettings.Connection);

            string Query = "Select * from Customers";
            SqlCommand command = new SqlCommand(Query,connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }



        public static DataTable GetAllCustomersWithInfoPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"select  Customers.ID,Customers.PersonID,People.FirstName,People.SecondName , People.ThirdName , People.LastName
,People.NationalN ,People.Phone ,People.Email, People.Address , People.ImagePath  from People  
inner join Customers on
Customers.PersonID = People.ID;";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }







        public static bool DeleteCustomer(int ID)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "Delete Customers where ID = @ID";

            SqlCommand command = new SqlCommand(Query,connection);

            command.Parameters.AddWithValue("@ID",ID);

            try
            {
                connection.Open();

                RowEffected  = command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
            return (RowEffected > 0);
        }

        public static bool IstExist(int ID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);
            string query = @"Select Found = 1  from Customers where ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID" , ID);
            try
            {
                SqlDataReader reader = command.ExecuteReader();

                IsFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound; 
        }
    }
}
