using System.Globalization;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public class Person
    {
        private string _name;

        public Person(string name)
        {
            this._name = name;
        }

        public string GetName()
        {
            return this._name;
        }

        public void SetName(string name) 
        {
            this._name = name;
        }

        
    }

    public class Person2
    {
        private string _name = "Jhon";
        private string _anotherName { get; set; }

        public string MutableName
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person2(string anotherName)
        {
            this._anotherName = anotherName;
        }

    private static void Main(string[] args)
    {
        Person p = new Person("Jancsi");

        Console.WriteLine(p.GetName());
        string newName = "Zsolti";
        p.SetName(newName);
        Console.WriteLine(p.GetName());

        Person2 p2 = new Person2("Dgyula");
            Console.WriteLine(p2._name);
        p2.MutableName = newName;
            Console.WriteLine(p2._name);
        
        }
    }


}