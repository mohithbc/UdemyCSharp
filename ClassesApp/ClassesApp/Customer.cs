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
        public Customer(string name, string address, string ContactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = ContactNumber;
        }

        public Customer(string name)
        {
            Name = name;
        }

        public void SetDetails(string name, string address, string ContactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = ContactNumber;
        }
    }
}
