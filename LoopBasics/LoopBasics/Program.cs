
// In string \ is an escape character
// \n stands for new line

string myString = "Hi \nHi";

// for loop

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("I is " + i);
    Thread.Sleep(1000);
}

for (int i = 10; i > 0; i--)
{
    Console.WriteLine("I is " + i);
}

// While loop

int counter = 0;
while (counter < 10)
{
    Console.WriteLine(counter);
    counter++;
}

// while loop where it really shines

Console.WriteLine("Enter go or stay");
string userChoice = Console.ReadLine();

while (userChoice == "go")
{
    Console.WriteLine("Go for a mile");
    Console.WriteLine("Wanna keep going enter go. Else type no or something");
    userChoice = Console.ReadLine();
}
Console.WriteLine("Finally you are staying");

Console.ReadKey();
