System.Random numberSintezator = new Random();

void VariantNaive()
{
    int i = 0;
    
    int[] array = new int[7];

    Console.Write("[");

    while (i < 7)
    {
        array[i] = numberSintezator.Next(0, 99);
        Console.Write(array[i] + ",");
        i++;
    }
    Console.Write(numberSintezator.Next(0, 99));
    Console.Write("]");
}

void Variant2 (int arrayLength, int min, int max)
{
    int i = 0;
    
    int[] array = new int[arrayLength];

    Console.Write("[");

    while (i < arrayLength-1)
    {
        array[i] = numberSintezator.Next(min, max);
        Console.Write(array[i] + ",");
        i++;
    }
    Console.Write(numberSintezator.Next(min, max));
    Console.Write("]");
}

VariantNaive();

Console.WriteLine(" ");
Console.Write ("Введите длину массива: ");
int arrayLength = int.Parse(Console.ReadLine());

Console.Write ("Введите диапазон значений элементов от: ");
int min = int.Parse(Console.ReadLine());

Console.Write ("до: ");
int max = int.Parse(Console.ReadLine());

Variant2 (arrayLength, min, max);