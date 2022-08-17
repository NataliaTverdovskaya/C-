// задайте двумерный массив из целых счисел. Напигшите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьщий элемент

//заполнение двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    int[,] array = new int[countRow, countColumn];
    System.Random numberSintezator = new Random();
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array[i, j] = numberSintezator.Next(0, 101);
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

//метод ищет позицию минимального элемента
int[] FindMinElement(int[,] inputArray)
{
    int[] array = new int[] { 0, 0 };
    int minElement = int.MaxValue;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = i; j < inputArray.GetLength(1); j++)
        {
            if (inputArray[i, j] < minElement)
            {
                minElement = inputArray[i, j];
                array[0] = i;
                array[1] = j;
            }
        }
    }
    return array;
}

//удаляет строку и столюец из массива
int[,] UpdateTwoDimArray(int[,] inputArray, int row, int column)
{
    int[,] outArray = new int[inputArray.GetLength(0) - 1, inputArray.GetLength(1) - 1];
    int i = 0; int k = 0;
    int j = 0; int m = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0; m = 0;
        while (j < inputArray.GetLength(1))
        {
            if (i != row && j != column)
            {
                outArray[k, m] = inputArray[i, j];
            }
            if (j != column) m++;
            j++;
        }
        if (i != row) k++;
        i++;
    }
    return outArray;
}

int[,] bufArray = FillTwoDimArray(5, 5);
PrintTwoDimArray(bufArray);
Console.WriteLine("");

int[] index = FindMinElement(bufArray);
bufArray=UpdateTwoDimArray(bufArray,index[0], index[1]);
PrintTwoDimArray(bufArray);