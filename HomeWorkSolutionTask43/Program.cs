// Напишите программу, которая найдёт точку пересечения двух прямых, заданных
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

double k1 = 0;
double k2 = 0;
double b1 = 0;
double b2 = 0;
double x = 0;
double y = 0;

// считывает числа, которые вводит пользователь
void ReadNumbers()
{
    Console.Write("Введите число к1: ");
    k1 = double.Parse(Console.ReadLine());
    Console.Write("Введите число к2: ");
    k2 = double.Parse(Console.ReadLine());
    Console.Write("Введите число b1: ");
    b1 = double.Parse(Console.ReadLine());
    Console.Write("Введите число b2: ");
    b2 = double.Parse(Console.ReadLine());

    Console.WriteLine ($"Получили отрезки с координатами {k1};{k2} и {b1};{b2}");
}


//считает координаты пересечения двух прямых
void CalculateTask()
{
    x = (b2-b1)/(k1-k2);
    y=k1*x+b1;
}

//выводит ответ
void PrintAnswer(double x, double y)
{
    Console.Write($"Точка пересечения двух прямых: {x};{y}");
}

ReadNumbers();
CalculateTask();
PrintAnswer(x,y);