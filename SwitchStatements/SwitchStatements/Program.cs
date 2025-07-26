Console.WriteLine("please enter the month in number");
int month = int.Parse(Console.ReadLine());
string monthName;

switch (month)
{
    case 1:
        monthName = "Jan";
        break;
    case 2:
        monthName = "Feb";
        break;
    case 3:
        monthName = "March";
        break;
    default:
        monthName="unknown";
        break;
}
Console.WriteLine($"The name of the month is : {monthName}");
Console.ReadKey();