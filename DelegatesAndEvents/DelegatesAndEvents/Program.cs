namespace DelegatesAndEvents
{
    // A delegate can be declared inside or outside a class or namespace.
    internal class Program
    {
        // 1. Declaration:
        public delegate void Notify(string message);
        static void Main(string[] args)
        {
            // Delegates define a method signature,
            // and any method assigned to a delegate must match that signature.

            // 2. Instantiation:
            Notify notifyDelegate = new Notify(ShowMessage); 
            //or
            // Notify notifyDelegate = ShowMessage;

            // 3. Invocation:
            notifyDelegate("Hello, Delegates!");
        }
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
