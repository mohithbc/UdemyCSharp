int counter = 15;

do
{
    Console.WriteLine(counter);
    counter++;
    Thread.Sleep(1000);
} while (counter < 10);

Console.ReadKey();

int number;

do
{
    Console.WriteLine("Enter a positive whole number");
    number = int.Parse(Console.ReadLine());
} while (number <= 0);
Console.WriteLine("ahh finally entered a whole number");
Console.ReadKey();