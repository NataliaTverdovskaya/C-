int[] array = new int[12];

int[] ArrayCreation()   //заполнение массива
{
    int i = 0;
    System.Random numberSintezator = new Random();
    while (i < 12)
    {
        array[i] = numberSintezator.Next(-9, 10);
        i++;
    }
    return array;
}

//подсчет сумм и их вывод
void Sum(int[] array)
{
    int i = 0;
    int sumPos = 0;
    int sumNeg = 0;
    while (i < 12)
    {
        if (array[i] > 0)
        {
            sumPos = sumPos + array[i];
        }
        else
        {
            sumNeg = sumNeg + array[i];
        }
        i++;
    }
    Console.WriteLine("Сумма положительных чисел: " + sumPos);
    Console.WriteLine("Сумма отрицательных чисел: " + sumNeg);
}
//выводит массив
void PrintArray (int[] array)
{
    Console.Write("[");
Console.Write(string.Join(",", array));
Console.WriteLine("]");
}


array = ArrayCreation();
PrintArray(array);
Sum(array);
