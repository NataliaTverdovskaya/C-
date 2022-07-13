string inputNumberA = Console.ReadLine();
string inputNumberB = Console.ReadLine();
string inputNumberC = Console.ReadLine();

if(inputNumberA != null & inputNumberB != null & inputNumberC != null)
{
int NumberA = int.Parse(inputNumberA);
int NumberB = int.Parse(inputNumberB);
int NumberC = int.Parse(inputNumberC);

    if (NumberA > NumberB)
    {
        if (NumberA > NumberC)
        {
            Console.Write("max=");
            Console.WriteLine(NumberA); 
        }
        else
        {
            Console.Write("max=");
            Console.WriteLine(NumberC); 
        }
    }
    else
    {
        if (NumberB > NumberC)
        {
            Console.Write("max=");
            Console.WriteLine(NumberB); 
        }
        else
        {
            Console.Write("max=");
            Console.WriteLine(NumberC); 
        }
    }
}    

