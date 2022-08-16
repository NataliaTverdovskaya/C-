// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ =
// m+n. Выведите полученный массив на экран.

int m = 0;
int n = 0;

m = ReadM();
n = ReadN();
int[,] testArray = FillTwoDimArray(m, n);
PrintTwoDimArray(testArray);

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
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    int[,] array = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array[i, j] = i + j;
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

