// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти
//элементы на их квадраты.

ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Yellow };

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
void PrintColorTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 4)];
            Console.Write(array[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

//решение задачи. создает новый массив
int[,] NewDimArray(int[,] dimArray)
{
    int[,] outArray = new int[dimArray.GetLength(0), dimArray.GetLength(1)];
    for (int i = 0; i < dimArray.GetLength(0); i++)
    {
        for (int j = 0; j < dimArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                outArray[i, j] = dimArray[i, j] * dimArray[i, j];
            }
            else
                outArray[i, j] = dimArray[i, j];
        }
    }
    return outArray;
}

void NewDimArrayRef(ref int[,] dimArray)
{
    for (int i = 0; i < dimArray.GetLength(0); i++)
    {
        for (int j = 0; j < dimArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                dimArray[i, j] = dimArray[i, j] * dimArray[i, j];
            }
            else
                dimArray[i, j] = dimArray[i, j];
        }
    }
}


int[,] testArray = FillTwoDimArray(10, 10);
PrintColorTwoDimArray(testArray);
Console.WriteLine("");

DateTime d = DateTime.Now;
PrintColorTwoDimArray(NewDimArray(testArray));
Console.WriteLine("");
Console.WriteLine(DateTime.Now-d);
Console.WriteLine("");

d = DateTime.Now;
NewDimArrayRef(ref testArray);
PrintColorTwoDimArray(testArray);
Console.WriteLine("");
Console.WriteLine(DateTime.Now-d);