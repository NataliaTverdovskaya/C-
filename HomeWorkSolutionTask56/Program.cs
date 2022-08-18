// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//заполнение двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    int[,] array = new int[countRow, countColumn];
    System.Random numberSintezator = new Random();
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array[i, j] = numberSintezator.Next(0, 100);
            //Console.WriteLine("");
        }
    }
    return array;
}

//выводит двухмерный массив
void PrintTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

//выводит одномерный массив
void PrintArray(int[] array)
{
    Console.Write("[");
    Console.Write(string.Join(",", array));
    Console.WriteLine("]");
}

//метод вычисляет суммы по строчкам
int[] SumRows(int[,] inputArray)
{
    int[] sumRow = new int[inputArray.GetLength(0)];
    int i = 0; int k = 0;
    while (i < inputArray.GetLength(0) && k < inputArray.GetLength(0))
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sumRow[k] = sumRow[k] + inputArray[i, j];
        }
        i++; k++;
    }
    return sumRow;
}

//метод ищет и выводит номер строки с максимальной суммой
void PrintAnswer(int[] sumRowsArray)
{
    int maxIndex = 0;
    int max = 0;
    for (int i = 0; i < sumRowsArray.Length; i++)
    {
        if (sumRowsArray[i] > max)
        {
            max = sumRowsArray[i];
            maxIndex = i;
        }
    }
    Console.WriteLine((maxIndex+1) + " строка имеет максимальную сумму");
}

int[,] twoDimArray = FillTwoDimArray(5, 5);
PrintTwoDimArray(twoDimArray);
Console.WriteLine("");

int[] bufSumRowsArray = SumRows(twoDimArray);
PrintArray(bufSumRowsArray);
Console.WriteLine("");

PrintAnswer(bufSumRowsArray);