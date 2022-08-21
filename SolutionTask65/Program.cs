// Задайте значения M и N. Напишите программу, которая выдает натуральные числа от M до N

Console.Clear();

int m = ReadData("Введите M: ");
int n = ReadData("Введите N: ");

if (m<n) PrintNumbers(m, n);
else PrintNumbers(n, m);

//метод считывает 
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}
void PrintNumbers(int number1, int number2)
{
    if (number1-1==number2) return;
    Console.Write (number1 + " ");
    PrintNumbers(number1+1, number2);
  }


