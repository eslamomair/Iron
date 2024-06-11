using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_DataAccess
{
    public class Purchases_Data
    {
        public static bool GetRowInfoByID(int ID, ref decimal Thickness, ref decimal Weight, ref decimal Width, ref decimal Quantity, ref decimal Price, ref DateTime DateOfPurchase, ref int SupplierID, ref int SubCategoriesID, ref int CategoryID, ref int CreatedByUserID, ref int NewInventoryID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT * FROM Purchases WHERE ID = @ID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    Thickness = (decimal)Reader["Thickness"];
                    Weight = (decimal)Reader["Weight"];
                    Width = (decimal)Reader["Width"];
                    Quantity = (decimal)Reader["Quantity"];
                    Price = (decimal)Reader["Price"];
                    DateOfPurchase = (DateTime)Reader["DateOfPurchase"];
                    SupplierID = (int)Reader["SupplierID"];
                    SubCategoriesID = (int)Reader["SubCategoriesID"];
                    CategoryID = (int)Reader["CategoryID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    NewInventoryID = (int)Reader["NewInventoryID"];

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


        public static bool GetRowInfoByThickness(ref int ID, decimal Thickness, ref decimal Weight, ref decimal Width, ref decimal Quantity, ref decimal Price, ref DateTime DateOfPurchase, ref int SupplierID, ref int SubCategoriesID, ref int CategoryID, ref int CreatedByUserID, ref int NewInventoryID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT * FROM Purchases WHERE Thickness = @Thickness";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@Thickness", Thickness);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    ID = (int)Reader["ID"];
                    Weight = (decimal)Reader["Weight"];
                    Width = (decimal)Reader["Width"];
                    Quantity = (decimal)Reader["Quantity"];
                    Price = (decimal)Reader["Price"];
                    DateOfPurchase = (DateTime)Reader["DateOfPurchase"];
                    SupplierID = (int)Reader["SupplierID"];
                    SubCategoriesID = (int)Reader["SubCategoriesID"];
                    CategoryID = (int)Reader["CategoryID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    NewInventoryID = (int)Reader["NewInventoryID"];

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


        public static bool GetRowInfoByWeight(ref int ID, ref decimal Thickness, decimal Weight, ref decimal Width, ref decimal Quantity, ref decimal Price, ref DateTime DateOfPurchase, ref int SupplierID, ref int SubCategoriesID, ref int CategoryID, ref int CreatedByUserID, ref int NewInventoryID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT * FROM Purchases WHERE Weight = @Weight";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@Weight", Weight);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    ID = (int)Reader["ID"];
                    Thickness = (decimal)Reader["Thickness"];
                    Width = (decimal)Reader["Width"];
                    Quantity = (decimal)Reader["Quantity"];
                    Price = (decimal)Reader["Price"];
                    DateOfPurchase = (DateTime)Reader["DateOfPurchase"];
                    SupplierID = (int)Reader["SupplierID"];
                    SubCategoriesID = (int)Reader["SubCategoriesID"];
                    CategoryID = (int)Reader["CategoryID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    NewInventoryID = (int)Reader["NewInventoryID"];

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


        public static int AddNewRow(decimal Thickness, decimal Weight, decimal Width, decimal Quantity, decimal Price, DateTime DateOfPurchase, int SupplierID, int SubCategoriesID, int CategoryID, int CreatedByUserID, int NewInventoryID)
        {

            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"INSERT INTO Purchases 
                               (Thickness, Weight, Width, Quantity, Price, DateOfPurchase, SupplierID, SubCategoriesID, CategoryID, CreatedByUserID,NewInventoryID)     
                             VALUES
                               (@Thickness, @Weight, @Width, @Quantity, @Price, @DateOfPurchase, @SupplierID, @SubCategoriesID, @CategoryID, @CreatedByUserID,@NewInventoryID)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@Thickness", Thickness);
            Command.Parameters.AddWithValue("@Weight", Weight);
            Command.Parameters.AddWithValue("@Width", Width);
            Command.Parameters.AddWithValue("@Quantity", Quantity);
            Command.Parameters.AddWithValue("@Price", Price);
            Command.Parameters.AddWithValue("@DateOfPurchase", DateOfPurchase);
            Command.Parameters.AddWithValue("@SupplierID", SupplierID);
            Command.Parameters.AddWithValue("@SubCategoriesID", SubCategoriesID);
            Command.Parameters.AddWithValue("@CategoryID", CategoryID);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@NewInventoryID", NewInventoryID);


            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    ID = InsertedID;
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


            return ID;

        }
        public static bool UpdateRow(int ID, decimal Thickness, decimal Weight, decimal Width, decimal Quantity, decimal Price, DateTime DateOfPurchase, int SupplierID, int SubCategoriesID, int CategoryID, int CreatedByUserID, int NewInventoryID)
        {

            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = $@"UPDATE Purchases SET 
		Thickness = @Thickness,
		Weight = @Weight,
		Width = @Width,
		Quantity = @Quantity,
		Price = @Price,
		DateOfPurchase = @DateOfPurchase,
		SupplierID = @SupplierID,
		SubCategoriesID = @SubCategoriesID,
		CategoryID = @CategoryID,
		CreatedByUserID = @CreatedByUserID,
        NewInventoryID = @NewInventoryID
		 WHERE ID = @ID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@Thickness", Thickness);
            Command.Parameters.AddWithValue("@Weight", Weight);
            Command.Parameters.AddWithValue("@Width", Width);
            Command.Parameters.AddWithValue("@Quantity", Quantity);
            Command.Parameters.AddWithValue("@Price", Price);
            Command.Parameters.AddWithValue("@DateOfPurchase", DateOfPurchase);
            Command.Parameters.AddWithValue("@SupplierID", SupplierID);
            Command.Parameters.AddWithValue("@SubCategoriesID", SubCategoriesID);
            Command.Parameters.AddWithValue("@CategoryID", CategoryID);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@NewInventoryID", NewInventoryID);


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

        public static DataTable GetAllPurchases()
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT * from ViewAllPurchases ";
            
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
            return table;
        }


        public static DataTable GetAllRows()
        {

            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"SELECT * FROM Purchases";

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

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT Count(*) FROM Purchases WHERE ID is not null";

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

        public static bool DeleteRow(int ID)
        {

            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "DELETE Purchases WHERE ID = @ID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ID", ID);


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



        public static bool DoesRowExist(int ID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT Found=1 FROM Purchases WHERE ID = @ID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ID", ID);


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
