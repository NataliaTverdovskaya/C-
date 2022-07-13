string inputNumberA = Console.ReadLine();

if(inputNumberA != null)
{
int numberA = int.Parse(inputNumberA);
int numberB = numberA%2;

if (numberB == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}
}