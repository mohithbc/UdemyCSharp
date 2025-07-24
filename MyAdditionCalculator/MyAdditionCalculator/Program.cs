using System;

double myFNumber = 0;
double mySNumber = 0;

Console.WriteLine("Enter a first number");
string userInputOne = Console.ReadLine();
myFNumber = double.Parse(userInputOne);


Console.WriteLine("Enter a second number");
string userInputTwo = Console.ReadLine();
mySNumber = double.Parse(userInputTwo);

double sum = myFNumber + mySNumber;
sum = Math.Round(sum,3);
Console.WriteLine($"The sum of {myFNumber} + {mySNumber} = {sum} ");

Console.ReadKey();




