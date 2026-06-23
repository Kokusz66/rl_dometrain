//arrays:

int[] numbers = new int[3];

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;

int firstNumber = numbers[0];
int secondNumber = numbers[1];

int[] numbers2 = new int[]
{
    5,6,7,8,
};

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"numbers {i} element: {numbers[i]}");
    Console.WriteLine($"numbers2 {i} element: {numbers2[i]}");
}

//{}
double[] numbers3 = 
{
    9.1,10.1,11.1,
};

//[]
int[] numbers4 =
[
    3,4,5,
];

int length = numbers.Length;

Console.WriteLine(length);