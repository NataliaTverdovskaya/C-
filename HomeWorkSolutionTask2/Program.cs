string inputNumberA = Console.ReadLine();
string inputNumberB = Console.ReadLine();

int NumberA = int.Parse(inputNumberA);
int NumberB = int.Parse(inputNumberB);

    if(NumberA > NumberB)
    Console.WriteLine("max=", NumberA);
    else
    {
    Console.Write("max=");
    Console.WriteLine(NumberB);
    }
