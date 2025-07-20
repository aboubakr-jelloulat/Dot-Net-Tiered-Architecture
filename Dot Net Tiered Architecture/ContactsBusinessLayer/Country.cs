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

        public static clsCountry Find(string CountryName)
        {
            int CountryID = -1;
            string CountryNameFound = "";
            // Call Data Access Layer to find the country by Name
            if (clsCountryDataAccess.GetCountryInfoByName(CountryName, ref CountryNameFound))
            {
                return new clsCountry(CountryID, CountryNameFound);
            }
            else
            {
                return null; // Not found
            }

        }
        public static bool isCountryExist(int ID)
        {
            return clsCountryDataAccess.IsCountryExist(ID);
        }

        public static bool isCountryExist(string CountryName)
        {
            return clsCountryDataAccess.IsCountryExist(CountryName);
        }

        private bool _AddNewCountry()
        {
           this.ID = clsCountryDataAccess.AddNewCountry(this.CountryName);
            return this.ID > 0;
        }

        private bool _UpdateCountry()
        {
            return clsCountryDataAccess.UpdateCountry(this.ID, this.CountryName);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    return _AddNewCountry();
                case enMode.Update:
                    return _UpdateCountry();
                default:
                    throw new InvalidOperationException("Unknown mode");
            }

        }

        public static DataTable GetAllCountries()
        {
            return clsCountryDataAccess.GetAllCountries();

        }

        public static bool DeleteCountry(int ID)
        {
            return clsCountryDataAccess.DeleteCountry(ID);
        }


    }
}
