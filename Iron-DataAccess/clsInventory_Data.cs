using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_DataAccess
{
    public class clsInventory_Data
    {
        public static bool GetRowInfoByID(int ID, ref int SubcategoryID, ref decimal Thickness, ref decimal Weight, ref decimal Width, ref decimal Quantity, ref decimal Price, ref DateTime DateIn, ref DateTime DateOut, ref int CategoryID, ref int CreatedByUserID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT * FROM Inventory WHERE ID = @ID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    SubcategoryID = (int)Reader["SubcategoryID"];
                    Thickness = (decimal)Reader["Thickness"];
                    Weight = (decimal)Reader["Weight"];
                    Width = (decimal)Reader["Width"];
                    Quantity = (decimal)Reader["Quantity"];
                    Price = (decimal)Reader["Price"];
                    DateIn = (DateTime)Reader["DateIn"];
                    DateOut = (DateTime)Reader["DateOut"];
                    CategoryID = (int)Reader["CategoryID"];
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


        public static bool GetRowInfoBySubcategoryID(ref int ID, int SubcategoryID, ref decimal Thickness, ref decimal Weight, ref decimal Width, ref decimal Quantity, ref decimal Price, ref DateTime DateIn, ref DateTime DateOut, ref int CategoryID, ref int CreatedByUserID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT * FROM Inventory WHERE SubcategoryID = @SubcategoryID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@SubcategoryID", SubcategoryID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    ID = (int)Reader["ID"];
                    Thickness = (decimal)Reader["Thickness"];
                    Weight = (decimal)Reader["Weight"];
                    Width = (decimal)Reader["Width"];
                    Quantity = (decimal)Reader["Quantity"];
                    Price = (decimal)Reader["Price"];
                    DateIn = (DateTime)Reader["DateIn"];
                    DateOut = (DateTime)Reader["DateOut"];
                    CategoryID = (int)Reader["CategoryID"];
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


        public static bool GetRowInfoByThickness(ref int ID, ref int SubcategoryID, decimal Thickness, ref decimal Weight, ref decimal Width, ref decimal Quantity, ref decimal Price, ref DateTime DateIn, ref DateTime DateOut, ref int CategoryID, ref int CreatedByUserID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT * FROM Inventory WHERE Thickness = @Thickness";

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
                    SubcategoryID = (int)Reader["SubcategoryID"];
                    Weight = (decimal)Reader["Weight"];
                    Width = (decimal)Reader["Width"];
                    Quantity = (decimal)Reader["Quantity"];
                    Price = (decimal)Reader["Price"];
                    DateIn = (DateTime)Reader["DateIn"];
                    DateOut = (DateTime)Reader["DateOut"];
                    CategoryID = (int)Reader["CategoryID"];
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


        public static bool GetRowInfoByCategoryID(ref int ID, ref int SubcategoryID, ref decimal Thickness, ref decimal Weight, ref decimal Width, ref decimal Quantity, ref decimal Price, ref DateTime DateIn, ref DateTime DateOut, int CategoryID, ref int CreatedByUserID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT * FROM Inventory WHERE CategoryID = @CategoryID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@CategoryID", CategoryID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    ID = (int)Reader["ID"];
                    SubcategoryID = (int)Reader["SubcategoryID"];
                    Thickness = (decimal)Reader["Thickness"];
                    Weight = (decimal)Reader["Weight"];
                    Width = (decimal)Reader["Width"];
                    Quantity = (decimal)Reader["Quantity"];
                    Price = (decimal)Reader["Price"];
                    DateIn = (DateTime)Reader["DateIn"];
                    DateOut = (DateTime)Reader["DateOut"];
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


        public static int AddNewRow(int SubcategoryID, decimal Thickness, decimal Weight, decimal Width, decimal Quantity, decimal Price, DateTime DateIn, DateTime DateOut, int CategoryID, int CreatedByUserID)
        {

            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"INSERT INTO Inventory 
                               (SubcategoryID, Thickness, Weight, Width, Quantity, Price, DateIn, DateOut, CategoryID, CreatedByUserID)     
                             VALUES
                               (@SubcategoryID, @Thickness, @Weight, @Width, @Quantity, @Price, @DateIn, @DateOut, @CategoryID, @CreatedByUserID)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@SubcategoryID", SubcategoryID);
            Command.Parameters.AddWithValue("@Thickness", Thickness);
            Command.Parameters.AddWithValue("@Weight", Weight);
            Command.Parameters.AddWithValue("@Width", Width);
            Command.Parameters.AddWithValue("@Quantity", Quantity);
            Command.Parameters.AddWithValue("@Price", Price);
            Command.Parameters.AddWithValue("@DateIn", DateIn);
            Command.Parameters.AddWithValue("@DateOut", DateOut);
            Command.Parameters.AddWithValue("@CategoryID", CategoryID);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


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
        public static bool UpdateRow(int ID, int SubcategoryID, decimal Thickness, decimal Weight, decimal Width, decimal Quantity, decimal Price, DateTime DateIn, DateTime DateOut, int CategoryID, int CreatedByUserID)
        {

            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = $@"UPDATE Inventory SET 
		SubcategoryID = @SubcategoryID,
		Thickness = @Thickness,
		Weight = @Weight,
		Width = @Width,
		Quantity = @Quantity,
		Price = @Price,
		DateIn = @DateIn,
		DateOut = @DateOut,
		CategoryID = @CategoryID,
		CreatedByUserID = @CreatedByUserID
		 WHERE ID = @ID
";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@SubcategoryID", SubcategoryID);
            Command.Parameters.AddWithValue("@Thickness", Thickness);
            Command.Parameters.AddWithValue("@Weight", Weight);
            Command.Parameters.AddWithValue("@Width", Width);
            Command.Parameters.AddWithValue("@Quantity", Quantity);
            Command.Parameters.AddWithValue("@Price", Price);
            Command.Parameters.AddWithValue("@DateIn", DateIn);
            Command.Parameters.AddWithValue("@DateOut", DateOut);
            Command.Parameters.AddWithValue("@CategoryID", CategoryID);
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

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"SELECT * FROM Inventory";

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

            string Query = "SELECT Count(*) FROM Inventory WHERE ID is not null";

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

            string connectionString = "Server=.;Database=IronSteel;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "DELETE Inventory WHERE ID = @ID";

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

            string Query = "SELECT Found=1 FROM Inventory WHERE ID = @ID";

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
