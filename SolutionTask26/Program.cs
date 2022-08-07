Console.Clear();
Console.Write("Введите число: ");

string inputLineNumber = Console.ReadLine()??"";
long inputNumber = long.Parse(inputLineNumber);

DateTime timePoint = DateTime.Now;

long VariantChar()
{
    // long numberLength = 0;
    // char[] array = inputLineNumber.ToCharArray();
    // numberLength = array.Length; 
    return inputLineNumber.ToCharArray().Length;
}


long VariantSimple()
{
    long numberLength = 0;
    long digits = 1;
    while (digits<inputNumber)
    {
        digits=digits*10;
        numberLength++;
    }
    return numberLength;
}

long VariantLog10()
{
    return (long) Math.Log10(inputNumber)+1;
}

long result = 0;

timePoint = DateTime.Now;
result = VariantChar ();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now-timePoint);

timePoint = DateTime.Now;
result = VariantSimple ();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now-timePoint);

timePoint = DateTime.Now;
result = VariantLog10 ();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now-timePoint);