//OOP:

OurClass ourClass = new OurClass();

ourClass.Greetings();
Console.WriteLine(ourClass.ExampleFunction());

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


}






