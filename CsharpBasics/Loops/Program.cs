//Loops while loops

//while (continue)
//{
//    //valami kód
//}

//do
//{
//    //kód helye
//}
//while (condition)

//csak a feltétel teljesülésekor fog lefutni
int count = 0;
while (count < 5)
{
    Console.WriteLine(count);
    count++;
}

Console.WriteLine($"The total count is {count}!");
//egyszer mindenképpen lefut
count = 0;
do
{
    Console.WriteLine(count);
    count++;
}
while (count < 5);
Console.WriteLine($"The total count of a do while is {count}!");


count = 0;
while (count < 50)
{
    if (count == 3)
    {
        count++;
        Console.WriteLine("Skipping 3.");
        continue;
    }
    Console.WriteLine(count);
    count++;

    if (count == 5)
    {
        Console.WriteLine("Simba, it is time...");
        break;
    }
}