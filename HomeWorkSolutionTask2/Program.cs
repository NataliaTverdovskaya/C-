string inputNumberA = Console.ReadLine();
string inputNumberB = Console.ReadLine();

if(inputNumberA != null & inputNumberB != null)
{
int NumberA = int.Parse(inputNumberA);
int NumberB = int.Parse(inputNumberB);

    if (NumberA > NumberB)
    {
        Console.Write("max=");
        Console.WriteLine(NumberA);
    }
    else
    {   
        Console.Write("max=");
        Console.WriteLine(NumberB);
    }
}    

