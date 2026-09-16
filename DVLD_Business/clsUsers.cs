using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_Business
{
    public class clsUsers
    {
        enum enMode { Update, AddNew };
        enMode Mode = enMode.AddNew;

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PersonID { get; set; }
        public bool IsActive { get; set; }

        public clsPerson PersonInfo;

        private clsUsers(int userID, int personID, string userName, string password, bool isActive)
        {
            this.UserID = userID;
            this.UserName = userName;
            this.PersonID = personID;
            this.Password = password;
            this.IsActive = isActive;

            this.PersonInfo = clsPerson.FindPeopleByID(personID);

            Mode = enMode.Update;
        }

        public clsUsers()
        {
            this.UserID = -1;
            this.IsActive = false;
            this.UserName = "";
            this.Password = "";

            Mode = enMode.AddNew;
        }

        private bool _AddNew()
        {
            this.UserID = clsUsersData.AddUser(this.PersonID, this.UserName, this.Password, this.IsActive);
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUsersData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateUser();
                default:
                    return false;
            }
        }

        public static DataTable FindAllPeople()
        {
            return clsUsersData.GetAllUesr();
        }

        public static bool DeleteUser(int userID)
        {
            return clsUsersData.Delete(userID);
        }

        public static bool IsUserExistByPersonID(int personID)
        {
            return clsUsersData.IsUserExistForPersonID(personID);
        }

        public static bool IsUserExistByUserName(string userName)
        {
            return clsUsersData.IsUserExistByName(userName);
        }


        public static clsUsers FindUserByUsernameAndPassword(string userName, string password)
        {
            int userID = -1;
            int personID = -1;
            bool isActive = false;

            if (clsUsersData.GetUserByUsernameAndPassword(userName, password, ref userID, ref personID, ref isActive))
            {
                return new clsUsers(userID, personID, userName, password, isActive);
            }
            else
            {
                return null;
            }
        }


        public static clsUsers FindUserByUserID(int UserID)
        {
            int PersonID = -1;
            string userName = "", password = "";
            bool isActive = false;

            if (clsUsersData.GetUserByUserID(UserID, ref PersonID, ref userName, ref password, ref isActive))
            {
                return new clsUsers(UserID, PersonID, userName, password, isActive);
            }
            else
            {
                return null;
            }


        }

       



    }
}