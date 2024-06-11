using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_DataAccess
{
    public class clsNewInventory_Data
    {
        public static bool GetRowInfoByIDInventory(int IDInventory, ref int SubCategoryID, ref decimal Quantity, ref decimal Price, ref decimal UnitPrice, ref int CreatedByUserID)
        {

            bool IsFound = false;

            string connectionString = "Server=.;Database=IronSteel;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT * FROM NewInventory WHERE IDInventory = @IDInventory";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@IDInventory", IDInventory);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    SubCategoryID = (int)Reader["SubCategoryID"];
                    Quantity = (decimal)Reader["Quantity"];
                    Price = (decimal)Reader["Price"];
                    UnitPrice = (decimal)Reader["UnitPrice"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];


                }

                Reader.Close();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;


        }


        public static bool GetRowInfoBySubCategoryID(ref int IDInventory, int SubCategoryID, ref decimal Quantity, ref decimal Price, ref decimal UnitPrice, ref int CreatedByUserID)
        {

            bool IsFound = false;

            string connectionString = "Server=.;Database=IronSteel;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT * FROM NewInventory WHERE SubCategoryID = @SubCategoryID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@SubCategoryID", SubCategoryID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    IDInventory = (int)Reader["IDInventory"];
                    Quantity = (decimal)Reader["Quantity"];
                    Price = (decimal)Reader["Price"];
                    UnitPrice = (decimal)Reader["UnitPrice"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];


                }

                Reader.Close();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;


        }


        public static int AddNewRow(int SubCategoryID, decimal Quantity, decimal Price, decimal UnitPrice, int CreatedByUserID)
        {

            int IDInventory = -1;

            string connectionString = "Server=.;Database=IronSteel;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = @"INSERT INTO NewInventory 
                               (SubCategoryID, Quantity, Price, UnitPrice, CreatedByUserID)     
                             VALUES
                               (@SubCategoryID, @Quantity, @Price, @UnitPrice, @CreatedByUserID)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@SubCategoryID", SubCategoryID);
            Command.Parameters.AddWithValue("@Quantity", Quantity);
            Command.Parameters.AddWithValue("@Price", Price);
            Command.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    IDInventory = InsertedID;
                }

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }


            return IDInventory;

        }
        public static bool UpdateRow(int IDInventory, int SubCategoryID, decimal Quantity, decimal Price, decimal UnitPrice, int CreatedByUserID)
        {

            int RowsAffected = 0;

            string connectionString = "Server=.;Database=IronSteel;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = $@"UPDATE NewInventory SET 
		SubCategoryID = @SubCategoryID,
		Quantity = @Quantity,
		Price = @Price,
		UnitPrice = @UnitPrice,
		CreatedByUserID = @CreatedByUserID
		 WHERE IDInventory = @IDInventory
";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@IDInventory", IDInventory);
            Command.Parameters.AddWithValue("@SubCategoryID", SubCategoryID);
            Command.Parameters.AddWithValue("@Quantity", Quantity);
            Command.Parameters.AddWithValue("@Price", Price);
            Command.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);

        }

        public static DataTable GetAllRows()
        {

            DataTable DT = new DataTable();

            string connectionString = "Server=.;Database=IronSteel;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = @"SELECT * FROM NewInventory";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.HasRows)
                {
                    DT.Load(Reader);
                }

                Reader.Close();


            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return DT;

        }

        public static int GetNumberOfRows()
        {
            int NumberOfRows = -1;

            string connectionString = "Server=.;Database=IronSteel;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT Count(*) FROM NewInventory WHERE IDInventory is not null";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNum))
                {
                    NumberOfRows = AcualNum;
                }


            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return NumberOfRows;
        }

        public static bool DeleteRow(int IDInventory)
        {

            int RowsAffected = 0;

            string connectionString = "Server=.;Database=IronSteel;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "DELETE NewInventory WHERE IDInventory = @IDInventory";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@IDInventory", IDInventory);


            try
            {
                connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);

        }



        public static bool DoesRowExist(int IDInventory)
        {
            bool IsFound = false;

            string connectionString = "Server=.;Database=IronSteel;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT Found=1 FROM NewInventory WHERE IDInventory = @IDInventory";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@IDInventory", IDInventory);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    IsFound = true;
                }

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

    }
}
