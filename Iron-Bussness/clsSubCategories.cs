using Iron_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_Bussness
{
    public class clsSubCategories
    {
       
            public enum enMode { eAddNew = 0, eUpdate = 1 }
            public enMode mode = enMode.eAddNew;


            public int ID { get; set; }
            public string Type { get; set; }
            public decimal Thickness { get; set; }
            public decimal Width { get; set; }
            public decimal Weight { get; set; }
            public decimal Price { get; set; }
            public int CreatedByUserID { get; set; }
            public int CategoryID { get; set; }



            public clsSubCategories()
            {
                ID = -1;
                Type = "";
                Thickness = -1;
                Width = -1;
                Weight = -1;
                Price = -1;
                CreatedByUserID = -1;
                CategoryID = -1;

                mode = enMode.eAddNew;
            }

            private clsSubCategories(int ID, string Type, decimal Thickness, decimal Width, decimal Weight, decimal Price, int CreatedByUserID, int CategoryID)
            {

                this.ID = ID;
                this.Type = Type;
                this.Thickness = Thickness;
                this.Width = Width;
                this.Weight = Weight;
                this.Price = Price;
                this.CreatedByUserID = CreatedByUserID;
                this.CategoryID = CategoryID;

                mode = enMode.eUpdate;

            }



            bool _AddNewRow()
            {

                this.ID = clsSubCategories_Data.AddNewRow(this.Type, this.Thickness, this.Width, this.Weight, this.Price, this.CreatedByUserID, this.CategoryID);

                return this.ID != -1;

            }

            bool _UpdateRow()
            {

                return clsSubCategories_Data.UpdateRow(this.ID, this.Type, this.Thickness, this.Width, this.Weight, this.Price, this.CreatedByUserID, this.CategoryID);


            }

            public static clsSubCategories FindByID(int ID)
            {

                string Type = "";
                decimal Thickness = -1;
                decimal Width = -1;
                decimal Weight = -1;
                decimal Price = -1;
                int CreatedByUserID = -1;
                int CategoryID = -1;


                if (clsSubCategories_Data.GetRowInfoByID(ID, ref Type, ref Thickness, ref Width, ref Weight, ref Price, ref CreatedByUserID, ref CategoryID))
                {

                    return new clsSubCategories(ID, Type, Thickness, Width, Weight, Price, CreatedByUserID, CategoryID);
                }
                else
                    return null;
            }





            public static clsSubCategories FindByType(string Type)
            {

                int ID = -1;
                decimal Thickness = -1;
                decimal Width = -1;
                decimal Weight = -1;
                decimal Price = -1;
                int CreatedByUserID = -1;
                int CategoryID = -1;


                if (clsSubCategories_Data.GetRowInfoByType(ref ID, Type, ref Thickness, ref Width, ref Weight, ref Price, ref CreatedByUserID, ref CategoryID))
                {

                    return new clsSubCategories(ID, Type, Thickness, Width, Weight, Price, CreatedByUserID, CategoryID);
                }
                else
                    return null;
            }





            public static clsSubCategories FindByThickness(decimal Thickness)
            {

                int ID = -1;
                string Type = "";
                decimal Width = -1;
                decimal Weight = -1;
                decimal Price = -1;
                int CreatedByUserID = -1;
                int CategoryID = -1;


                if (clsSubCategories_Data.GetRowInfoByThickness(ref ID, ref Type, Thickness, ref Width, ref Weight, ref Price, ref CreatedByUserID, ref CategoryID))
                {

                    return new clsSubCategories(ID, Type, Thickness, Width, Weight, Price, CreatedByUserID, CategoryID);
                }
                else
                    return null;
            }





            public static clsSubCategories FindByWidth(decimal Width)
            {

                int ID = -1;
                string Type = "";
                decimal Thickness = -1;
                decimal Weight = -1;
                decimal Price = -1;
                int CreatedByUserID = -1;
                int CategoryID = -1;


                if (clsSubCategories_Data.GetRowInfoByWidth(ref ID, ref Type, ref Thickness, Width, ref Weight, ref Price, ref CreatedByUserID, ref CategoryID))
                {

                    return new clsSubCategories(ID, Type, Thickness, Width, Weight, Price, CreatedByUserID, CategoryID);
                }
                else
                    return null;
            }





            public static clsSubCategories FindByWeight(decimal Weight)
            {

                int ID = -1;
                string Type = "";
                decimal Thickness = -1;
                decimal Width = -1;
                decimal Price = -1;
                int CreatedByUserID = -1;
                int CategoryID = -1;


                if (clsSubCategories_Data.GetRowInfoByWeight(ref ID, ref Type, ref Thickness, ref Width, Weight, ref Price, ref CreatedByUserID, ref CategoryID))
                {

                    return new clsSubCategories(ID, Type, Thickness, Width, Weight, Price, CreatedByUserID, CategoryID);
                }
                else
                    return null;
            }





            public static clsSubCategories FindByPrice(decimal Price)
            {

                int ID = -1;
                string Type = "";
                decimal Thickness = -1;
                decimal Width = -1;
                decimal Weight = -1;
                int CreatedByUserID = -1;
                int CategoryID = -1;


                if (clsSubCategories_Data.GetRowInfoByPrice(ref ID, ref Type, ref Thickness, ref Width, ref Weight, Price, ref CreatedByUserID, ref CategoryID))
                {

                    return new clsSubCategories(ID, Type, Thickness, Width, Weight, Price, CreatedByUserID, CategoryID);
                }
                else
                    return null;
            }





            public static clsSubCategories FindByCategoryID(int CategoryID)
            {

                int ID = -1;
                string Type = "";
                decimal Thickness = -1;
                decimal Width = -1;
                decimal Weight = -1;
                decimal Price = -1;
                int CreatedByUserID = -1;


                if (clsSubCategories_Data.GetRowInfoByCategoryID(ref ID, ref Type, ref Thickness, ref Width, ref Weight, ref Price, ref CreatedByUserID, CategoryID))
                {

                    return new clsSubCategories(ID, Type, Thickness, Width, Weight, Price, CreatedByUserID, CategoryID);
                }
                else
                    return null;
            }


        public static DataTable GetAllRowsByCategoryID(int CategoryID)
        {
            DataTable DT = clsSubCategories_Data.GetAllRowsByCategoryID(CategoryID);
            return DT;
        }



        public static DataTable GetAllRows()
            {
                DataTable DT = clsSubCategories_Data.GetAllRows();
                return DT;
            }

            public static int GetNumberOfRows()
            {
                return clsSubCategories_Data.GetNumberOfRows();
            }

            public static bool DeleteRow(int ID)
            {
                return (clsSubCategories_Data.DeleteRow(ID));
            }

            public static bool DoesRowExist(int ID)
            {
                return (clsSubCategories_Data.DoesRowExist(ID));
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

