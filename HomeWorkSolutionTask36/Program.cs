//заполнение массива случайными числами
int[] ArrayCreation()
{
    int i = 0;
    int[] array = new int[123];
    System.Random numberSintezator = new Random();
    while (i < 123)
    {
        array[i] = numberSintezator.Next(0, 1000);
        i++;
    }
    return array;
}

//вывод массива на экран
void PrintArray(int[] array)
{
    Console.Write("[");
    Console.Write(string.Join(",", array));
    Console.WriteLine("]");
}

//подсчет суммы элементов, стоящих на нечётных позициях
int CalculateTask(int[] array)
{
    int resultSum = 0;
    int i = 0;
    while (i< array.Length)
    {
        resultSum = resultSum + array[i];
        i = i+2;
    }
    return resultSum;
}

int[] bufArray = ArrayCreation();
PrintArray(bufArray);
Console.WriteLine("Cумма элементов, стоящих на нечётных позициях: " + CalculateTask(bufArray));
