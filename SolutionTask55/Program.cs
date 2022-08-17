// Задайте двухмерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, 
// если это невозможно, выводит соответствующее сообщение

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

//меняет строки  на столбцы
int[,] RotateTwoDimArray(int[,] inputArray)
{
    if (inputArray.GetLength(0) == inputArray.GetLength(1))
    {
        int bufElement = 0;
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = i; j < inputArray.GetLength(0); j++)
            {
                bufElement = inputArray[i, j];
                inputArray[i, j] = inputArray[j, i];
                inputArray[j, i] = bufElement;
            }
        }
    }
    else
    {
        Console.WriteLine("Массив не квадратный. Замена невозможна");
    }
    return inputArray;
}

int[,] bufArray = FillTwoDimArray(5, 5);
PrintTwoDimArray(bufArray);
Console.WriteLine("");

PrintTwoDimArray(RotateTwoDimArray(bufArray));
