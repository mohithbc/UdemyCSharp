void writeSomething()
{
    Console.WriteLine("Im writing something");
}

writeSomething();

// a method that has the parameter myString of type String
// method declaration
void writeSometingSpecific(string myString)
{
    Console.WriteLine("You passed this argument to me " + myString);
}

string myUSerName = "mohith";
// calling method and using an argument calle dmyusername
writeSometingSpecific("Stuppid");// can pass myUsername here also if we want
Console.WriteLine("This is ouside of the method");