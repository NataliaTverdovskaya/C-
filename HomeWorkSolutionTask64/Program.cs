// Напишите программу, которая выдает натуральные числа от 1 до N

Console.Clear();

int number = ReadData();
PrintNumbers(number);

//метод считывает N 
int ReadData()
{
    Console.WriteLine("Введите количество чисел: ");
    return int.Parse(Console.ReadLine());
}

int PrintNumbers(int n)
{
    if (n == 1)
    {
        Console.Write(1);
        return 1;
    }
    else
    {
        Console.Write(n + " ");
        n = PrintNumbers(n - 1);
        return n;
    }
}

