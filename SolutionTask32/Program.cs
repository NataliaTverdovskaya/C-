
//заполнение массива
int[] ArrayCreation()
{
    int i = 0;
    int[] array = new int[12];
    System.Random numberSintezator = new Random();
    while (i < 12)
    {
        array[i] = numberSintezator.Next(-9, 10);
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

//замена чисел и вывод нового массива
void NewArray(int[] array)
{
    int i = 0;
    int[] arrayNew = new int[12];
    while (i < 12)
    {
        arrayNew[i] = array[i] * (-1);
        i++;
    }
    Console.Write("[");
    Console.Write(string.Join(",", arrayNew));
    Console.Write("]");
}

int[] buffArray = ArrayCreation();
PrintArray(buffArray);
NewArray(buffArray);