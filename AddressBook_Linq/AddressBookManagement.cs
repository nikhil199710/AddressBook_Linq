// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Nikhil Kumar Yadav"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBook_Linq
{
    public class AddressBookManagement
    {
        /// <summary>
        /// Creating Data Table 
        /// Uc1
        /// </summary>
        public static DataTable table = new DataTable();

        ///// <summary>
        ///// Creating Data Table 
        ///// UC2
        ///// </summary>
        public static void CreateDataTable()
        {
            ///adding columns
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(int));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("EmailId", typeof(string));
            ///adding rows
            table.Rows.Add("nikhil", "yadav", "Street1", "Faridabad", "Haryana", 121001, "9650925666", "nikhil@gmail.com");
            table.Rows.Add("akhil", "yada", "Street2", "Mumbai", "Maharashtra", 878001, "890925666", "akhil@gmail.com");
            table.Rows.Add("riya", "yad", "Street3", "Mumbai", "Maharashtra", 841001, "7412925666", "riya@gmail.com");
            table.Rows.Add("neha", "ya", "Street4", "Paris", "France", 7894551, "4569925666", "neha@gmail.com");
        }
        public static void DisplayDataTable()
        {
            var records = table.AsEnumerable();
            //table.AsEnumerable();
            foreach (var row in records)
            {
                Console.WriteLine("FirstName: " + row.Field<string>("FirstName") + ", LastName: " + row.Field<string>("LastName") + ", Address: " + row.Field<string>("Address") + " , City: " + row.Field<string>("City") + " , State: " + row.Field<string>("State") + ", Zip: " + row.Field<int>("Zip") + " , PhoneNumber: " + row.Field<string>("PhoneNumber") + ", EmailID: " + row.Field<string>("EmailID"));
            }
        }
        ///// <summary>
        ///// Inserting a Row in DataTable
        ///// UC3
        ///// </summary>


        //public static void InsertRowIntotable()
        //{
        //    DataRow inserttable = table.NewRow();
        //    inserttable[0] = "Sneha";
        //    inserttable[1] = "y";
        //    inserttable[2] = "street6";
        //    inserttable[3] = "ballia";
        //    inserttable[4] = "Uttar Pradesh";
        //    inserttable[5] = 2185451;
        //    inserttable[6] = "7896541238";
        //    inserttable[7] = "sneha@gmail.com";
        //    table.Rows.Add(inserttable);

        //}
        //public static void EditContactInTable(string editName)
        //{
        //    //editName= Console.WriteLine();
        //    foreach (DataRow dr in table.Rows)
        //    {
        //        {
        //            if (dr["FirstName"] == editName)
        //                dr["LastName"] = "UpdateYadav";
        //        }
        //    }
        //}

        //public static void DeleteContactInTable(string deleteName)
        //{
        //    for (int i = table.Rows.Count - 1; i >= 0; i--)
        //    {
        //        DataRow dr = table.Rows[i];
        //        if (dr["FirstName"] == deleteName)
        //            dr.Delete();
        //    }
        //    table.AcceptChanges();
        //}

        public static void DisplayDataTableBelongingToStateOrCity()
        {
            string state = Console.ReadLine();
            string city = Console.ReadLine();
            foreach (DataRow dr in table.Rows)
            {
                {
                    if ((dr["City"] == city) || (dr["State"] == state))
                        Console.WriteLine("FirstName: " + dr.Field<string>("FirstName") + ", LastName: " + dr.Field<string>("LastName") + ", Address: " + dr.Field<string>("Address") + " , City: " + dr.Field<string>("City") + " , State: " + dr.Field<string>("State") + ", Zip: " + dr.Field<int>("Zip") + " , PhoneNumber: " + dr.Field<string>("PhoneNumber") + ", EmailID: " + dr.Field<string>("EmailID"));
                }
            }
        }
        //public static void CountContactInTable(string city)
        //{
        //    int count = 0;
        //    //editName= Console.WriteLine();
        //    foreach (DataRow dr in table.Rows)
        //    {
        //        {
        //            if (dr["City"] == city)
        //                count++;
        //        }
        //    }
        //    Console.WriteLine("Count:" + count);
        //}

        ////Facing_Error|
        //public static void CountByState()
        //{
        //    var records = table.AsEnumerable().Where(a => a.Field<string>("State").Equals("Maharastra"));
        //    Console.WriteLine("The count for records by state is  is : " + records.Count());
        //}

        //public static void SortedContactsByNameForAgivenState()
        //{
        //    var records = table.AsEnumerable().Where(r => r.Field<string>("State") == "Maharashtra").OrderBy(r => r.Field<string>("FirstName")).ThenBy(r => r.Field<string>("LastName"));
        //    //var records = table.AsEnumerable().Where(a => a.Field<string>("state").Equals("Maharastra")).OrderBy((a=>a.Field<string>("firstName")).thenby(a => a.Field<string>("LastName")));
        //    foreach (var row in records)
        //    {
        //        Console.WriteLine("FirstName: " + row.Field<string>("FirstName") + ", LastName: " + row.Field<string>("LastName") + ", Address: " + row.Field<string>("Address") + " , City: " + row.Field<string>("City") + " , State: " + row.Field<string>("State") + ", Zip: " + row.Field<int>("Zip") + " , PhoneNumber: " + row.Field<string>("PhoneNumber") + ", EmailID: " + row.Field<string>("EmailID"));
        //    }
        //}


        //public static void AddAddressBookNameType()
        //{
        //    DataColumn column;
        //    column = new DataColumn();
        //    column.DataType = System.Type.GetType("System.String");
        //    column.ColumnName = "addressBookName";
        //    column.AllowDBNull = false;
        //    column.DefaultValue = "Home";
        //    table.Columns.Add(column);

        //    column = new DataColumn();
        //    column.DataType = System.Type.GetType("System.String");
        //    column.ColumnName = "type";
        //    column.AllowDBNull = false;
        //    column.DefaultValue = "Friend";
        //    table.Columns.Add(column);
        //}
    }
}



















