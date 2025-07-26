Random random = new Random();
int secretNumber = random.Next(1, 101); // generates number between 1 and 100

Console.Write("Guess a number between 1 and 100: ");
string input = Console.ReadLine();

bool isValid = int.TryParse(input, out int userGuess);

if (isValid)
{
    if (userGuess == secretNumber)
    {
        Console.WriteLine("Correct! You guessed the number.");
    }
    else
    {
        Console.WriteLine("Wrong guess. The number was: " + secretNumber);
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}
