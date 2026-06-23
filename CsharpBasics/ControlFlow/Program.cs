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

int number = 1;
if (number < 5)
{
    Console.WriteLine("The number is lower than 5.");
}
else if (number == 5)
{
    Console.WriteLine("The number is equeal to 5.");
}
else
{
    Console.WriteLine("The number is greater than 5.");
}

number = 4;
if (number >= 1 && number <= 5)
{
    Console.WriteLine("The number is bettwen the range 1-5.");
}
else
{
    Console.WriteLine("The number is not bettwen the range 1-5.");
}

if (number < 1 || number > 5)
{
    Console.WriteLine("The number is not bettwen 2-4.");
}
else
{
    Console.WriteLine("The number is bettwen 2-4.");
}