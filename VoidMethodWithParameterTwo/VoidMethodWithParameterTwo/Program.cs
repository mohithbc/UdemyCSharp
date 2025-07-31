int addTwoValues(int value1, int value2)
{
    int result = value1 + value2;
    return result;
}
Console.WriteLine("enter first and second value to sum");
Console.Write("Enter first number: ");
int Uvalue1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int Uvalue2 = int.Parse(Console.ReadLine());

int myResult = addTwoValues(Uvalue1, Uvalue2);
Console.WriteLine("Result is : " + myResult);

