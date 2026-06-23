//
using CsharpBasics;

Console.WriteLine("Hello, World!");

//sime string basics:
string myString;
string my_String;
string MyString;

myString = "Hello, World!";
string coolString = "Hello, World!";
coolString = "Goodby, World!";

string firstName = "Jhon";
string lastName = "Doe";
string fullName = firstName +  " " + lastName;

Console.WriteLine(fullName);

Console.WriteLine("Tell me your name: ");

myString = Console.ReadLine();
Console.WriteLine($"Hello {myString}!");
Console.WriteLine(myString.Length);

Console.WriteLine(myString[0]);

char myChar = 'a';

//integers 4 bits:
int myInt;
int my_Int;
int MyInt;

myInt = 5;
int coolInt = 5;
Console.WriteLine(coolInt);
coolInt = 10;
Console.WriteLine(coolInt);

int sum = 5 + 10;
int difference = 5 - 10;
int product = 5 * 10;
int quotient = 5 / 10;

Console.WriteLine($"5 + 10={sum}");
Console.WriteLine($"5 - 10={difference}");
Console.WriteLine($"5 * 10={product}");
Console.WriteLine($"5 / 10={quotient}");

float myFloat = 5.5f;
double myDouble = 5.5;


float coolFloat = 10.5f;
double coolDouble = 10.5;

Float floatClass = new Float();

floatClass.SumFloat(myFloat, coolFloat);
floatClass.DifferenceDouble(myDouble, coolDouble);

BoolPlayground boolPlayground = new BoolPlayground(true, false);

bool b1 = boolPlayground.GetRight() && boolPlayground.GetLeft();
Console.WriteLine(b1);
b1 = boolPlayground.GetRight() || boolPlayground.GetLeft();
Console.WriteLine(b1);

boolPlayground.SetLeftToTrue();
bool b2 = boolPlayground.GetRight() && boolPlayground.GetLeft();
Console.WriteLine(b2);
b2 = boolPlayground.GetRight() || boolPlayground.GetLeft();
Console.WriteLine(b2);

boolPlayground.SetRigthToFalse();
boolPlayground.SetLeftToFalse();
bool b3 = boolPlayground.GetRight() && boolPlayground.GetLeft();
Console.WriteLine(b3);
b3 = boolPlayground.GetRight() || boolPlayground.GetLeft();
Console.WriteLine(b3);