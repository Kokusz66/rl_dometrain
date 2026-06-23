//Arguments

void PrintSeparator()
{
    Console.WriteLine("----------");
}


void PrintHeader(string name)
{
    PrintSeparator();
    Console.WriteLine(name);
    PrintSeparator();
}

void MyMethod(string name, int age)
{
    PrintHeader(name);
    Console.WriteLine(age);
}

MyMethod("Józsi", 20);