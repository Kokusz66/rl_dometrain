//Return type:
int Add(int a, int b)
{
    return a + b;
}

int sum = Add(5, 3);

int x = 5;
int y = 3;
int sum2 = Add(y, x);

int sum3 = Add(Add(1, 2), Add(3, 4));

Console.WriteLine(sum);
Console.WriteLine(sum2);
Console.WriteLine(sum3);