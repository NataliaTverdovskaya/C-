string? inputNumber = Console.ReadLine();

if (inputNumber != null)
{
    int number = int.Parse(inputNumber);
    int result = (number%100)/10;
    Console.WriteLine(result);
}