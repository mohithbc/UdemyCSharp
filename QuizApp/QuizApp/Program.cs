string question1 = "What is the capital of INDIA";
string answer1 = "delhi";

string question2 = "What is 2+2";
string answer2 = "4";

string question3 = "What is 5*5";
string answer3 = "25";

int score = 0;

Console.WriteLine(question1);
string userAns1 = Console.ReadLine().ToLower().Trim();
if(userAns1 == answer1)
{
    Console.WriteLine("Correct!");
    score = score+1;
}
else
{
    Console.WriteLine($"Wrong the correct answer is : {answer1}");
}

Console.WriteLine(question2);
string userAns2 = Console.ReadLine().ToLower();
if (userAns2 == answer2)
{
    Console.WriteLine("Correct!");
    score = score + 1;
}
else
{
    Console.WriteLine($"Wrong the correct answer is : {answer2}");
}

Console.WriteLine(question3);
string userAns3 = Console.ReadLine().ToLower();
if (userAns3 == answer3)
{
    Console.WriteLine("Correct!");
    score = score + 1;
}
else
{
    Console.WriteLine($"Wrong the correct answer is : {answer3}");
}

Console.WriteLine($"Quiz completed your score is {score}/3 ");
if(score == 3)
{
    Console.WriteLine("Excelent you got all correct");
}
else if (score > 0)
{
    Console.WriteLine("Good job keep practicing");
}
else
{
    Console.WriteLine("Try again if you can get some answers correct");
}

Console.ReadKey();