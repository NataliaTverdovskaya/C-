// Задайте двухмерный массив. Напишите программу, которая меняет местами первую и последнюю строки

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

//меняет 1ую и последнюю строки 
void RotateRowFirstLast(ref int[,] inputArray)
{
    int bufferElement = 0;
    int i = 0;
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        bufferElement = inputArray[i,j];
        inputArray[i,j] = inputArray[inputArray.GetLength(0)-1,j];
        inputArray[inputArray.GetLength(0)-1,j] = bufferElement;
    }
}

int[,] bufArray = FillTwoDimArray(5, 5);
PrintTwoDimArray(bufArray);
Console.WriteLine("");

RotateRowFirstLast(ref bufArray);
PrintTwoDimArray(bufArray);
