Console.WriteLine("Enter the first number :");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number :");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Choose an operation: +, -, *, /");
char operationChoosed = char.Parse(Console.ReadLine());

if (operationChoosed == '+')
{
    int Sum = firstNumber + secondNumber;
    Console.WriteLine($"Result: {Sum}");
}
else if (operationChoosed == '-')
{
    int Sub = firstNumber - secondNumber;
    Console.WriteLine($"Result: {Sub}");
}
else if (operationChoosed == '*')
{
    int Mul = firstNumber * secondNumber;
    Console.WriteLine($"Result: {Mul}");
}
else if (operationChoosed == '/')
{
    if (secondNumber == 0)
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
    }
    else
    {
        int Div = firstNumber / secondNumber;
        Console.WriteLine($"Result: {Div}");
    }
}

else
{
    Console.WriteLine("Invalid: Please choose +, -, *, or /.");
}

