using System.Diagnostics;
namespace TryCatchExpections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Debug.WriteLine("Debug: Application started");
            try
            {
                Console.WriteLine("Please enter a number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter another number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                result = num2 / num1;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("You need to enter a valid number");
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Enter a number higher than 0");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("The number you entered is too big or too small");
                Console.WriteLine(ex.Message);
            }
            // This will catch any other exception not previously caught Default case
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
                Debug.WriteLine("Debug: " + ex.Message);
                Debug.WriteLine("Debug: " + ex.StackTrace);
                // This next line is only executed in debug mode
                Debug.WriteLine(ex.ToString());
            }
            finally
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
