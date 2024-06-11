using Iron_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_Bussness
{
    public class clsCategory
    {
        public enum enMode { AddNew = 0 , Update = 1 };
        public enMode Mode;

        public int CategoryID {  get; set; }
        public string ItemsType { get; set; }
        public string Description { get; set; }

        private clsCategory ( int category, string itemsName, string description)
        {
            this.Mode = enMode.Update;
            this.CategoryID = category;
            this.ItemsType = itemsName;
            this.Description = description;
        }
        public clsCategory()
        {
            Mode =enMode.AddNew;
            CategoryID = -1;
            ItemsType = string.Empty;
            Description = string.Empty ;
        }

        public static clsCategory Find (int ID )
        {
            string ItemsType = "";
            string Description = "";

            if (clsCategory_Data.Find(ID, ref ItemsType, ref Description))
            {
                return new clsCategory(ID, ItemsType, Description);
            }
            else
                return null;
        }

        public static clsCategory Find(string ItemsType )
        {
            int ID = -1;
            string Description = "";

            if (clsCategory_Data.Find(ref ID,  ItemsType, ref Description))
            {
                return new clsCategory(ID, ItemsType, Description);
            }
            else
                return null;
        }

        private bool _AddNewCategory()
        {
            this.CategoryID = clsCategory_Data.AddNewCategory(this.ItemsType, this.Description);
            return (this.CategoryID != -1);
        }

        private bool _UpdateCategory()
        {
            return clsCategory_Data.UpdateCategory(this.CategoryID, this.ItemsType, this.Description);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCategory() )
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                   return _UpdateCategory();
                
            }
            return false;
        }

        public static DataTable GetAllCategory()
        {
            return clsCategory_Data.GetAllCategory();
        }

        public static bool DeleteCategory(int ID)
        {
            return clsCategory_Data.DeleteCategory(ID); 
        }

        public static bool IsCategoryExist(int ID)
        {
            return clsCategory_Data.IsCategoryExist(ID);
        }
    }
}
