// составить частотный словарь элементов двухмерного массива. Частотны   словарь содержит информацию 
// о том, сколько раз встречается элемент входных данных

// array = [1,1,1,3,4,3,4,5]
// alphabet = [1,3,2,5]
// frequency = [3,2,2,1]

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

//выводит одномерный массив
void PrintArray(int[] array)
{
    Console.Write("[");
    Console.Write(string.Join(",", array));
    Console.WriteLine("]");
}

// метод создает частотный словарь
int[] FrequencyCollect(int[,] inputArray, int alphabetLength)
{
    int[] resultArray = new int[alphabetLength];
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(0); j++)
            {
                //собираем частоту появления элементов
              resultArray[inputArray[i,j]]++;
            }
        }
    return resultArray;
}

int[,] bufArray = FillTwoDimArray(10, 10);
PrintTwoDimArray(bufArray);
Console.WriteLine("");

int[] frequencyArray = FrequencyCollect(bufArray,10);
PrintArray(frequencyArray);

