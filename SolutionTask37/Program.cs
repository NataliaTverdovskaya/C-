//заполнение массива
int[] ArrayCreation()
{
    int i = 0;
    int[] array = new int[123];
    System.Random numberSintezator = new Random();
    while (i < 123)
    {
        array[i] = numberSintezator.Next(-100, 100);
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

//решение задачи 37
int[] CalculateTask(int[] array)
{
    int[] resultArray = new int[array.Length / 2 + 1];
    int i = 0;

    while (i < resultArray.Length)
    {
        resultArray[i]=array[i]*array[array.Length-1-i];
        i++;
    }

    return resultArray;
}

int[] bufArray = ArrayCreation();
PrintArray(bufArray);
int[] resultArray = CalculateTask(bufArray);
PrintArray(resultArray);