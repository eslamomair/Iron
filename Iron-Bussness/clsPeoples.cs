using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iron_DataAccess;

namespace Iron_Bussness
{
    public class clsPeoples
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string NationalN { get; set; }
        public string Phone { get; set; } 
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public string Address { get; set; }

        public string FullName
        {
            get
            { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }

        public clsPeoples()
        {
            this.PersonID = -1;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName = string.Empty;
            this.NationalN = string.Empty;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.ImagePath = string.Empty;
            this.Address = string.Empty;
            Mode = enMode.AddNew;
        }
        private clsPeoples(int ID, string FirstName, string SecondName, string ThirdName,
            string LastName, string NationalN, string Phone, string ImagePath, string Email,  string Address)
        {
            this.PersonID = ID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalN = NationalN;
            this.Phone = Phone;
            this.Email = Email;
            this.ImagePath = ImagePath;
            this.Address = Address;
            Mode = enMode.Update;
        }
        public static clsPeoples Find(int PersonID)
        {
            string FirstName = string.Empty;
            string SecondName = string.Empty;    string ThirdName = string.Empty;
            string LastName = string.Empty;      string NationalN = string.Empty;
            string Phone = string.Empty;        string Email = string.Empty;
            string ImagePath = string.Empty;    string Address = string.Empty;

            if (clsPeoplesData.Find(PersonID, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref NationalN, ref Phone, ref ImagePath, ref Email,ref Address))
            {
                return new clsPeoples(PersonID, FirstName, SecondName, ThirdName,
                 LastName, NationalN, Phone, ImagePath, Email, Address);
            }
            else
                return null;
        }


        public static clsPeoples Find(string NationalN)
        {
            int ID = -1;
            string FirstName = string.Empty;   string SecondName = string.Empty;
            string ThirdName = string.Empty;   string LastName = string.Empty;
            string Phone = string.Empty;      string Email = string.Empty;
            string ImagePath = string.Empty; string Address = string.Empty;

            if (clsPeoplesData.Find(ref ID, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName,   NationalN, ref Phone, ref ImagePath, ref Email, ref Address))
            {
                return new clsPeoples(ID, FirstName, SecondName, ThirdName,
                 LastName, NationalN, Phone, ImagePath, Email, Address);
            }
            else
                return null;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPeoplesData.AddNewPerson(this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.NationalN, this.Phone, this.ImagePath,
                this.Email, this.Address);
            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPeoplesData.UpdatePerson(this.PersonID, this.FirstName, this.SecondName,
                this.ThirdName, this.LastName,this.NationalN,this.Phone,this.ImagePath,
                this.Email, this.Address);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                    
                case enMode.Update:
                    return _UpdatePerson();
                 
            }
            return false;
        }

         public static bool DeletePerson(int PersonID)
        {
            return clsPeoplesData.DeletePerson(PersonID);
        }
        public static DataTable GetAllPeople()
        {
            return clsPeoplesData.GetAllPeople();
        }

        public static bool IsPersonExist(int ID)
        {
            return clsPeoplesData.IsPersonExist(ID);
        }

        public static bool IsPersonExist(string NationalN)
        {
            return clsPeoplesData.IsPersonExist(NationalN);
        }
    }
}
