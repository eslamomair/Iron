using Iron_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_Bussness
{
    public class clsSuppliers
    {


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public clsPeoples People;
       
        public clsSuppliers()
        {
            this.ID = -1;
            this.CreatedByUserID = -1;
            this.PersonID = -1;
            Mode = enMode.AddNew;
        }
        private clsSuppliers(int ID, int PersonID, int CreateByUserID)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreateByUserID;
            this.People = clsPeoples.Find(PersonID);

            Mode = enMode.Update;
        }

        public static clsSuppliers Find(int ID)
        {
            int PersonID = 0;
            int CreatedByUserID = 0;

            if (clsSuppliers_Data.Find(ID, ref PersonID, ref CreatedByUserID))
            {
                return new clsSuppliers(ID, PersonID, CreatedByUserID);
            }
            else
                return null;
        }

        public static clsSuppliers FindByPersonID(int PersonID)
        {
            int ID = -1;
            int CreatedByUserID = -1;

            if (clsSuppliers_Data.FindPersonID(ref ID, PersonID, ref CreatedByUserID))
            {
                return new clsSuppliers(ID, PersonID, CreatedByUserID);
            }
            else
                return null;
        }

        private bool _AddNewSuppliers()
        {
            this.ID = clsSuppliers_Data.AddNewSuppliers(this.PersonID, this.CreatedByUserID);
            return (this.ID != -1);
        }

        private bool _UpdateSuppliers()
        {
            return clsSuppliers_Data.UpdateSuppliers(this.ID, this.PersonID, this.CreatedByUserID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSuppliers())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateSuppliers();

            }
            return false;
        }

        static public DataTable GetAllSuppliers()
        {
            return clsSuppliers_Data.GetAllSuppliers();
        }

        static public DataTable GetAllInfoSuppliers()
        {
            return clsSuppliers_Data.GetAllSuppliersWithInfoPeople();
        }


        public static bool DeleteSuppliersByID(int ID)
        {
            return clsSuppliers_Data.DeleteSuppliers(ID);
        }
        public static bool IsSuppliersExist(int ID)
        {
            return clsSuppliers_Data.IstExist(ID);
        }
    }
}
