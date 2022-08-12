// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины

    int sideA=0;
    int sideB=0;
    int sideC=0;

ReadSides();
bool res = TestTreangle(sideA, sideB, sideC);
PrintAnswer(res);

void ReadSides ()
{
    Console.WriteLine("Введите сторону 1: ");
    sideA = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите сторону 2: ");
    sideB = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите сторону 3: ");
    sideC = int.Parse(Console.ReadLine());
}

bool TestTreangle (int sideA, int sideB, int sideC)
{
    bool answer = ((sideA+sideA>sideC) && (sideB+sideC>sideA) && (sideC+sideA>sideB))? true : false ;
    return answer;
}

void PrintAnswer(bool answer)
{
    if (answer)
    {
        Console.Write("Их этих отрезков можно составить треугольник");
    }
    else
    {
        Console.Write("Их этих отрезков нельзя составить треугольник");
    }
}
