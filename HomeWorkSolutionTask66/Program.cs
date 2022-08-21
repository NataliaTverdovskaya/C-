// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
int sum = 0;
int m = ReadData("Введите M: ");
int n = ReadData("Введите N: ");

if (m < n) CalculateSum(m, n);
else CalculateSum(n, m);

Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} равна " + sum);

// метод считывает входящие данные
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

// рекурентный метод, который считает сумму чисел
int CalculateSum(int number1, int number2)
{
    if (number1-1 == number2) return number1;
    sum = sum+number1;
    CalculateSum(number1 + 1, number2);
    return sum;
}

