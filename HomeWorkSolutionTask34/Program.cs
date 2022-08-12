//заполнение массива случайными положительными 3х значными числами
int[] ArrayCreation()
{
    int i = 0;
    int[] array = new int[123];
    System.Random numberSintezator = new Random();
    while (i < 123)
    {
        array[i] = numberSintezator.Next(100, 1000);
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

//подсчет количества четных чисел в массиве
int CalculateTask(int[] array)
{
    int resultCount = 0;
    int i = 0;

    while (i <= array.Length - 1)
    {
        if (array[i] % 2 == 0)
        {
            resultCount++;
        }
        i++;
    }
    return resultCount;
}

//метод пузырьковой сортировки
void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            int tempJ = array[j];
            if (array[j] > array[j + 1])
            {
                tempJ = array[j + 1];
                array[j] = array[j + 1];
            }
        }
    }
}

int[] bufArray = ArrayCreation();
PrintArray(bufArray);
Console.WriteLine("Количество четных чисел в массиве: " + CalculateTask(bufArray));
BubbleSort(bufArray);
PrintArray(bufArray);

