Console.WriteLine("Please enter your good name");
string name = Console.ReadLine().ToUpper();
Console.WriteLine($"{name} Please enter your age");
int age = int.Parse(Console.ReadLine());
bool isWithParents = false;

if (age >= 18)
{
    Console.WriteLine($"{name} Go patry in the club!!");
}
else if(age >= 13)
{
    Console.WriteLine($"{name} Are you with your parents? Note: Only answer with Y or N");
    string isWithParentsAnswer = Console.ReadLine();

    // if (isWithParentsAnswer.ToLower() == "y")
    if (isWithParentsAnswer == "y" || isWithParentsAnswer == "Y")
    {
        Console.WriteLine($"{name} Go party in the club with parents");
    }
    else
    {
        Console.WriteLine($"{name} No party for you today");
    }
}
else
{
    Console.WriteLine($"{name} Go party in kindergarden");
}

