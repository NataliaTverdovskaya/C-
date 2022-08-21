// Напишите программу, которая на вход будет принимать число и возвращать сумму его цифр

// Задайте значения M и N. Напишите программу, которая выдает натуральные числа от M до N

Console.Clear();
int number = ReadData("Введите число: ");
Console.WriteLine(Sum(number));

//метод считывает 
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

int Sum(int num)
{
    if (num > 0)
    {
        return num % 10 + Sum(num / 10);
    }
    else return 0;
}