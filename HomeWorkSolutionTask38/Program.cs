//заполнение массива случайными числами
int[] ArrayCreation()
{
    int i = 0;
    int[] array = new int[12];
    System.Random numberSintezator = new Random();
    while (i < 12)
    {
        array[i] = numberSintezator.Next(-100,100);
        i++;
    }
    return array;
}

//вывод массива на экран
void PrintArray(int[] array)
{
    Console.Write("[");
    Console.Write(string.Join("; ", array));
    Console.WriteLine("]");
}

//подсчет разницы между максимальным и минимальным элементами массива
int CalculateTask(int[] array)
{
    int min = 0;
    int max = 0;
    int result = 0;
    int i = 0;
    while (i< array.Length)
    {
        if (max < array[i])
        {
            max= array[i];
        }
        if (min > array [i])
        {
            min= array[i];
        }
        i++;
    }
    result = max-min;
    return result;
}

int[] bufArray = ArrayCreation();
PrintArray(bufArray);
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + CalculateTask(bufArray));