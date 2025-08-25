namespace ClassesApp
{
    // Access Modifier-
    /*Access modifiers are crucial for managing how classes and class members are accessed in software
     projects. By controlling access, you can safeguard the internal state of objects, reduce
    dependencies between componets and enhance maintainability*/
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

            Customer customer1 = new Customer("John Doe");
            Console.WriteLine("COntact number of Customer 1 is : " + customer1.ContactNumber);
            
            Customer cus1 = new Customer("Jane Doe", "123 Main St");
            Customer cus2 = new Customer("Alice Smith", "456 Oak Ave", "9876543210");
            Customer cus3 = new Customer();

            cus1.GetDetails();
            cus2.GetDetails();
            cus3.GetDetails();  

            myCustomer.SetDetails("Mohith", "Tiptur", "11231214124");

            /*NOTE: functions are like methods the do the same thing the only diffrence is that
             functions are not a part of a class, once a function is inside a class its called a method*/

            // an object can have properties and it can have methods
            // properties are attributes of that object and methods are capabilities/skills like drive
            //we are calling the drive method ont he object myTata
            Car myTata = new Car("Tiago", "Tata", false);
            myTata.Drive();


            static void main(string[] args)
            {
                Console.WriteLine(AddNum(15,25));
                // Named Parameters
                Console.WriteLine(AddNum(firstNum: 23, 25));
            }

            static int AddNum(int firstNum, int secondNUm)
            {
                return firstNum + secondNUm;
            }


            Rectangle r1 = new Rectangle();
            r1.Width = 10;
            r1.Height = 20;
            Console.WriteLine("Area is " + r1.Area);

            // static field
            Console.WriteLine("Total number of cars created: " + Car.NumberOfCars);
            Console.ReadKey();
            
            /*In c# static keyword is used to declare members of a class that belong to the class itself
             rather than to any specific instance of the class*/
            Customer.DoSomeCustomerStuff();
            // The doSomeCustomerStuff method is static and cannot be called using an object
            // myCustomer.DoSomeCustomerStuff();
         
            
        }
    }
}
