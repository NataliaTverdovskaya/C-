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
VariantNaive();