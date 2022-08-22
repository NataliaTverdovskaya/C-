// Напишите программу, которая на вход принимает 2 числа А и В
// и возводит число А в целую степень В с помощью рекурсии


Console.Clear();

int a = ReadData("Введите A: ");
int b = ReadData("Введите B: ");

DateTime d = DateTime.Now;
int res1 = PowNumbers(a, b);
Console.WriteLine(DateTime.Now-d);

d = DateTime.Now;
int res2 = MyPow(a, b);
Console.WriteLine(DateTime.Now-d);

d = DateTime.Now;
double res3 = Math.Pow(a,b);
Console.WriteLine(DateTime.Now-d);

Console.WriteLine(res1);
Console.WriteLine(res2);
Console.WriteLine(res3);

//метод считывает 
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

int MyPow(int numberA, int numberB)
{
    if (numberB == 2) return numberA * numberA;
    if (numberB == 1) return numberA;
    if (numberB % 2 == 0)
    {
        return MyPow(numberA, numberB / 2) * MyPow(numberA, numberB / 2);
    }
    else
    {
        return MyPow(numberA, numberB / 2) * MyPow(numberA, (numberB / 2) + 1);
    }
}

int PowNumbers(int numberA, int numberB)
{
    if (numberB == 1) return numberA;

    return numberA * PowNumbers(numberA, numberB - 1);
}
