using DVLD_DataAccess;
using System;
using System.Data;


namespace DVLD_Buisness
{
    public class ClsUsers
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;
        public int UserID { set; get; }
        public int PersonID { set; get; }
        public ClsPerson PersonInfo;
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }
        public ClsUsers()

        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;
            Mode = enMode.AddNew;
        }
        private ClsUsers(int UserID, int PersonID, string Username,
            string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.PersonInfo = ClsPerson.FindPersonById(PersonID);
            this.UserName = Username;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }
        private bool _AddNewUser()
        {
            this.UserID = ClsUserData.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            return ClsUserData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
        }
        public static ClsUsers FindByUserID(int UserID)
        {
            int PersonID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = ClsUserData.GetUserInfoByUserID
                                (UserID, ref PersonID, ref UserName, ref Password, ref IsActive);

            if (IsFound)

                return new ClsUsers(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }
        public static ClsUsers FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = ClsUserData.GetUserInfoByPersonID
                                (ref UserID, PersonID, ref UserName, ref Password, ref IsActive);

            if (IsFound)

                return new ClsUsers(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }
        public static ClsUsers FindByUsernameAndPassword(string UserName, string Password)
        {
            int UserID = -1;
            int PersonID = -1;

            bool IsActive = false;

            bool IsFound = ClsUserData.GetUserInfoByUserNameAndPassword
                                (ref UserID, ref PersonID, UserName, Password, ref IsActive);

            if (IsFound)

                return new ClsUsers(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
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

            }

            return false;
        }
        public static DataTable GetAllUsers()
        {
            return ClsUserData.GetAllUsers();
        }
        public static bool DeleteUser(int UserID)
        {
            return ClsUserData.DeleteUser(UserID);
        }

        public static bool isUserExist(int UserID)
        {
            return ClsUserData.IsUserExistByUserID(UserID);
        }

        public static bool isUserExist(string UserName)
        {
            return ClsUserData.IsUserExistByUserName(UserName);
        }

        public static bool isUserExistForPersonID(int PersonID)
        {
            return ClsUserData.IsUserExistByPersonID(PersonID);
        }
    }
}
