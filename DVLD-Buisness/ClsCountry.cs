using DVLD_DataAccess;
using System;
using System.Data;



namespace DVLD_Buisness
{
    public class ClsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public ClsCountry()
        {
            this.CountryID = -1;
            this.CountryName = "";
        }
        private ClsCountry(int countryID, string countryName)
        {
            this.CountryID = countryID;
            this.CountryName = countryName;
        }

        public static ClsCountry FindById(int id)
        {
            string countryName = "";
            if (ClsCountryData.GetCountryInfoByID(id, ref countryName))
            {
                return new ClsCountry(id, countryName);
            }
            else
            {
                return null;
            }

        }
        public static ClsCountry FindByName(string countryName)
        {
            int id = -1;

            if (ClsCountryData.GetCountryInfoByName(countryName, ref id))
            {
                return new ClsCountry(id, countryName);
            }
            else
            {
                return null;
            }

        }

        public static DataTable GetAllCountries()
        {

            return ClsCountryData.GetAllCountries();
        }
    }
}
