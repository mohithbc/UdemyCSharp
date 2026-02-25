using System.Reflection;

namespace GenericReflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(ConfigurationManager<>);

            string myName = "mohith";
            if(myName.GetType() == typeof(string))
            {
                Console.WriteLine("Its a string");
            }
        }
    }

    internal class ConfigurationManager<T>
    {
        public T LoadedConfiguration { get; private set; }
        public ConfigurationManager(T config)
        {
            LoadedConfiguration = config;
        }
        public static void SaveConfiguration(T configToSave)
        {

        }
    }
}
