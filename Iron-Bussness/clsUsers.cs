
using Iron_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_Bussness
{
    public class clsUsers
    {
        public enum enMode { AddNew = 0 , UpdateNew = 1 }
        public enMode Mode;

        public clsPeoples PersonInfo;
        public int ID {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DataCreated { get; set; }
        public bool IsActive { get; set; }
        public int PersonID { get; set; }

        public clsUsers()
        {

            this.ID = -1;
            this.UserName =string.Empty;
            this.Password =string.Empty;
            this.DataCreated = DateTime.MinValue;
            this.IsActive = false;
            this.PersonID = -1;

            Mode = enMode.AddNew;
        }
        private clsUsers(  int iD,int PersonID, string userName, string password, DateTime dataCreated, bool isActive)
        {

            this.ID = iD;
            this.UserName = userName;
            this.Password = password;
            this.DataCreated = dataCreated;
            this.IsActive = isActive;
            this.PersonID = PersonID;
            this.PersonInfo = clsPeoples.Find(PersonID);
            Mode = enMode.UpdateNew;
        }

        public static clsUsers Find(int ID)
        {
            string UserName = "";
            string Password = ""; int PersonID = -1;
            DateTime DataCreated = DateTime.Now.AddYears(-100);
            bool IsActive = false;

            if (clsUser_Data.FindByUserID(ID,ref PersonID, ref UserName, ref Password, ref DataCreated
                , ref IsActive))
            {
                return new clsUsers(ID,PersonID, UserName, Password, DataCreated, IsActive);
            }
            else
                return null;
        }

        public static clsUsers FindByUserNameAndPassword(string UserName ,string Password)
        {
            int ID = -1;
             int PersonID = -1;
            DateTime DataCreated = DateTime.Now.AddYears(-100);
            bool IsActive = false;

            if (clsUser_Data.FindByUserNameAPssword(ref ID, ref PersonID,   UserName,
                Password, ref DataCreated      , ref IsActive))
            {
                return new clsUsers(ID, PersonID, UserName, Password, DataCreated, IsActive);
            }
            else
                return null;
        }

       private bool _AddNewUser()
        {
            this.ID = clsUser_Data.AddNewUser(this.PersonID,this.UserName,this.Password
                ,this.DataCreated,this.IsActive);
            return (this.ID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUser_Data.UpdateUser(this.ID, this.PersonID,this.UserName, this.Password, this.DataCreated, this.IsActive);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.UpdateNew;
                        return true;
                    }
                    else
                        return false;
                case enMode.UpdateNew:
                    return _UpdateUser();


            }
            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUser_Data.GetAllUsers();
        }
        public static bool DeleteUser(int ID)
        {
            return clsUser_Data.DeleteUser(ID);
        }

        public static bool IsUserExist(int ID)
        {
            return clsUser_Data.IsExist(ID);
        }

        public static bool IsUserExistByUserName(string UserName)
        {
            return clsUser_Data.IsExist(UserName);
        }

        public static bool IsUserExistForPersonID(int PersonID)
        {
            return clsUser_Data.IsUserExistForPerson1ID(PersonID);
        }

        public static bool ChangeUserPassword(int ID ,  string NewPassword)
        {
            return clsUser_Data.ChangePassword(ID, NewPassword);
        }
    }
}
