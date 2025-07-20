using System;
using System.Data;
using ContactsBusinessLayer;
using CountryBusinessLayer;

namespace ContactsDataAccesLayer
{
    internal class Program
    {
        static void FindContact(int ID)
        {
            clsContact Contact1 = clsContact.Find(ID);

            if (Contact1 != null)
            {
                Console.WriteLine(Contact1.FirstName + " " + Contact1.LastName);
                Console.WriteLine(Contact1.Email);
                Console.WriteLine(Contact1.Phone);
                Console.WriteLine(Contact1.Address);
                Console.WriteLine(Contact1.DateOfBirth);
                Console.WriteLine(Contact1.CountryID);
                Console.WriteLine(Contact1.ImagePath);
            }
            else
            {
                Console.WriteLine("Contact " + ID + " Not found!");
            }
        }

        static void AddNewContact()
        {
            clsContact Contact1 = new clsContact();

            Contact1.FirstName = "Aboubakr";
            Contact1.LastName = "Jelloulat";
            Contact1.Email = "abubakerjelloulat@gmail.com";
            Contact1.Phone = "+212 767667227";
            Contact1.Address = "Nyhan, Stokholm, sweden";
            Contact1.DateOfBirth = new DateTime(2005, 08, 24);
            Contact1.CountryID = 1;
            Contact1.ImagePath = "/c/Users/HP/Pictures/aboub.jpg";

            if (Contact1.Save())
            {
                Console.WriteLine("Contact " + Contact1.FirstName + " " + Contact1.LastName + " added successfully!");
            }
            else
            {
                Console.WriteLine("Failed to add contact.");
            }

        }

        static void UpdateContact(int ID)
        {

            clsContact Contact1 = clsContact.Find(ID);

            if (Contact1 != null)
            {
                Contact1.FirstName = "Snder";
                Contact1.LastName = "Bos";
                Contact1.Email = "Sander@gmail.com";
                Contact1.Phone = "+41 6190145531";
                Contact1.Address = "Java street, Amsterdam, Netherlands";
                Contact1.DateOfBirth = new DateTime(2001, 11, 6, 10, 30, 0);
                Contact1.CountryID = 1;
                Contact1.ImagePath = "";

                if (Contact1.Save())
                {

                    Console.WriteLine("Contact updated Successfully ");
                }

            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }

        static void DeleteContact(int ID)

        {
            if (!clsContact.isContactExist(ID))
            {
                Console.WriteLine("Contact with ID " + ID + " does not exist.");
                return;
            }
            else
            {
                if (clsContact.DeleteContact(ID))

                    Console.WriteLine("Contact Deleted Successfully.");
                else
                    Console.WriteLine("Faild to delete contact.");

            }

        }

        static void ListContacts()
        {
            DataTable dataTable = clsContact.GetAllContacts();

            Console.WriteLine("Contacts  : ");

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row[0]},     {row[1]},      {row[2]}");
            }

        }

        static void isContactExist(int ID)
        {
            if (clsContact.isContactExist(ID))
            {
                Console.WriteLine("Contact with ID " + ID + " exists.");
            }
            else
            {
                Console.WriteLine("Contact with ID " + ID + " does not exist.");
            }
        }



        // Country Methods

        static void FindCountryByID(int ID)
        {
            clsCountry Country1 = clsCountry.Find(ID);

            if (Country1 != null)
            {
                Console.WriteLine(Country1.CountryName);
            }
            else
            {
                Console.WriteLine("Country [" + ID + "] Not found!");
            }

        }

        static void Main(string[] args)
        {
            // ***********   Contact Methods  ***********


            // FindContact(2); 

            // AddNewContact();

            // UpdateContact(1);

            //DeleteContact(7);

            //ListContacts();

            // isContactExist(100);


            //  ***********   Country Methods   ***********

            FindCountryByID(93);

            //FindCountryByName("Morocco");


            Console.ReadKey();
        }
    }
}

