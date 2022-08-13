// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int m = 0;
int[] numbers = new int[m];

// считывает числа, которые вводит пользователь
int[] ReadNumbers (int m)
{
    int[] array = new int[m];
    Console.Write($"Введите {m} чисел: ");
    for (int i = 0; i < m; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

//считает сколько чисел больше 0
int CalculateTask (int[] inputArray)
{
    int answer = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i]>0)
        {
            answer++;
        }
    }
    return answer;
}

//выводит массив
void PrintArray(int[] array)
{
    Console.Write("[");
    Console.Write(string.Join(",", array));
    Console.WriteLine("]");
}

numbers = ReadNumbers(10);
PrintArray(numbers);
Console.Write ("Количество чисел больше 0: " + CalculateTask(numbers));

