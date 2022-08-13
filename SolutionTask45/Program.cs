// Напишите программу, которая будет создавать копию заданного одномерного массива 
//с помощью поэлементного копирования.

int[] CopyArrayStandartTool(int[] inputArray)
{
    int[] buferArray = new int[inputArray.Length];
    // for (int i = 0; i < inputArray.Length; i++)
    // {
    //     buferArray[i] = inputArray [i];
    // }
    inputArray.CopyTo(buferArray,0);
    
    return buferArray;
}

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

int[] newArray = ArrayCreation(10);
PrintArray(newArray);
int[] copyArray = CopyArrayStandartTool (newArray);
PrintArray(copyArray); 