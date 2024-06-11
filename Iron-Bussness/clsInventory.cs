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
    public class clsInventory
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;


        public int ID { get; set; }
        public int SubcategoryID { get; set; }
        public decimal Thickness { get; set; }
        public decimal Weight { get; set; }
        public decimal Width { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public int CategoryID { get; set; }
        public int CreatedByUserID { get; set; }



        public clsInventory()
        {
            ID = -1;
            SubcategoryID = -1;
            Thickness = -1;
            Weight = -1;
            Width = -1;
            Quantity = -1;
            Price = -1;
            DateIn = DateTime.MinValue;
            DateOut = DateTime.MinValue;
            CategoryID = -1;
            CreatedByUserID = -1;

            mode = enMode.eAddNew;
        }

        private clsInventory(int ID, int SubcategoryID, decimal Thickness, decimal Weight, decimal Width, decimal Quantity, decimal Price, DateTime DateIn, DateTime DateOut, int CategoryID, int CreatedByUserID)
        {

            this.ID = ID;
            this.SubcategoryID = SubcategoryID;
            this.Thickness = Thickness;
            this.Weight = Weight;
            this.Width = Width;
            this.Quantity = Quantity;
            this.Price = Price;
            this.DateIn = DateIn;
            this.DateOut = DateOut;
            this.CategoryID = CategoryID;
            this.CreatedByUserID = CreatedByUserID;

            mode = enMode.eUpdate;

        }



        bool _AddNewRow()
        {

            this.ID = clsInventory_Data.AddNewRow(this.SubcategoryID, this.Thickness, this.Weight, this.Width, this.Quantity, this.Price, this.DateIn, this.DateOut, this.CategoryID, this.CreatedByUserID);

            return this.ID != -1;

        }

        bool _UpdateRow()
        {

            return clsInventory_Data.UpdateRow(this.ID, this.SubcategoryID, this.Thickness, this.Weight, this.Width, this.Quantity, this.Price, this.DateIn, this.DateOut, this.CategoryID, this.CreatedByUserID);


        }

        public static clsInventory FindByID(int ID)
        {

            int SubcategoryID = -1;
            decimal Thickness = -1;
            decimal Weight = -1;
            decimal Width = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            DateTime DateIn = DateTime.MinValue;
            DateTime DateOut = DateTime.MinValue;
            int CategoryID = -1;
            int CreatedByUserID = -1;


            if (clsInventory_Data.GetRowInfoByID(ID, ref SubcategoryID, ref Thickness, ref Weight, ref Width, ref Quantity, ref Price, ref DateIn, ref DateOut, ref CategoryID, ref CreatedByUserID))
            {

                return new clsInventory(ID, SubcategoryID, Thickness, Weight, Width, Quantity, Price, DateIn, DateOut, CategoryID, CreatedByUserID);
            }
            else
                return null;
        }





        public static clsInventory FindBySubcategoryID(int SubcategoryID)
        {

            int ID = -1;
            decimal Thickness = -1;
            decimal Weight = -1;
            decimal Width = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            DateTime DateIn = DateTime.MinValue;
            DateTime DateOut = DateTime.MinValue;
            int CategoryID = -1;
            int CreatedByUserID = -1;


            if (clsInventory_Data.GetRowInfoBySubcategoryID(ref ID, SubcategoryID, ref Thickness, ref Weight, ref Width, ref Quantity, ref Price, ref DateIn, ref DateOut, ref CategoryID, ref CreatedByUserID))
            {

                return new clsInventory(ID, SubcategoryID, Thickness, Weight, Width, Quantity, Price, DateIn, DateOut, CategoryID, CreatedByUserID);
            }
            else
                return null;
        }





        public static clsInventory FindByThickness(decimal Thickness)
        {

            int ID = -1;
            int SubcategoryID = -1;
            decimal Weight = -1;
            decimal Width = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            DateTime DateIn = DateTime.MinValue;
            DateTime DateOut = DateTime.MinValue;
            int CategoryID = -1;
            int CreatedByUserID = -1;


            if (clsInventory_Data.GetRowInfoByThickness(ref ID, ref SubcategoryID, Thickness, ref Weight, ref Width, ref Quantity, ref Price, ref DateIn, ref DateOut, ref CategoryID, ref CreatedByUserID))
            {

                return new clsInventory(ID, SubcategoryID, Thickness, Weight, Width, Quantity, Price, DateIn, DateOut, CategoryID, CreatedByUserID);
            }
            else
                return null;
        }





        public static clsInventory FindByCategoryID(int CategoryID)
        {

            int ID = -1;
            int SubcategoryID = -1;
            decimal Thickness = -1;
            decimal Weight = -1;
            decimal Width = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            DateTime DateIn = DateTime.MinValue;
            DateTime DateOut = DateTime.MinValue;
            int CreatedByUserID = -1;


            if (clsInventory_Data.GetRowInfoByCategoryID(ref ID, ref SubcategoryID, ref Thickness, ref Weight, ref Width, ref Quantity, ref Price, ref DateIn, ref DateOut, CategoryID, ref CreatedByUserID))
            {

                return new clsInventory(ID, SubcategoryID, Thickness, Weight, Width, Quantity, Price, DateIn, DateOut, CategoryID, CreatedByUserID);
            }
            else
                return null;
        }






        public static DataTable GetAllRows()
        {
            DataTable DT = clsInventory_Data.GetAllRows();
            return DT;
        }

        public static int GetNumberOfRows()
        {
            return clsInventory_Data.GetNumberOfRows();
        }

        public static bool DeleteRow(int ID)
        {
            return (clsInventory_Data.DeleteRow(ID));
        }

        public static bool DoesRowExist(int ID)
        {
            return (clsInventory_Data.DoesRowExist(ID));
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





    }
}
