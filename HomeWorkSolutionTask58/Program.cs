// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//заполнение двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    int[,] array = new int[countRow, countColumn];
    System.Random numberSintezator = new Random();
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array[i, j] = numberSintezator.Next(0, 10);
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

//метод вычисляет произведение двух матриц и заполняет новый массив
int[,] ProdMatrixCalculate(int[,] inputArray1, int[,] inputArray2)
{
    int[,] prodMatrix = new int[inputArray1.GetLength(0), inputArray1.GetLength(1)];
    int i = 0;
    while (i < inputArray1.GetLength(0))
    {
        int j = 0;
        while (j < inputArray1.GetLength(1))
        {
            prodMatrix[i, j] = inputArray1[i, j] * inputArray2[i, j];
            j++;
        }
        i++;
    }
    return prodMatrix;
}

int[,] bufArray1 = FillTwoDimArray(5, 5);
PrintTwoDimArray(bufArray1);
Console.WriteLine("");

int[,] bufArray2 = FillTwoDimArray(5, 5);
PrintTwoDimArray(bufArray2);
Console.WriteLine("");

int[,] resultArray = ProdMatrixCalculate(bufArray1, bufArray2);
PrintTwoDimArray(resultArray);
