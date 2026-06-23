// See https://aka.ms/new-console-template for more information


if (true)
{
    Console.WriteLine("This will always print");
}

if (false) //sötétebb/fakóbb ha bele sem megy az elégazásba
{
    Console.WriteLine("This will never print");
}

bool condition = true;
if (condition)
{
    Console.WriteLine("This prints when the cond. is true!");
}
condition = false;
if (!condition)
{
    Console.WriteLine("This prints when the cond. is false!");
}

if (condition)
{
    Console.WriteLine("This prints when the cond. is true!");
}
else 
{
    Console.WriteLine("This prints when the cond. is false!");
}


if (condition)
{
    Console.WriteLine("This prints when the cond. is true!");
}
else if (!condition)
{
    Console.WriteLine("This prints when the cond. is false!");
}
else
{
    Console.WriteLine("Trick question?!"); //sosem fut le mert a bool csak true vagy false lehet
}