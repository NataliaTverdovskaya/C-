// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с
// индексами (0,0); (1;1) и т.д.


int sum = 0;
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
    ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Yellow };
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

//находит сумму значений
void CalculateSum(ref int[,] dimArray)
{
    for (int i = 0; i < dimArray.GetLength(0); i++)
    {
        sum = sum + dimArray[i, i];
    }
}



int[,] bufArray = FillTwoDimArray(5, 5);
PrintColorTwoDimArray(bufArray);
Console.WriteLine("");

CalculateSum(ref bufArray);
Console.WriteLine(sum);