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
    public class clsNewInventory 
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;


        public int IDInventory { get; set; }
        public int SubCategoryID { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal UnitPrice { get; set; }
        public int CreatedByUserID { get; set; }



        public clsNewInventory()
        {
            IDInventory = -1;
            SubCategoryID = -1;
            Quantity = -1;
            Price = -1;
            UnitPrice = -1;
            CreatedByUserID = -1;

            mode = enMode.eAddNew;
        }

        private clsNewInventory(int IDInventory, int SubCategoryID, decimal Quantity, decimal Price, decimal UnitPrice, int CreatedByUserID)
        {

            this.IDInventory = IDInventory;
            this.SubCategoryID = SubCategoryID;
            this.Quantity = Quantity;
            this.Price = Price;
            this.UnitPrice = UnitPrice;
            this.CreatedByUserID = CreatedByUserID;

            mode = enMode.eUpdate;

        }



        bool _AddNewRow()
        {

            this.IDInventory = clsNewInventory_Data.AddNewRow(this.SubCategoryID, this.Quantity, this.Price, this.UnitPrice, this.CreatedByUserID);

            return this.IDInventory != -1;

        }

        bool _UpdateRow()
        {

            return clsNewInventory_Data.UpdateRow(this.IDInventory, this.SubCategoryID, this.Quantity, this.Price, this.UnitPrice, this.CreatedByUserID);


        }

        public static clsNewInventory FindByIDInventory(int IDInventory)
        {

            int SubCategoryID = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            decimal UnitPrice = -1;
            int CreatedByUserID = -1;


            if (clsNewInventory_Data.GetRowInfoByIDInventory(IDInventory, ref SubCategoryID, ref Quantity, ref Price, ref UnitPrice, ref CreatedByUserID))
            {

                return new clsNewInventory(IDInventory, SubCategoryID, Quantity, Price, UnitPrice, CreatedByUserID);
            }
            else
                return null;
        }





        public static clsNewInventory FindBySubCategoryID(int SubCategoryID)
        {

            int IDInventory = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            decimal UnitPrice = -1;
            int CreatedByUserID = -1;


            if (clsNewInventory_Data.GetRowInfoBySubCategoryID(ref IDInventory, SubCategoryID, ref Quantity, ref Price, ref UnitPrice, ref CreatedByUserID))
            {

                return new clsNewInventory(IDInventory, SubCategoryID, Quantity, Price, UnitPrice, CreatedByUserID);
            }
            else
                return null;
        }






        public static DataTable GetAllRows()
        {
            DataTable DT = clsNewInventory_Data.GetAllRows();
            return DT;
        }

        public static int GetNumberOfRows()
        {
            return clsNewInventory_Data.GetNumberOfRows();
        }

        public static bool DeleteRow(int IDInventory)
        {
            return (clsNewInventory_Data.DeleteRow(IDInventory));
        }

        public static bool DoesRowExist(int IDInventory)
        {
            return (clsNewInventory_Data.DoesRowExist(IDInventory));
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
