string? inputLine = Console.ReadLine();

int N = int.Parse(inputLine);
int S = N*-1;

string Line = " ";

while (S < N)
{
    Line = Line + S + ", ";
    S = S + 1;
}
Line = Line + N;
Console.WriteLine(Line);