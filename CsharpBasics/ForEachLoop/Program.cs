//Foreach:

int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("\n");

List<string> words = new List<string>
{
    "red",
    "green",
    "blue",
};

foreach (string word in words)
{
    Console.WriteLine(word);
}

Console.WriteLine("\n");

Dictionary<string, int> ages = new()
{
    {"Alice", 25 },
    {"Bob", 24 },
    {"Charlie", 26 },
};

foreach (var person in ages)
{
    Console.WriteLine($"{person.Key} is {person.Value} years old.");
}

//break és continue ugyanúgy működik itt is