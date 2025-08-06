namespace WeatherSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to stimulate : ");
            int days = int.Parse(Console.ReadLine());
            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            // double averageTemp = calculateAverage(temperature);
            Console.WriteLine($"Average Temperature is : {calculateAverage(temperature)}");
            Console.WriteLine($"The max temp was : {temperature.Max()}");
            Console.WriteLine($"The min temp was : {temperature.Min()}");
            Console.WriteLine($"Most common condition is : {mostCommonCondition(weatherConditions)}");
            Console.ReadKey();
        }


        static string mostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];
            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                }
                    if(tempCount > count)
                    {
                        count = tempCount;
                        mostCommon = conditions[i];
                    }
                }
            return mostCommon;
        }
            
        

        static double calculateAverage(int[] temperature)
        {
            double sum = 0;
            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }

            // can use foreach also
            //foreach (int i in temperature)
            //{
            //    sum += i;
            //}

            double average = sum / temperature.Length;

            return average;
        }

        // the below piece of code is what a .min() method does

        //static int minTemperature(int[] temperature)
        //{
        //    int min = temperature[0];
        //    foreach (int temp in temperature)
        //    {
        //        if (temp < min)
        //        {
        //            min = temp;
        //        }
        //    }
        //    return min;
        //}
    }
}
