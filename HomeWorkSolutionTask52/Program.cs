//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным
// цветом

//заполнение двумерного массива
double[,] FillTwoDimArray(int countRow, int countColumn)
{
    double[,] array = new double[countRow, countColumn];
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
            Console.Write(array[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

//считает среднее арифметическое и выводит ответ
void PrintAnswer(double[,] inputArray)
{
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        double sum = 0;
        int row = 0;
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            sum = sum + inputArray[i,j];
            row = i+1;
        }
        double result = sum/row;
        //result = Math.Round(result, 2);
        Console.Write(result + "\t");
    }
    
}

double[,] bufArray = FillTwoDimArray(5, 5);
PrintColorTwoDimArray(bufArray);
Console.WriteLine("");
PrintAnswer(bufArray);