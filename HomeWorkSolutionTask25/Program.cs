Console.Clear();
Console.Write("Введите число: ");
double inputNumber1 = double.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
double inputNumber2 = double.Parse(Console.ReadLine());

double VariantMath()
{
    double result = 0;
    result = Math.Pow(inputNumber1, inputNumber2);
    return result;
}

double VariantWhile()
{
    int i = 0;
    double result = 1;
    while (i<inputNumber2)
    {
    result = result*inputNumber1;
    i++;
    }
    return result;
}

Console.WriteLine(VariantMath());
Console.WriteLine(VariantWhile());

