string? inputNumber1 = Console.ReadLine();
string? inputNumber2 = Console.ReadLine();


if (inputNumber1 != null & inputNumber2 != null)
{
    int Number1 = int.Parse(inputNumber1);
    int Number2 = int.Parse(inputNumber2);
    int result = Number2 % Number1;
    if (result == 0)
    {
        Console.WriteLine("кратно");
    }
    else
    {
        Console.WriteLine("некратно, остаток " + result);
    }
}