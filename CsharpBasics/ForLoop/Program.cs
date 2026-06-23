//for loop:

for (int i=0; i<10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n");

for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        Console.WriteLine("See ya next time!");
        break;
    }
    Console.WriteLine(i);
}

Console.WriteLine("\n");

for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        Console.WriteLine("Not again!");
        continue;
    }
    Console.WriteLine(i);
}

Console.WriteLine("\n");