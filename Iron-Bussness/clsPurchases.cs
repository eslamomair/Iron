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
    public class clsPurchases  
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;


        public int ID { get; set; }
        public decimal Thickness { get; set; }
        public decimal Weight { get; set; }
        public decimal Width { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int SupplierID { get; set; }
        public clsSuppliers Suppliers;
        public int SubCategoriesID { get; set; }
        public int CategoryID { get; set; }
        public int CreatedByUserID { get; set; }
        public int NewInventoryID { get; set; }

        

        public clsPurchases()
        {
            ID = -1;
            Thickness = -1;
            Weight = -1;
            Width = -1;
            Quantity = -1;
            Price = -1;
            DateOfPurchase = DateTime.MinValue;
            SupplierID = -1;
            SubCategoriesID = -1;
            CategoryID = -1;
            CreatedByUserID = -1;
            NewInventoryID = -1;
            Suppliers = clsSuppliers.Find(SupplierID);
           
            mode = enMode.eAddNew;
        }

        private clsPurchases(int ID, decimal Thickness, decimal Weight, decimal Width, decimal Quantity, decimal Price, DateTime DateOfPurchase, int SupplierID, int SubCategoriesID, int CategoryID, int CreatedByUserID , int NewInventoryID)
        {

            this.ID = ID;
            this.Thickness = Thickness;
            this.Weight = Weight;
            this.Width = Width;
            this.Quantity = Quantity;
            this.Price = Price;
            this.DateOfPurchase = DateOfPurchase;
            this.SupplierID = SupplierID;
            this.SubCategoriesID = SubCategoriesID;
            this.CategoryID = CategoryID;
            this.CreatedByUserID = CreatedByUserID;
            this.NewInventoryID = NewInventoryID;
            mode = enMode.eUpdate;

        }



        bool _AddNewRow()
        {

            this.ID = Purchases_Data.AddNewRow(this.Thickness, this.Weight, this.Width, this.Quantity, this.Price, this.DateOfPurchase, this.SupplierID, this.SubCategoriesID, this.CategoryID, this.CreatedByUserID,this.NewInventoryID);

            return this.ID != -1;

        }

        bool _UpdateRow()
        {

            return Purchases_Data.UpdateRow(this.ID, this.Thickness, this.Weight, this.Width, this.Quantity, this.Price, this.DateOfPurchase, this.SupplierID, this.SubCategoriesID, this.CategoryID, this.CreatedByUserID,this.NewInventoryID);


        }

        public static clsPurchases FindByID(int ID)
        {

            decimal Thickness = -1;
            decimal Weight = -1;
            decimal Width = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            DateTime DateOfPurchase = DateTime.MinValue;
            int SupplierID = -1;
            int SubCategoriesID = -1;
            int CategoryID = -1;
            int CreatedByUserID = -1;
            int NewInventoryID = -1;

            if (Purchases_Data.GetRowInfoByID(ID, ref Thickness, ref Weight, ref Width, ref Quantity, ref Price, ref DateOfPurchase, ref SupplierID, ref SubCategoriesID, ref CategoryID, ref CreatedByUserID,ref NewInventoryID))
            {

                return new clsPurchases(ID, Thickness, Weight, Width, Quantity, Price, DateOfPurchase, SupplierID, SubCategoriesID, CategoryID, CreatedByUserID , NewInventoryID);
            }
            else
                return null;
        }





        public static clsPurchases FindByThickness(decimal Thickness)
        {

            int ID = -1;
            decimal Weight = -1;
            decimal Width = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            DateTime DateOfPurchase = DateTime.MinValue;
            int SupplierID = -1;
            int SubCategoriesID = -1;
            int CategoryID = -1;
            int CreatedByUserID = -1;
            int NewInventoryID = -1;

            if (Purchases_Data.GetRowInfoByThickness(ref ID, Thickness, ref Weight, ref Width, ref Quantity, ref Price, ref DateOfPurchase, ref SupplierID, ref SubCategoriesID, ref CategoryID, ref CreatedByUserID,ref NewInventoryID))
            {

                return new clsPurchases(ID, Thickness, Weight, Width, Quantity, Price, DateOfPurchase, SupplierID, SubCategoriesID, CategoryID, CreatedByUserID, NewInventoryID);
            }
            else
                return null;
        }





        public static clsPurchases FindByWeight(decimal Weight)
        {

            int ID = -1;
            decimal Thickness = -1;
            decimal Width = -1;
            decimal Quantity = -1;
            decimal Price = -1;
            DateTime DateOfPurchase = DateTime.MinValue;
            int SupplierID = -1;
            int SubCategoriesID = -1;
            int CategoryID = -1;
            int CreatedByUserID = -1;
            int NewInventoryID = -1;

            if (Purchases_Data.GetRowInfoByWeight(ref ID, ref Thickness, Weight, ref Width, ref Quantity, ref Price, ref DateOfPurchase, ref SupplierID, ref SubCategoriesID, ref CategoryID, ref CreatedByUserID, ref NewInventoryID))
            {

                return new clsPurchases(ID, Thickness, Weight, Width, Quantity, Price, DateOfPurchase, SupplierID, SubCategoriesID, CategoryID, CreatedByUserID, NewInventoryID);
            }
            else
                return null;
        }


        public static DataTable ViewAllPurchases()
        {
            DataTable dt = Purchases_Data.GetAllPurchases();
                return dt;
        }



        public static DataTable GetAllRows()
        {
            DataTable DT = Purchases_Data.GetAllRows();
            return DT;
        }

        public static int GetNumberOfRows()
        {
            return Purchases_Data.GetNumberOfRows();
        }

        public static bool DeleteRow(int ID)
        {
            return (Purchases_Data.DeleteRow(ID));
        }

        public static bool DoesRowExist(int ID)
        {
            return (Purchases_Data.DoesRowExist(ID));
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
