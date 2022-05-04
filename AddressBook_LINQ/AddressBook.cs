﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBook_LINQ
{
    public class AddressBook
    {
        DataTable dataTable = new DataTable();
        public AddressBook()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(long));
            dataTable.Columns.Add("Email", typeof(string));
        }
        //UC-1 Add contact
        public void AddContact()
        {
            dataTable.Rows.Add("Mythili", "Annamalai", "nadu st", "salem", "tamilnady",636002,9600474622,"mythili@gmail.com");
            dataTable.Rows.Add("Naveen kumar", "Selvaraj", "nadu st", "salem", "tamilnady", 636002, 9600474623, "naveen@gmail.com");
            dataTable.Rows.Add("Kiruba", "Selvaraj", "nadu st", "salem", "tamilnady", 636002, 9600474624, "kiruba@gmail.com");
            dataTable.Rows.Add("Lavanya", "Annamalai", "jj st", "salem", "tamilnady", 636002, 9600474625, "lavanya@gmail.com");
            dataTable.Rows.Add("Santhosh", "Annamalai", "jj st", "salem", "tamilnady", 636002, 9600474626, "santhosh@gmail.com");
            Console.WriteLine("Contact is Added in Address Book ");
        }
        //UC-2 Display contact
        public void DisplayContacts()
        {
            foreach (var contact in dataTable.AsEnumerable())
            {
                Console.WriteLine("\nFirstName:" + contact.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + contact.Field<string>("LastName"));
                Console.WriteLine("Address:-" + contact.Field<string>("Address"));
                Console.WriteLine("City:-" + contact.Field<string>("City"));
                Console.WriteLine("State:-" + contact.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + contact.Field<int>("Zip"));
                Console.WriteLine("PhoneNumber:-" + contact.Field<long>("PhoneNumber"));
                Console.WriteLine("Email:-" + contact.Field<string>("Email"));                
            }
        }
    }
}
