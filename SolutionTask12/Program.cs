string? inputNumber = Console.ReadLine();

if (inputNumber != null)
{
    int number = int.Parse(inputNumber);
    int result7 = number%7;
    int result23 = number%23;

    if(result7 == 0 & result23 == 0)
    {
        Console.WriteLine("да");
    }
    else
    {
      Console.WriteLine("нет");  
    }
}