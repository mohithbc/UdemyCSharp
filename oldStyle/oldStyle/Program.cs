namespace oldStyle
{
    internal class Program
    {
        // int myResult;
        // now myresult is a field/instance variable you can call it a 
        // global variable, it is globaly available atleast inside of our class
        static void Main(string[] args)
        {
            int myResult;

            Console.WriteLine("Enter a number, I'll add 10 to it!");
            int num1 = int.Parse(Console.ReadLine());

            myResult = AddTwoValues(num1, 10);
            Console.WriteLine("The result is " + myResult);

            Console.ReadKey();
        }

        static int AddTwoValues(int value1, int value2)
        {
            int result = value1 + value2;
            return result;
        }

        static int SubtractTwoValues(int value1, int value2)
        {
            int result = value1 - value2;
            return result;
        }
    }
}
