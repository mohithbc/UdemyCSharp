Random random = new Random();
int secretNumber = random.Next(1, 101);
int userGuess = 0;
int Tries = 0;

Console.WriteLine("Guess the number in thinking between 1 and 100");

while (userGuess != secretNumber)
{
    Console.WriteLine("Enter your guess");
    userGuess = int.Parse(Console.ReadLine());
    Tries++;
    if(userGuess < secretNumber)
    {
        Console.WriteLine("Too low guess. Try again");
    }
    else if(userGuess > secretNumber) 
    {
        Console.WriteLine("Too high, Try again");
    }
    else
    {
        Console.WriteLine($"Yeahhh you guessed it right the number i was thinking is : " +
            $"{secretNumber} and you took {Tries} tries to guess that." );
    }
}

Console.ReadKey();