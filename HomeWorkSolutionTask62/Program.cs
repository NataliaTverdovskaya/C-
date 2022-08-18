// Заполните спирально массив 4 на 4.

//заполнение двумерного массива спирально
int[,] FillSpiralTwoDimArray(int row, int column)
{
    int[,] spiralMatrix = new int[row, column];

    int fillNumber = 1;
    int i = 0;
    int j = 0;

    while (fillNumber <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
    {
        spiralMatrix[i, j] = fillNumber;
        fillNumber++;
        if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1) j++;
        else
            if (i < j && i + j >= spiralMatrix.GetLength(0) - 1) i++;
            else
                if (i >= j && i + j > spiralMatrix.GetLength(1) - 1) j--;
                else i--;
    }
    return spiralMatrix;
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

int[,] spiralArray = FillSpiralTwoDimArray(5, 5);
PrintTwoDimArray(spiralArray);
