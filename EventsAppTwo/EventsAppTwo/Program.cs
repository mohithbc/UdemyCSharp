namespace EventsAppTwo
{
    // Using the Generic Delegate EventHandler<TEventArgs>

    //public delegate void TemperatureChangeHandler(string message);

    public class TemperatureChangedEventArgs : EventArgs
    {
        // Property holding the temperature
        public int Temperature { get; }

        // constructor
        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }
    public class TemperatureMonitor
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        //public event TemperatureChangeHandler OnTemperatureChanged;

        private int _temperature;
        public int Temperature
        {
            get { return _temperature; }


            set
            {

                if (_temperature != value)
                {
                    _temperature = value;
                    // RAISE EVENT!!!
                    OnTemperatureChanged(new TemperatureChangedEventArgs(_temperature));
                }
            }
        }

        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            // Letting every subscriber know!
            TemperatureChanged?.Invoke(this, e);
        }
    }
    // Subscriber
    public class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Alert: temperature is {e.Temperature} sender is: {sender}");
        }
    }
    public class TempCoolingAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"TEMP COOLING ALERT: temperature is {e.Temperature} sender is: {sender}");
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
            TempCoolingAlert alert2 = new TempCoolingAlert();
            monitor.TemperatureChanged += alert.OnTemperatureChanged;
            monitor.TemperatureChanged += alert2.OnTemperatureChanged;

            monitor.Temperature = 20;
            Console.WriteLine("Please enter the temperature");
            monitor.Temperature = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}

