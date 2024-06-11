using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_DataAccess
{
    public class clsCategory_Data
    {
        public static bool Find(int ID, ref string ItemsType, ref string Description)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);
            string Query = "Select * from Category where ID = @ID";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["ID"];
                    if (reader["Description"] != System.DBNull.Value)
                    {
                        Description = (string)reader["Description"];
                    }
                    else
                    Description = "";
                    ItemsType = (string)reader["ItemsType"];
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

        public static bool Find(ref int ID, string ItemsType, ref string Description)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);
            string Query = "Select * from Category where ItemsType = @ItemsType";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ItemsType", ItemsType);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["ID"];
                    if (reader["Description"] != System.DBNull.Value)
                    {
                        Description = (string)reader["Description"];
                    }
                    else
                        Description = "";
                    ItemsType = (string)reader["ItemsType"];
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
            {
                connection.Close();
            }
            return IsFound;
        }

        public static int AddNewCategory(string ItemsType, string Description)
        {
            int IDC = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);
            string Query = @"INSERT INTO Category 
                            (ItemsType,  Description)
                         VALUES (@ItemsType,  @Description);
                           SELECT SCOPE_IDENTITY(); ";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ItemsType", ItemsType);
            if (Description != "")
            {
                command.Parameters.AddWithValue("@Description", Description);
            }
            else
                command.Parameters.AddWithValue("@Description", System.DBNull.Value);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int CID))
                {

                    IDC = CID;
                }
            }
            catch (Exception)
            {
                IDC = -1;
                throw;
            }
            finally
            {
                connection.Close();
            }
            return IDC;
        }

        public static bool UpdateCategory(int ID, string ItemsType, string Description)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);
            string Query = @"Update Category 
                           set  ItemsType = @ItemsType, 
                                Description= @Description
                          where ID = @ID";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ItemsType", ItemsType);
            command.Parameters.AddWithValue("@ID", ID);
            if (Description != "")
            {
                command.Parameters.AddWithValue("@Description", Description);
            }
            else
                command.Parameters.AddWithValue("@Description", System.DBNull.Value);

            try
            {
                connection.Open();
                RowEffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                RowEffected = 0;
                throw;
            }
            finally
            {
                connection.Close();
            }
            return RowEffected > 0;
        }

        public static DataTable GetAllCategory()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);
            string Query = @"select * from Category";
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

                throw;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool DeleteCategory(int ID)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);
            string Query = "Delete  Category where ID  = @ID";
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
                throw;
            }
            finally
            {
                connection.Close();
            }
            return RowEffected > 0;
        }


        public static bool IsCategoryExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string query = "SELECT Found=1 FROM Category WHERE ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception)
            {
                isFound = false;
                throw;
            }
            finally
            {
                connection.Close();
            }
           return isFound;
        }
    }
}
