using Iron_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;

namespace Iron_Bussness
{
    public class clsCustomers
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public clsPeoples Peoples;

        public clsCustomers()
        {
            this.ID = -1;
            this.CreatedByUserID = -1;
            this.PersonID = -1;
            Mode = enMode.AddNew;
        }

        private clsCustomers(int ID , int PersonID , int CreateByUserID    ) 
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreateByUserID;
            Peoples = clsPeoples.Find(PersonID);

            Mode = enMode.Update;
        }

        public static clsCustomers Find(int ID)
        {
            int PersonID = 0;
            int CreatedByUserID = 0;
            
            if (clsCustomersData.Find(ID, ref PersonID, ref CreatedByUserID  ))
            {
                return new clsCustomers(ID , PersonID, CreatedByUserID );
            }
            else
                return null;
        }

        public static clsCustomers FindByPersonID(int PersonID)
        {
            int ID = -1;
            int CreatedByUserID = -1;

            if (clsCustomersData.FindByPersonID(ref ID,  PersonID, ref CreatedByUserID))
            {
                return new clsCustomers(ID, PersonID, CreatedByUserID);
            }
            else
                return null;
        }

        private bool _AddNewCustomer()
        {
            this.ID = clsCustomersData.AddNewCustomer(this.PersonID, this.CreatedByUserID);
            return ( this.ID != -1);
        }

        private bool _UpdateCustomer()
        {
            return clsCustomersData.UpdateCustomer(this.ID, this.PersonID, this.CreatedByUserID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCustomer())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                   return _UpdateCustomer();
                
            }
            return false;
        }

        static public DataTable GetAllCustomers()
        {
            return clsCustomersData.GetAllCustomers();
        }

        public static bool DeleteCustomerByID(int ID)
        {
            return clsCustomersData.DeleteCustomer(ID);
        }
        public static bool IsCustomerExist(int ID)
        {
            return clsCustomers.IsCustomerExist(ID);
        }

        public static DataTable GetAllCustomerWithPersonsInfo()
        {
            return clsCustomersData.GetAllCustomersWithInfoPeople();
        }
    }
}
