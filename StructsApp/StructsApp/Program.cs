namespace StructsApp
{
    public struct Point
    {
        // Its a common practice to make structs immutable by declaring all fields as readonly
        // and providing only getters for properties.
        // public int X { get; } // Readonly property
        public int X { get; set; }// properties
        public int Y { get; set; }

      //  public int X; // fields
        public Point(int x, int y)// Constructor
        {
            X = x;
            Y = y;
        }
        public void Display()// Method to display point
        {
            Console.WriteLine($"Point({X}, {Y})");
        }
        public void Deconstruct(out int x, out int y)// Deconstructor or method to unpack values
        {
            x = X;
            y = Y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            p1.Display();

            Point p2;
            p2.X = 30; // Must initialize all fields before use, use fields by commenting out properties
            p2.Y = 40;
            p2.Display();

            Point p3 = p1; // Structs are value types, so this creates a copy
            p3.X = 50; // Modifying p3 does not affect p1
            p1.Display();
            p3.Display();


            Console.WriteLine("Hello, World!");
        }
    }
}
