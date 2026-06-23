internal class Program
{
    static class MyStaticClass
    {
        public static void MyStaticMethod()
        {
            Console.WriteLine("I am a static method in a static class.");
        }
    }

    public class NonstaticClass
    {
        public string MyInstanceProperty { get; set; }
        public static string MyStaticProperty { get; set; }

        public static void MyStaticMethod()
        {
            Console.WriteLine($"The static property value is {MyStaticProperty}");
        }

        public void MyInstanceMethod()
        {
            Console.WriteLine(MyInstanceProperty);
            Console.WriteLine(MyStaticProperty);
        }

    }

    private static void Main(string[] args)
    {
        MyStaticClass.MyStaticMethod();

        NonstaticClass n1 = new NonstaticClass();
        n1.MyInstanceProperty = "cuccli";
       
        NonstaticClass n2 = new NonstaticClass();
        n2.MyInstanceProperty = "muccli";
     

        Console.WriteLine("Before mutating properties on static class...");
        n1.MyInstanceMethod();
        n2.MyInstanceMethod();
        n1.MyInstanceMethod();
        n2.MyInstanceMethod();
    }
}