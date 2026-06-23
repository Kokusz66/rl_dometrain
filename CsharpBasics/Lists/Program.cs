//lists:

List<string> words = new List<string>();

words.Add("one");
words.Add("two");
words.Add("three");

string firstWord = words.First(); //words[0]
string secondWord = words[1];
string thirdWord = words[2];
string lastWord = words.Last();

foreach (string word in words)
{
    Console.WriteLine(word);
}

List<int> numbers = new List<int>
{
    1,
    2,
    3,
    4,
};

int count = numbers.Count; //4

numbers.Remove(1);
numbers.Remove(2);
numbers.Remove(3);

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}

numbers.Insert(0, 1);
numbers.Insert(0, 2);
numbers.Insert(1, 3);

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}

numbers.Clear();

if (numbers.Count == 0)
{
    Console.WriteLine("The numbers list is empty.");
}

words.Sort();
numbers.Add(10);
numbers.Add(9);
numbers.Add(-2);
numbers.Add(40);
numbers.Add(22);
numbers.Sort();

foreach (string word in words)
{
    Console.WriteLine(word);
}

foreach (int num in numbers)
{
    Console.WriteLine(num);
}