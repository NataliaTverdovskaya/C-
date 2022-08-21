// Напишите программу, которая выдает натуральные числа от 1 до N

Console.Clear();

//метод считывает N 
int ReadData()
{
    Console.WriteLine ("Введите количество чисел: ");
    return int.Parse(Console.ReadLine());
}

int PrintNumbers(int n)
   {
    if (n == 2) return 1; 
    else
    {
        n--;
        Console.WriteLine(n);
        Console.Write(PrintNumbers(n) + " ");
    }
    return n;
   }
int n = ReadData();
PrintNumbers(n+2);