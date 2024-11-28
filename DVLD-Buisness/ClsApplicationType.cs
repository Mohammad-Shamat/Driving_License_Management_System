using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class ClsApplicationType
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;
        public int ID {set; get; }
        public string Title { set; get; }
        public float Fees { set; get; }

        public ClsApplicationType()
        {
            this.ID = -1;
            this.Title = string.Empty;
            this.Fees = 0;
            Mode = enMode.AddNew;
        }
        private ClsApplicationType(int Id,string ApplicationTypeName,float ApplicationTypeFees)
        {
            this.ID = Id;
            this.Title=ApplicationTypeName;
            this.Fees = ApplicationTypeFees;
            Mode = enMode.Update;
        }

        private bool _AddNewApplicationType()
        {
            this.ID = ClsApplicationTypeData.AddNewApplicationType(this.Title,this.Fees);
            return (this.ID != -1);
        }

        private bool _UpdateApplicationType()
        {
            return ClsApplicationTypeData.UpdateApplictionType(this.ID,this.Title,this.Fees);
        }

        public static ClsApplicationType Find(int Id)
        {
            string Titel=string.Empty;
            float Fees = 0;
            if (ClsApplicationTypeData.GetApplicationTypeInfoByID(Id,ref Titel,ref Fees))
            {
                return new ClsApplicationType(Id, Titel, Fees);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetAllApplicationTypes()
        {
            return ClsApplicationTypeData.GetAllApplicationTypes();

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplicationType())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplicationType();

            }

            return false;
        }
    }
}
