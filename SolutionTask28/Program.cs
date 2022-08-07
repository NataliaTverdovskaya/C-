Console.Clear();
Console.Write("Введите число: ");

int inputNumber = int.Parse(Console.ReadLine());
int t;
void VariantSimple()
{
    long prOfNumber = 1;
    for (long i = 1; i<= inputNumber; i++)
    {
        prOfNumber=prOfNumber*i;
    }
    Console.WriteLine("Произведение чисел от 1 до "+inputNumber+" равнo "+prOfNumber);
}



t = Environment.TickCount;
VariantSimple();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);
