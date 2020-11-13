// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Nikhil Kumar Yadav"/>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace AddressBook_Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            AddressBookManagement.CreateDataTable();
            //AddressBookManagement.InsertRowIntotable();
            //AddressBookManagement.DisplayDataTable();

            //AddressBookManagement.EditContactInTable("nikhil");
            //AddressBookManagement.DeleteContactInTable("akhil");

            // AddressBookManagement.DisplayDataTableBelongingToStateOrCity();
            //AddressBookManagement.CountContactInTable("Mumbai");
            //AddressBookManagement.CountByState();
            //AddressBookManagement.SortedContactsByNameForAgivenState();
            //AddressBookManagement.AddAddressBookNameType();
            //AddressBookManagement.DisplayDataTable();
            
            
            // UC 9 Add addressbook name and type
            Console.WriteLine("\nAdd Address Book name and type");
            AddressBookManagement.AddAddressBookNameType();

            // UC 10 Get Count by type
            Console.WriteLine("\nCount by type");
            AddressBookManagement.GetCountByType();
        }
    }
}
