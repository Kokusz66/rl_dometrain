//OOP:

OurClass ourClass = new OurClass();
OurClass ourClass2 = new OurClass();
OurClass ourClass3 = ourClass2;

ourClass.Greetings();
Console.WriteLine(ourClass.ExampleFunction());

List<int> myNumbers1 = new List<int> { 1, 2, 3 };
List<int> myNumbers2 = new List<int> { 1, 2, 3 };

Console.WriteLine(myNumbers1 == myNumbers2); //false más a memória címe stb...

//referenciából értékadás és egy másolat új értékadása nem változtatja meg az eredetit, példákkal bemutatva

List<string> wordsOut = new List<string> { "alma", "korte", "barack" };
ourClass.PrintList(wordsOut);


ourClass.ChangeReference(wordsOut);
ourClass.PrintList(wordsOut);

public class OurClass
{

    public OurClass()
    {
        
    }
    public void Greetings()
    {
        Console.WriteLine("Greetings Commander!");
    }

    public int ExampleFunction()
    {
        return 42;
    }

    public void ChangeReference(List<string> words)
    {
        words.Add("from");
        words.Add("Dev");
        words.Add("Leader");
    }

    public void PrintList(List<string> list)
    {
        Console.WriteLine("\n");
        foreach (string element in list)
        {
            Console.WriteLine(element);
        }
        Console.WriteLine("\n");
    }

}






