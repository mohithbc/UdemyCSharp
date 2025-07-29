double currentScore;
double sum =0;
double counter = 0;

do
{
    Console.WriteLine("Enter your students score enter -1 to finish");
    currentScore = double.Parse(Console.ReadLine());
    if (currentScore != -1)
    {
        sum = sum + currentScore;
        counter++;
    }
} while (currentScore != -1);
double average = Math.Round(sum / counter,3);
Console.WriteLine($"The average of {sum}/{counter} = {average.ToString()}");
Console.ReadKey();
