Console.Clear();
Console.Write("Введите число: ");
int inputNumber = int.Parse(Console.ReadLine());

int t;

int Sum()
{
int sum = 0;
while (inputNumber>0)
{
    sum = sum + inputNumber%10;
    inputNumber=inputNumber/10;
}
    return sum;
}

t = Environment.TickCount;
Console.WriteLine("Сумма цифр: "+Sum());
Console.WriteLine("Sum time: {0} ms", Environment.TickCount - t);