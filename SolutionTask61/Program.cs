// Вывести первые N строк треугольника Паскаля. 
//Сделать вывод в виде равнобедренного треугольника

float factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

int i, n, c;
Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
string s = Console.ReadLine();
n = Convert.ToInt32(s);

for (i = 0; i < n; i++)
{
    for (c = 0; c <= (n - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
    {
        Console.Write(" ");
    }
    for (c = 0; c <= i; c++)
    {
        Console.Write(" "); // создаём пробелы между элементами треугольника
        Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника
    }
    Console.WriteLine();
    Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
}
//Console.ReadLine();
