using System;
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
        //UC-1 && 2 && 3 Add contact
        public void AddContact()
        {
            dataTable.Rows.Add("Mythili", "Annamalai", "nadu st", "salem", "tamilnadu",636002,9600474622,"mythili@gmail.com");
            dataTable.Rows.Add("Naveen kumar", "Selvaraj", "nadu st", "salem", "tamilnadu", 636002, 9600474623, "naveen@gmail.com");
            dataTable.Rows.Add("Kiruba", "Selvaraj", "nadu st", "salem", "tamilnadu", 636002, 9600474624, "kiruba@gmail.com");
            dataTable.Rows.Add("Lavanya", "Annamalai", "jj st", "salem", "tamilnadu", 636002, 9600474625, "lavanya@gmail.com");
            dataTable.Rows.Add("Santhosh", "Annamalai", "jj st", "salem", "tamilnadu", 636002, 9600474626, "santhosh@gmail.com");
            Console.WriteLine("Contact is Added in Address Book ");
        }
        //display
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
        //UC-4 Edit contact
        public void EditContact()
        {
            var contacts = dataTable.AsEnumerable().Where(x => x.Field<string>("FirstName") == "Mythili");
            int count = contacts.Count();
            if (count > 0)
            {
                foreach (var contact in contacts)
                {
                    contact.SetField("LastName", "Naveen kumar");
                    contact.SetField("Address", "nadu st");
                    contact.SetField("City", "salem");
                    contact.SetField("State", "tamilnadu");
                    contact.SetField("Zip", 626002);
                    contact.SetField("phoneNumber", 9600474622);
                    contact.SetField("Email", "mythili@gmail.com");
                }
                Console.WriteLine("Contact is Changed Successfully");
            }
            else
            {
                Console.WriteLine("Contact Does not Found!");
            }
        }
        //UC-5 Delete contact
        public void RemoveContact()
        {
            var contact = dataTable.AsEnumerable().Where(x => x.Field<string>("FirstName") == "Aniket");
            int count = contact.Count();
            if (count > 0)
            {
                foreach (var row in contact.ToList())
                {
                    row.Delete();
                    Console.WriteLine("Contact Is Deleted Successfully");
                }
            }
            else
            {
                Console.WriteLine("Contact Does not Found!");
            }
        }
    }
}
