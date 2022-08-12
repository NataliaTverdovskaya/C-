// Задача №39
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1)
// менять числа местами в исходном массиве; 2) создать
// новый массив и в него записать перевёрнутый исходный
// массив по элементам.

//заполнение массива
int[] ArrayCreation(int arrayLenght)
{
    int i = 0;
    int[] array = new int[arrayLenght];
    System.Random numberSintezator = new Random();
    while (i < arrayLenght)
    {
        array[i] = numberSintezator.Next(-1000, 1000);
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

int[] ReversNewArray(int[] inputArray)
{
    int[] newArray = new int[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        newArray[inputArray.Length - i - 1] = inputArray[i];
    }
    return newArray;
}

int[] ReversSwapArray(int[] inputArray)
{
    int buf;
    for (int i = 0; i < inputArray.Length/2; i++)
    {
        buf=inputArray[i];
        inputArray[i]=inputArray[inputArray.Length-1-i];
        inputArray[inputArray.Length-1-i]=buf;
    }
return inputArray;
}

int[] bufArray = ArrayCreation(13);
int[] reversedArray = ReversNewArray(bufArray);
PrintArray(bufArray);
PrintArray(reversedArray);
reversedArray = ReversSwapArray(bufArray);
PrintArray(reversedArray);