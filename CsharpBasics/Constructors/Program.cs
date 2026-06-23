
ExplicitConstructor explicitConstructor = new ExplicitConstructor();


Console.WriteLine("Give me something:");
string text = Console.ReadLine();
string message = "This is the default message!";

ConstructorWithParameter constructorWithParameter = new ConstructorWithParameter(text);
ConstructorWithParameter constructorWithParameter2 = new ConstructorWithParameter(message);

OurCollectionOfWords ourCollectionOfWords = new OurCollectionOfWords();
OurCollectionOfWords2 ourCollectionOfWords2 = new(new List<string> { "World", "Hello" });
string s1 = "alma";
string s2 = "barack";
string s3 = "szilva";

ourCollectionOfWords.Add(s1);
ourCollectionOfWords.Add(s2);
ourCollectionOfWords.Add(s3);
ourCollectionOfWords.Add(text);
ourCollectionOfWords.Add(message);

ourCollectionOfWords.Print();
ourCollectionOfWords2.Print();


class ImplicitConstructor
{
    //nem látod de ott van automatikusan
}

class ExplicitConstructor
{
    public ExplicitConstructor()
    {
        Console.WriteLine("written const. called.");
    }
}

class ConstructorWithParameter
{
    public ConstructorWithParameter(string message)
    {
        Console.WriteLine($"{message}");
    }
}

class MultipleConstructor
{
    public MultipleConstructor()
    {
    }

    public MultipleConstructor(string message)
    {
        Console.WriteLine(message);
    }
}

class OurCollectionOfWords
{
    private List<string> _strings;

    public OurCollectionOfWords()
    {
        _strings = new List<string>();
    }

    public void Add(string word)
    {
        _strings.Add(word);
    }

    public void Print()
    {
        Console.WriteLine("The elements of _strings:");
        foreach (var word in _strings)
        {
            Console.WriteLine(word);
        }
        Console.WriteLine("The end.");
    }
}

class OurCollectionOfWords2
{
    private List<string> _strings;

    public OurCollectionOfWords2(List<string> list)
    {
        _strings = list;
    }

    public void Print()
    {
        Console.WriteLine("The elements of _strings:");
        foreach (var word in _strings)
        {
            Console.WriteLine(word);
        }
        Console.WriteLine("The end.");
    }
}
