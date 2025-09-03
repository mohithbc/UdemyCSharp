namespace TryCatchExpections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            try
            {
                Console.WriteLine("Please enter a number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter another number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                result = num2 / num1;
            }
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("You need to enter a valid number");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Enter a number higher than 0");
            //    Console.WriteLine(ex.Message);
            //}
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }finally
            {
                // Code to cleanup or finalize ideal for cleaning up resources,
                // like closing file streams or database connections
                Console.WriteLine("This will always execute");
            }

            Console.WriteLine("The result is: " + result);
            Console.ReadKey();
        }
    }
}
