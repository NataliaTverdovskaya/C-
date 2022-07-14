string? inputNumber = Console.ReadLine();

if (inputNumber != null)
{
    char[] number = inputNumber.ToCharArray();
    if (number.Length >= 3)
    {
        Console.WriteLine(number[2]);
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }
}