using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // default constructor - is the constructor without any parameters
        public Customer()
        {
            Name = "New Customer";
            Address = "No Address";
            ContactNumber = "No contact number";
        }

        // custom constructor
        // default / optional parameters
        public Customer(string name, string address="NA", string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // default parameter contact number 
        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // static says that this method does not need an object to be called
        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("Doing some customer stuff");
        }
    }
}
