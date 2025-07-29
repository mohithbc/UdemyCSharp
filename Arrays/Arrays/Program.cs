// declare an array
int[] myArray = new int[5];

// indexes [0] [1] [2] [3] [4]
// content [5] [10] [15] [20] [25]

// Assigned values to the array
myArray[0] = 5;
myArray[1] = 10;
myArray[2] = 15;
myArray[3] = 20;
myArray[4] = 25;

// declare an array and set the array elements value
int[] myIntArray = [1, 2, 3, 4, 5, 6, 7];

// declaring the string arrays for weekdays
string[] weekdays = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

Console.WriteLine("Length of the weekdays array is : " + weekdays.Length);
for (int i = 0; i < weekdays.Length; i++)
{
    Console.WriteLine(weekdays[i]);
}

foreach (var item in weekdays)
{
    Console.WriteLine(item);
}



// Two dimentional arrays

int[,] array2Ddeclaration = new int[3,3];
// [0] [0] [0]
// [0] [0] [0]
// [0] [0] [0]

// Three dimentional arrays 
int[,,] array3Ddeclaration = new int[3, 3, 3];

int[,] array2DInitilization = { { 1, 2 }, { 3, 4 } };
//[1] [2]
//[3] [4]

string[,] ticTac =
{
    {"o", "X", "x" },
    { "o", "o", "o" },
    { "x", "X", "o" }
};

Console.WriteLine(array2DInitilization[0,0]);



Console.WriteLine(myArray);