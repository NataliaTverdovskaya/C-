//заполнение массива
int[] ArrayCreation()
{
    int i = 0;
    int[] array = new int[123];
    System.Random numberSintezator = new Random();
    while (i < 123)
    {
        array[i] = numberSintezator.Next();
        i++;
    }
    return array;
}

//выводит массив
void PrintArray(int[] array)
{
    Console.Write("[");
    Console.Write(string.Join(",", array));
    Console.WriteLine("]");
}

//решение задачи 35
int CalculateTask(int[] array, int downBoarder, int upBoarder)
{
    int count = 0;
    int i = 0;
    while (i < array.Length)
    {
        if (array[i] > downBoarder && array[i] < upBoarder)
        {
            count++;
        }
        i++;
    }
    return count;
}

int[] bufArray = ArrayCreation();
PrintArray(bufArray);
Console.WriteLine("Количество элементов массива: " + CalculateTask(bufArray,10,99));
