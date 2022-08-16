// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.

// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

//методы, которые считывают позицию элемента в двухмерном массиве
int ReadM()
{
    Console.Write("Введите строку: ");
    int m = int.Parse(Console.ReadLine());
    return m;
}
int ReadN()
{
    Console.Write("Введите столбец: ");
    int n = int.Parse(Console.ReadLine());
    return n;
}

//заполнение двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    int[,] array = new int[countRow, countColumn];
    System.Random numberSintezator = new Random();
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array[i, j] = numberSintezator.Next(-100,100);
            //Console.WriteLine("");
        }
    }
    return array;
}

//выводит двухмерный массив
void PrintColorTwoDimArray(int[,] array)
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

void PrintAnswer (int[,] inputArray, int row, int column)
{
    if (inputArray[row,column] == null)
    {
        Console.WriteLine ("Значения с таким индексом не существует");
    }
    else
    {
        Console.WriteLine (inputArray[row,column]);
    }
}


int[,] bufArray = FillTwoDimArray(10, 10);
PrintColorTwoDimArray(bufArray);
Console.WriteLine("");

int m = ReadM()-1;
int n = ReadN()-1;
PrintAnswer(bufArray, m, n);
