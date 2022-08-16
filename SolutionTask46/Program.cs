//Задайте двумерный массив размером m×n, заполненный случайными целыми числами

ConsoleColor[] col = new ConsoleColor[] {ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Yellow};

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
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintColorTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0,4)];
            Console.Write(array[i,j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int[,] testArray = FillTwoDimArray(10, 10);
PrintTwoDimArray(testArray);
PrintColorTwoDimArray(testArray);