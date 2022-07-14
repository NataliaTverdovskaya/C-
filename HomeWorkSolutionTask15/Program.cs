Console.Write("Введите число от 1 до 7: ");

string? inputNumber = Console.ReadLine();

if (inputNumber != null)
{
    int number = int.Parse(inputNumber);
    if ((number < 8) & (number != 0))
    {
        if ((number == 6) || (number == 7))
        {
            Console.WriteLine("Это выходной");
        }
        else
        {
            Console.WriteLine("Это не выходной");
        }
    }
    else
    {
       Console.WriteLine("Некорректное число"); 
    }
}