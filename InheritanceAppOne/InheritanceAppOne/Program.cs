namespace InheritanceAppOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Employee constructor calls Person constructor first
            // then Employee constructor
            Employee joe = new Employee("Joe", 30, "Software Developer", 101);
            joe.DisplayEmployeeInfo();
        }
    }
    // Base class
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)// Constructor
        {
            Name = name;
            Age = age;
           Console.WriteLine("Person constructor called");
        }
        public void DisplayPersonInfo()// Method to display person info
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    // Derived class
    public class Employee : Person// Inherits from Person
    {
        public string JobTitle { get; set; }
        public int EmployeeID { get; set; }
        public Employee(string name, int age, string jobTitle, int employeeID) : base(name, age)// Call base class constructor
        {
            Console.WriteLine("Employee constructor called");
            JobTitle = jobTitle;
            EmployeeID = employeeID;
        }
        public void DisplayEmployeeInfo()// Method to display employee info
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Job Title: {JobTitle}, Employee ID: {EmployeeID}");
        }
    }
}
