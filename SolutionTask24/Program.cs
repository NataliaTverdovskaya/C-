Console.Clear();
Console.Write("Введите число: ");

int inputNumber = int.Parse(Console.ReadLine());
int t;
void VariantSimple()
{
    long sumOfNumber = 0;
    for (long i = 1; i<= inputNumber; i++)
    {
        sumOfNumber+=i;
        //sumOfNumber=sumOfNumber+i;
    }
    Console.WriteLine("Сумма чисел от 1 до "+inputNumber+" равна "+sumOfNumber);
}

void VariantGauss()
{
    long sumOfNumber = 0;
    sumOfNumber = (inputNumber*(inputNumber+1))/2;
    Console.WriteLine("Сумма чисел от 1 до "+inputNumber+" равна "+sumOfNumber);
}

t = Environment.TickCount;
VariantSimple();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
VariantGauss();
Console.WriteLine("Gauss time: {0} ms", Environment.TickCount - t);
