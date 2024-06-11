using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iron_DataAccess;

namespace Iron_Bussness
{
    public class clsSales
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;


        public int ID { get; set; }
        public decimal Thickness { get; set; }
        public decimal Weight { get; set; }
        public decimal Width { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime DateOfSale { get; set; }
        public int CustomerID { get; set; }
        public int SubCategoriesID { get; set; }
        public int CategoryID { get; set; }
        public int CreatedByUserID { get; set; }
        public int NewInventoryID { get; set; }



        public clsSales()
        {
            ID = -1;
            Thickness = -1;
            Weight = -1;
            Width = -1;
            Quantity = -1;
            Price = -1;
            DateOfSale = DateTime.MinValue;
            CustomerID = -1;
            SubCategoriesID = -1;
            CategoryID = -1;
            CreatedByUserID = -1;
            NewInventoryID = -1;

            mode = enMode.eAddNew;
        }

        private clsSales(int ID, decimal Thickness, decimal Weight, decimal Width, decimal Quantity, decimal Price, DateTime DateOfSale, int CustomerID, int SubCategoriesID, int CategoryID, int CreatedByUserID, int NewInventoryID)
        {

            this.ID = ID;
            this.Thickness = Thickness;
            this.Weight = Weight;
            this.Width = Width;
            this.Quantity = Quantity;
            this.Price = Price;
            this.DateOfSale = DateOfSale;
            this.CustomerID = CustomerID;
            this.SubCategoriesID = SubCategoriesID;
            this.CategoryID = CategoryID;
            this.CreatedByUserID = CreatedByUserID;
            this.NewInventoryID = NewInventoryID;

            mode = enMode.eUpdate;

        }



        bool _AddNewRow()
        {

            this.ID = clsSales_Data.AddNewRow(this.Thickness, this.Weight, this.Width, this.Quantity, this.Price, this.DateOfSale, this.CustomerID, this.SubCategoriesID, this.CategoryID, this.CreatedByUserID, this.NewInventoryID);

            return this.ID != -1;

        }

        bool _UpdateRow()
        {

            return clsSales_Data.UpdateRow(this.ID, this.Thickness, this.Weight, this.Width, this.Quantity, this.Price, this.DateOfSale, this.CustomerID, this.SubCategoriesID, this.CategoryID, this.CreatedByUserID, this.NewInventoryID);


        }

        public static clsSales FindByID(int ID)
        {

            decimal Thickness = -1;
            decimal Weight = -1;
            decimal Width = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            DateTime DateOfSale = DateTime.MinValue;
            int CustomerID = -1;
            int SubCategoriesID = -1;
            int CategoryID = -1;
            int CreatedByUserID = -1;
            int NewInventoryID = -1;


            if (clsSales_Data.GetRowInfoByID(ID, ref Thickness, ref Weight, ref Width, ref Quantity, ref Price, ref DateOfSale, ref CustomerID, ref SubCategoriesID, ref CategoryID, ref CreatedByUserID, ref NewInventoryID))
            {

                return new clsSales(ID, Thickness, Weight, Width, Quantity, Price, DateOfSale, CustomerID, SubCategoriesID, CategoryID, CreatedByUserID, NewInventoryID);
            }
            else
                return null;
        }





        public static clsSales FindByThickness(decimal Thickness)
        {

            int ID = -1;
            decimal Weight = -1;
            decimal Width = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            DateTime DateOfSale = DateTime.MinValue;
            int CustomerID = -1;
            int SubCategoriesID = -1;
            int CategoryID = -1;
            int CreatedByUserID = -1;
            int NewInventoryID = -1;


            if (clsSales_Data.GetRowInfoByThickness(ref ID, Thickness, ref Weight, ref Width, ref Quantity, ref Price, ref DateOfSale, ref CustomerID, ref SubCategoriesID, ref CategoryID, ref CreatedByUserID, ref NewInventoryID))
            {

                return new clsSales(ID, Thickness, Weight, Width, Quantity, Price, DateOfSale, CustomerID, SubCategoriesID, CategoryID, CreatedByUserID, NewInventoryID);
            }
            else
                return null;
        }





        public static clsSales FindByWeight(decimal Weight)
        {

            int ID = -1;
            decimal Thickness = -1;
            decimal Width = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            DateTime DateOfSale = DateTime.MinValue;
            int CustomerID = -1;
            int SubCategoriesID = -1;
            int CategoryID = -1;
            int CreatedByUserID = -1;
            int NewInventoryID = -1;


            if (clsSales_Data.GetRowInfoByWeight(ref ID, ref Thickness, Weight, ref Width, ref Quantity, ref Price, ref DateOfSale, ref CustomerID, ref SubCategoriesID, ref CategoryID, ref CreatedByUserID, ref NewInventoryID))
            {

                return new clsSales(ID, Thickness, Weight, Width, Quantity, Price, DateOfSale, CustomerID, SubCategoriesID, CategoryID, CreatedByUserID, NewInventoryID);
            }
            else
                return null;
        }





        public static clsSales FindByWidth(decimal Width)
        {

            int ID = -1;
            decimal Thickness = -1;
            decimal Weight = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            DateTime DateOfSale = DateTime.MinValue;
            int CustomerID = -1;
            int SubCategoriesID = -1;
            int CategoryID = -1;
            int CreatedByUserID = -1;
            int NewInventoryID = -1;


            if (clsSales_Data.GetRowInfoByWidth(ref ID, ref Thickness, ref Weight, Width, ref Quantity, ref Price, ref DateOfSale, ref CustomerID, ref SubCategoriesID, ref CategoryID, ref CreatedByUserID, ref NewInventoryID))
            {

                return new clsSales(ID, Thickness, Weight, Width, Quantity, Price, DateOfSale, CustomerID, SubCategoriesID, CategoryID, CreatedByUserID, NewInventoryID);
            }
            else
                return null;
        }





        public static clsSales FindByCustomerID(int CustomerID)
        {

            int ID = -1;
            decimal Thickness = -1;
            decimal Weight = -1;
            decimal Width = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            DateTime DateOfSale = DateTime.MinValue;
            int SubCategoriesID = -1;
            int CategoryID = -1;
            int CreatedByUserID = -1;
            int NewInventoryID = -1;


            if (clsSales_Data.GetRowInfoByCustomerID(ref ID, ref Thickness, ref Weight, ref Width, ref Quantity, ref Price, ref DateOfSale, CustomerID, ref SubCategoriesID, ref CategoryID, ref CreatedByUserID, ref NewInventoryID))
            {

                return new clsSales(ID, Thickness, Weight, Width, Quantity, Price, DateOfSale, CustomerID, SubCategoriesID, CategoryID, CreatedByUserID, NewInventoryID);
            }
            else
                return null;
        }





        public static clsSales FindBySubCategoriesID(int SubCategoriesID)
        {

            int ID = -1;
            decimal Thickness = -1;
            decimal Weight = -1;
            decimal Width = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            DateTime DateOfSale = DateTime.MinValue;
            int CustomerID = -1;
            int CategoryID = -1;
            int CreatedByUserID = -1;
            int NewInventoryID = -1;


            if (clsSales_Data.GetRowInfoBySubCategoriesID(ref ID, ref Thickness, ref Weight, ref Width, ref Quantity, ref Price, ref DateOfSale, ref CustomerID, SubCategoriesID, ref CategoryID, ref CreatedByUserID, ref NewInventoryID))
            {

                return new clsSales(ID, Thickness, Weight, Width, Quantity, Price, DateOfSale, CustomerID, SubCategoriesID, CategoryID, CreatedByUserID, NewInventoryID);
            }
            else
                return null;
        }





        public static clsSales FindByCategoryID(int CategoryID)
        {

            int ID = -1;
            decimal Thickness = -1;
            decimal Weight = -1;
            decimal Width = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            DateTime DateOfSale = DateTime.MinValue;
            int CustomerID = -1;
            int SubCategoriesID = -1;
            int CreatedByUserID = -1;
            int NewInventoryID = -1;


            if (clsSales_Data.GetRowInfoByCategoryID(ref ID, ref Thickness, ref Weight, ref Width, ref Quantity, ref Price, ref DateOfSale, ref CustomerID, ref SubCategoriesID, CategoryID, ref CreatedByUserID, ref NewInventoryID))
            {

                return new clsSales(ID, Thickness, Weight, Width, Quantity, Price, DateOfSale, CustomerID, SubCategoriesID, CategoryID, CreatedByUserID, NewInventoryID);
            }
            else
                return null;
        }





        public static clsSales FindByNewInventoryID(int NewInventoryID)
        {

            int ID = -1;
            decimal Thickness = -1;
            decimal Weight = -1;
            decimal Width = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            DateTime DateOfSale = DateTime.MinValue;
            int CustomerID = -1;
            int SubCategoriesID = -1;
            int CategoryID = -1;
            int CreatedByUserID = -1;


            if (clsSales_Data.GetRowInfoByNewInventoryID(ref ID, ref Thickness, ref Weight, ref Width, ref Quantity, ref Price, ref DateOfSale, ref CustomerID, ref SubCategoriesID, ref CategoryID, ref CreatedByUserID, NewInventoryID))
            {

                return new clsSales(ID, Thickness, Weight, Width, Quantity, Price, DateOfSale, CustomerID, SubCategoriesID, CategoryID, CreatedByUserID, NewInventoryID);
            }
            else
                return null;
        }






        public static DataTable GetAllRows()
        {
            DataTable DT = clsSales_Data.GetAllRows();
            return DT;
        }

        public static int GetNumberOfRows()
        {
            return clsSales_Data.GetNumberOfRows();
        }

        public static bool DeleteRow(int ID)
        {
            return (clsSales_Data.DeleteRow(ID));
        }

        public static bool DoesRowExist(int ID)
        {
            return (clsSales_Data.DoesRowExist(ID));
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.eAddNew:
                    {
                        if (_AddNewRow())
                        {
                            mode = enMode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case enMode.eUpdate:

                    return _UpdateRow();

            }

            return false;
        }


        public static DataTable GetAllSailing()
        {
            return clsSales_Data.GetAllSailing();
        }


    }
}
