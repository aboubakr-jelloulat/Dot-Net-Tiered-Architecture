using ContactsDataAccesLayer;
using System;
using System.Data;
using CountrysDataAccesLayer;

namespace CountryBusinessLayer
{
    public class clsCountry
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public string CountryName { set; get; }

        public clsCountry()
        {
            this.ID = -1;
            this.CountryName = "";
            Mode = enMode.AddNew;
        }

        private clsCountry(int ID, string CountryName)
        {
            this.ID = ID;
            this.CountryName = CountryName;
            Mode = enMode.Update;
        }

        public static clsCountry Find(int ID)
        {
            int CountryID = -1;
            string CountryName = "";

            // Call Data Access Layer to find the country by ID

            if (clsCountryDataAccess.GetCountryInfoByID(ID, ref CountryName))
            {
               
                return new clsCountry(ID, CountryName);
            }
            else
            {
                return null; // Not found
            }


        }

    }
}
