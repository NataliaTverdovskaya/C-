string? inputNumber1 = Console.ReadLine();
string? inputNumber2 = Console.ReadLine();


if (inputNumber1 != null & inputNumber2 != null)
{
    int Number1 = int.Parse(inputNumber1);
    int Number2 = int.Parse(inputNumber2);
    int result1 = Number2*Number2;
    int result2 = Number1*Number1;

    if(Number1 == result1)
    {
        Console.WriteLine("да");
    }
    else
    {
        if(Number2 == result2)
        {
             Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }
    }
}