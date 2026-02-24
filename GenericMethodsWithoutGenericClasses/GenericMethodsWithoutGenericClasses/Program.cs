namespace GenericMethodsWithoutGenericClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.Log<int>(10);
            logger.Log<string>("hello world");
            //no need to specify int or string as its geenric we can do
            logger.Log(new {name = "mohith", age  = 21});
        }
    }
}
