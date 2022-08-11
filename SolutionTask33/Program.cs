//заполнение массива
int[] ArrayCreation()
{
    int i = 0;
    int[] array = new int[12];
    System.Random numberSintezator = new Random();
    while (i < 12)
    {
        array[i] = numberSintezator.Next(-9, 10);
        i++;
    }
    return array;
}

//выводит массив
void PrintArray(int[] array)
{
    Console.Write("[");
    Console.Write(string.Join(",", array));
    Console.WriteLine("]");
}

//решение задачи 33
bool CalculateTask(int[] inputArray, int searchNumber)
{
    bool resultSearch = false;
    int i = 0;
    while (i<12)
    {
        if (inputArray[i]==searchNumber)
        {
            resultSearch=true;
            break;
        }
        i++;
    }
    return resultSearch;
}

int[] bufArray = ArrayCreation();
PrintArray(bufArray);
Console.WriteLine("Введите число для поиска: ");
int searchNumber = int.Parse(Console.ReadLine());

Console.WriteLine(CalculateTask(bufArray, searchNumber));

