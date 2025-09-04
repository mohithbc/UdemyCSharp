using System.Threading.Channels;

namespace ThrowKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            GetUserAge(Console.ReadLine());
        }
        static int GetUserAge(string input)
        {
            int age;
            if (!int.TryParse(input, out age))
            {
                throw new Exception("You did not enter a valid age.");
            }
            if (age < 0 || age > 120)
            {
                throw new Exception("Your age must be between 0 and 120.");
            }
            return age;
        }
    }
}
