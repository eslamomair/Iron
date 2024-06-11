using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_DataAccess
{
    public class clsSuppliers_Data
    {
        public static bool Find(int ID, ref int PersonID, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"Select * from Suppliers where ID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID", ID);

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

        public static bool FindPersonID(ref int ID, int PersonID, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"Select * from Suppliers where PersonID = @PersonID";

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

        public static int AddNewSuppliers(int PersonID, int CreatedByUserID)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"INSERT INTO Suppliers ( PersonID,   CreatedByUserID)
                            Values ( @PersonID, @CreatedByUserID) ;
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);
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

                ID = 0;
            }
            finally { connection.Close(); }
            return ID;
        }

        public static bool UpdateSuppliers(int ID, int PersonID, int CreatedByUserID)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);
            string Query = @"Update Suppliers
                            set PersonID = @PersonID,
                                CreatedByUserID = @CreatedByUserID
                                where ID = @ID;";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID", ID);

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

        public static DataTable GetAllSuppliers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "Select * from Suppliers";
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

        public static bool DeleteSuppliers(int ID)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "Delete Suppliers where ID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                RowEffected = command.ExecuteNonQuery();

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
            string query = @"Select Found = 1  from Suppliers where ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
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




        public static DataTable GetAllSuppliersWithInfoPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"select Suppliers.ID,Suppliers.PersonID,People.FirstName,People.SecondName , People.ThirdName , People.LastName
,People.NationalN ,People.Phone ,People.Email, People.Address , People.ImagePath  from People  
inner join Suppliers on
Suppliers.PersonID = People.ID;";
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





    }
}
