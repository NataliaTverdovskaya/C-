// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

//заполнение трехмерного массива
int[,,] FillArray3D(int x, int y, int z)
{
    int[,,] array3D = new int[x, y, z];
    System.Random numberSintezator = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array3D[i, j, k] = numberSintezator.Next(0, 10);
                //Console.WriteLine("");
            }
        }
    }
    return array3D;
}

//выводит трехмерный массив
void PrintArray3D(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write(array3D[i, j, k] + $"({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] bufArray = FillArray3D(3, 3, 3);
PrintArray3D(bufArray);
Console.WriteLine("");