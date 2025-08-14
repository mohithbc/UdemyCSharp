namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* --------------------           car           ----------------------------

            // Creating an object of the class car
            // Or creating an instance of the class Car
            Car audi = new Car("A3","audi", true);
            // Creating an another object
            Car bmw = new Car("I7", "BMW", false);

            Console.WriteLine("Please enter the brand name");
            // Setting brand
            audi.Brand = Console.ReadLine();// this is the value you are passing to your brand

            // Getting brand
            Console.WriteLine("Brand is " + audi.Brand);
            Console.WriteLine("Brand is " + bmw.Brand);

            Console.ReadKey();
            -----------------------------------------------------------------------------
            */


            Customer Modi = new Customer("modi");
            Customer Amit = new Customer("Amit shah", "new delhi", "1234567890");
            Console.WriteLine("name of customer is " + Modi.Name);
            Console.WriteLine($"name of customer {Amit.Name} address:{Amit.Address} ContactNumber {Amit.ContactNumber}");

            //Default customer with no argumnets given
            Customer myCustomer = new Customer();
            Console.WriteLine("Please enter customer name");
            myCustomer.Name = Console.ReadLine();
            Console.WriteLine("Details about customer: " + myCustomer.Name);

            myCustomer.SetDetails("Mohith", "Tiptur", "11231214124");

            /*NOTE: functions are like methods the do the same thing the only diffrence is that
             functions are not a part of a class, once a function is inside a class its called a method*/

            // an object can have properties and it can have methods
            // properties are attributes of that object and methods are capabilities/skills like drive
            //we are calling the drive method ont he object myTata
            Car myTata = new Car("Tiago", "Tata", false);
            myTata.Drive();

            Console.ReadKey();

        }
    }
}
