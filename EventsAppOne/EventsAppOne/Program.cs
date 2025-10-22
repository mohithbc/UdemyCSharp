namespace EventsAppOne
{
    public delegate void TemperatureChangeHandler(string message);

    public class TemperatureMonitor
    {
        public event TemperatureChangeHandler OnTemperatureChanged;

        private int _temperature;
        public int Temperature
        {
            get { return _temperature; }


            set
            {
                _temperature = value;
                if (_temperature > 30)
                {
                    // RAISE EVENT!!!
                    RaiseTemperatureChangedEvent("Temperature is above threshold!");
                }
            }
        }

        protected virtual void RaiseTemperatureChangedEvent(string message)
        {
            OnTemperatureChanged?.Invoke(message);
        }
    }

    public class TemperatureAlert
    {
        public void OnTemperatureChanged(string message)
        {
            Console.WriteLine("Alert: " + message);
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
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            monitor.OnTemperatureChanged += alert.OnTemperatureChanged;

            monitor.Temperature = 20;
            Console.WriteLine("Please enter the temperature");
            monitor.Temperature = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
