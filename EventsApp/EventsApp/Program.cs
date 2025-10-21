namespace EventsApp
{

    public delegate void Notify(string message);

    public class EventPublisher
    {
        // The "On" prefix makes it immediately clear that the method
        // is associated with an event.
        //It signifies that the method is not just a regular method but
        //one that is called when a specific event occurs.
        public event Notify OnNotify;

        public void RaiseEvent(string message)
        {

            OnNotify?.Invoke(message); // Invoke the event if there are any subscribers
        }
    }

    public class EventSubscriber
    {
        public void OnEventRaised(string message)
        {
            Console.WriteLine("Event received: " + message);
        }
    }


    internal class Program
    {
        /* 
        WHAT?
        An event is a way for a class to notify other classes or objects 
        when something of interest occurs. Events are based on delegates.
   
        WHY?
        Events enable a class to provide notifications without knowing which 
        other classes or objects will receive those notifications. 
        This promotes loose coupling and separation of concerns.

        WHEN?
        Use events when you need a mechanism for one object to notify other
        objects about changes or actions.

        WHERE?
        Commonly used in scenarios like logging, monitoring, data changes, button click,
        keyboard clicks,and any situation where a notification mechanism is needed.
        */
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();
            publisher.OnNotify += subscriber.OnEventRaised;
            publisher.OnNotify += subscriber.OnEventRaised;
            publisher.RaiseEvent("test");

            Console.ReadKey();
        }
    }
}





