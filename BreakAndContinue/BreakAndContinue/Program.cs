for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
    if(i == 3)
    {
        Console.WriteLine("i had enough\n");
        break;
    }
}

for (int j = 0; j <= 10; j++)
{
    Console.WriteLine(j);
    if (j == 3)
    {
        continue;
    }
    Console.WriteLine("im eating");
}