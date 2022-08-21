// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.Clear();
int numberN = ReadData("Введите N: ");
int numberM = ReadData("Введите M: ");

Console.WriteLine(Akk(numberN,numberM));

// метод считывает входящие данные
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

// функция Аккермана
int Akk(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akk(n - 1, 1);
    else
      return Akk(n - 1, Akk(n, m - 1));
}
