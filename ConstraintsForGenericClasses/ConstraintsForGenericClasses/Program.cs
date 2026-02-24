namespace ConstraintsForGenericClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<Book> bookBox = new Box<Book>();
            Box<int> boxInt = new Box<int>();
        }
    }
    class Book
    {

    }
}
