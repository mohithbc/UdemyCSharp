namespace EnumsC
{
    // Define an enumeration for the days of the week
    enum Day {  Mo, Tu, We, Th, Fr, Sa, Su };
    enum Month {  Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };
    class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fr;//fr is a variable of type Day and is assigned the value Day.Fr
            Day su = Day.Su;

            Day a = Day.Fr;


            Console.WriteLine(fr==a);
            Console.WriteLine((int)Day.Mo);
            Console.WriteLine((int)Month.Jan);
            Console.WriteLine("Hello, World!");
        }
    }
}
