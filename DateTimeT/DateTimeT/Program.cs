namespace DateTimeT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2002, 08, 10);

            Console.WriteLine("My birthday is {0}", dateTime);
            // Write today on screen instead of NOW we can use TODAY also
            Console.WriteLine("Today is {0}", DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be the {0}", tomorrow);
            Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Now.AddDays(1);
        }
    }
}
