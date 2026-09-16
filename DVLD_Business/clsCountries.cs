using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsCountries
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        private clsCountries(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }

        public static DataTable GetAllCountries()
        {
            return clsDataforCountries.GetAllCountries();
        }


        public static clsCountries Find(int countryID)
        {
            string countryName = "";
           

            if (clsDataforCountries.GetCountryById(countryID, ref countryName))
            {
                return new clsCountries(countryID, countryName);
            }
            else
            {
                return null;
            }
        }
        public static clsCountries Find(string countryName)
        {
            int id = -1;
            string code = "";
            string phoneCode = "";

            if (clsDataforCountries.GetCountryByName(countryName, ref id))
            {
                return new clsCountries(id, countryName);
            }
            else
            {
                return null;
            }
        }

    }
}
