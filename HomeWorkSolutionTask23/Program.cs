Console.Write("Введите число N: ");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{ 
    int N = int.Parse(inputLine);
    int S = 1;
    double pow = 1;
    string lineN = "";
    string lineNNN = "";


    while (S <= N)
    {
        pow = Math.Pow(S, 3);
        lineN = lineN + S + ", ";
        lineNNN = lineNNN + pow + ", ";
        S++;
    }
    Console.WriteLine(lineN);
    Console.WriteLine(lineNNN);
}