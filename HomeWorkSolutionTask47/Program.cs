// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//* При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

//ввод размера массива
int ReadM()
{
    Console.Write("Введите количество строк: ");
    int m = int.Parse(Console.ReadLine());
    return m;
}
int ReadN()
{
    Console.Write("Введите количество столбцов: ");
    int n = int.Parse(Console.ReadLine());
    return n;
}

//заполнение двумерного массива
double[,] FillTwoDimArray(int countRow, int countColumn)
{
    double[,] array = new double[countRow, countColumn];
    System.Random numberSintezator = new Random();
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array[i, j] = numberSintezator.Next();
            //Console.WriteLine("");
        }
    }
    return array;
}

//выводит двухмерный массив
void PrintColorTwoDimArray(double[,] array)
{
    ConsoleColor[] col = new ConsoleColor[] {ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan ,
                                                ConsoleColor.Gray , ConsoleColor.Green , ConsoleColor.Red ,
                                                ConsoleColor.White , ConsoleColor.DarkBlue , ConsoleColor.DarkCyan ,
                                                ConsoleColor.DarkGray , ConsoleColor.DarkGreen , ConsoleColor.DarkMagenta ,
                                                ConsoleColor.DarkRed , ConsoleColor.DarkYellow, ConsoleColor.Magenta,
                                                ConsoleColor.Yellow };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(array[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

//вносит изменения в массив
void UpdateDimArray(ref double[,] twoDimArray)
{
    System.Random numberSintezator = new Random();
    for (int i = 0; i < twoDimArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimArray.GetLength(1); j++)
        {
            twoDimArray[i, j] = Math.Round(numberSintezator.NextDouble() * (100 + 100) - 100, 2);
        }
    }
}


int m = ReadM();
int n = ReadN();

double[,] testArray = FillTwoDimArray(m, n);
PrintColorTwoDimArray(testArray);
Console.WriteLine("");

UpdateDimArray(ref testArray);
PrintColorTwoDimArray(testArray);
