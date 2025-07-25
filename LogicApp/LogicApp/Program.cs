bool isRainy = false;
bool hasUmbrella = true;

// Logical operators
// AND &&
// OR ||
// NOT !

// Variants of OR statements
// true || true --> true
// true || false --> true
// false || true --> true
// false || false --> false


// Variants of AND statements
// true && true --> true 
// true && false --> false
// false && true --> false
// false && false --> false 

if (isRainy && !hasUmbrella)
{
    Console.WriteLine("IM getting wet");
}

if (isRainy && hasUmbrella)
{
    Console.WriteLine("Its rainy and im protected");
}

if (!isRainy || hasUmbrella)
{
    Console.WriteLine("Im not getting wet");
}


// Relational operators < <= > >=

int age = 25;

if (age >= 18)
{
    Console.WriteLine("Go party");
}
else if(age >=6)
{
    Console.WriteLine("Go party in school");
}
else
{
    Console.WriteLine("U are not permited to party");
}

// equality operator and not equal
int num1 = 0;
int num2 = 0;

bool isEqual = num1 == num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("Please enter a whole number:");
if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are equal");
}
else
{ 
    Console.WriteLine("Numbers aren't equal");
}


//Nested if statement

int numb1 = 0;
int numb2 = 0;
bool isEquall = num1 == num2;
bool isNotEquall = num1 != num2;
Console.WriteLine("Please enter a whole number:");
if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are equal");
    Console.WriteLine("Please enter your age:");
    int agee = int.Parse(Console.ReadLine());
    if (age > 18)
    {
        Console.WriteLine("You will receive a gift!");
    }
    else
    {
        Console.WriteLine("Sorry, no gift for you.");
    }
}
else
{
    Console.WriteLine("Numbers aren't equal");
}


Console.ReadKey();
