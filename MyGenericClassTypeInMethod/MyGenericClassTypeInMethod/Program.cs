namespace MyGenericClassTypeInMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> boxStr = new Box<string>("hello world");
            boxStr.UpdateContent("Teach c#");
            Console.WriteLine(boxStr.GetContent());
        }
    }
}
