using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_DataAccess
{
    public class clsSubCategories_Data
    {

        public static bool GetRowInfoByID(int ID, ref string Type, ref decimal Thickness, ref decimal Width, ref decimal Weight, ref decimal Price, ref int CreatedByUserID, ref int CategoryID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT * FROM SubCategories WHERE ID = @ID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    Type = (string)Reader["Type"];
                    Thickness = (decimal)Reader["Thickness"];
                    Width = (decimal)Reader["Width"];
                    Weight = (decimal)Reader["Weight"];
                    Price = (decimal)Reader["Price"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CategoryID = (int)Reader["CategoryID"];


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


        public static bool GetRowInfoByType(ref int ID, string Type, ref decimal Thickness, ref decimal Width, ref decimal Weight, ref decimal Price, ref int CreatedByUserID, ref int CategoryID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT * FROM SubCategories WHERE Type = @Type";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@Type", Type);

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
                    Weight = (decimal)Reader["Weight"];
                    Price = (decimal)Reader["Price"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CategoryID = (int)Reader["CategoryID"];


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


        public static bool GetRowInfoByThickness(ref int ID, ref string Type, decimal Thickness, ref decimal Width, ref decimal Weight, ref decimal Price, ref int CreatedByUserID, ref int CategoryID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT * FROM SubCategories WHERE Thickness = @Thickness";

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
                    Type = (string)Reader["Type"];
                    Width = (decimal)Reader["Width"];
                    Weight = (decimal)Reader["Weight"];
                    Price = (decimal)Reader["Price"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CategoryID = (int)Reader["CategoryID"];


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


        public static bool GetRowInfoByWidth(ref int ID, ref string Type, ref decimal Thickness, decimal Width, ref decimal Weight, ref decimal Price, ref int CreatedByUserID, ref int CategoryID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT * FROM SubCategories WHERE Width = @Width";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@Width", Width);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    ID = (int)Reader["ID"];
                    Type = (string)Reader["Type"];
                    Thickness = (decimal)Reader["Thickness"];
                    Weight = (decimal)Reader["Weight"];
                    Price = (decimal)Reader["Price"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CategoryID = (int)Reader["CategoryID"];


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


        public static bool GetRowInfoByWeight(ref int ID, ref string Type, ref decimal Thickness, ref decimal Width, decimal Weight, ref decimal Price, ref int CreatedByUserID, ref int CategoryID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT * FROM SubCategories WHERE Weight = @Weight";

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
                    Type = (string)Reader["Type"];
                    Thickness = (decimal)Reader["Thickness"];
                    Width = (decimal)Reader["Width"];
                    Price = (decimal)Reader["Price"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CategoryID = (int)Reader["CategoryID"];


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


        public static bool GetRowInfoByPrice(ref int ID, ref string Type, ref decimal Thickness, ref decimal Width, ref decimal Weight, decimal Price, ref int CreatedByUserID, ref int CategoryID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT * FROM SubCategories WHERE Price = @Price";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@Price", Price);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    ID = (int)Reader["ID"];
                    Type = (string)Reader["Type"];
                    Thickness = (decimal)Reader["Thickness"];
                    Width = (decimal)Reader["Width"];
                    Weight = (decimal)Reader["Weight"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CategoryID = (int)Reader["CategoryID"];


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


        public static bool GetRowInfoByCategoryID(ref int ID, ref string Type, ref decimal Thickness, ref decimal Width, ref decimal Weight, ref decimal Price, ref int CreatedByUserID, int CategoryID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = "SELECT * FROM SubCategories WHERE CategoryID = @CategoryID";

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
                    Type = (string)Reader["Type"];
                    Thickness = (decimal)Reader["Thickness"];
                    Width = (decimal)Reader["Width"];
                    Weight = (decimal)Reader["Weight"];
                    Price = (decimal)Reader["Price"];
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


        public static int AddNewRow(string Type, decimal Thickness, decimal Width, decimal Weight, decimal Price, int CreatedByUserID, int CategoryID)
        {

            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"INSERT INTO SubCategories 
                               (Type, Thickness, Width, Weight, Price, CreatedByUserID, CategoryID)     
                             VALUES
                               (@Type, @Thickness, @Width, @Weight, @Price, @CreatedByUserID, @CategoryID)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@Type", Type);
            Command.Parameters.AddWithValue("@Thickness", Thickness);
            Command.Parameters.AddWithValue("@Width", Width);
            Command.Parameters.AddWithValue("@Weight", Weight);
            Command.Parameters.AddWithValue("@Price", Price);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@CategoryID", CategoryID);


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
        public static bool UpdateRow(int ID, string Type, decimal Thickness, decimal Width, decimal Weight, decimal Price, int CreatedByUserID, int CategoryID)
        {

            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = $@"UPDATE SubCategories SET 
		Type = @Type,
		Thickness = @Thickness,
		Width = @Width,
		Weight = @Weight,
		Price = @Price,
		CreatedByUserID = @CreatedByUserID,
		CategoryID = @CategoryID
		 WHERE ID = @ID
";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@Type", Type);
            Command.Parameters.AddWithValue("@Thickness", Thickness);
            Command.Parameters.AddWithValue("@Width", Width);
            Command.Parameters.AddWithValue("@Weight", Weight);
            Command.Parameters.AddWithValue("@Price", Price);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@CategoryID", CategoryID);


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

            string Query = @"SELECT * FROM SubCategories";

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


        public static DataTable GetAllRowsByCategoryID(int CategoryID)
        {

            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connection);

            string Query = @"SELECT * FROM SubCategories where CategoryID = @CategoryID";

            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@CategoryID", CategoryID);

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

            string Query = "SELECT Count(*) FROM SubCategories WHERE ID is not null";

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

            string Query = "DELETE SubCategories WHERE ID = @ID";

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

            string Query = "SELECT Found=1 FROM SubCategories WHERE ID = @ID";

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
   
