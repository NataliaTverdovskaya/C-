string inputNumberN = Console.ReadLine();

if(inputNumberN != null)
{
int numberN = int.Parse(inputNumberN);
int startNumber = 1;
string line = "";

while (startNumber <= numberN)
{
    int numberB = startNumber%2;
    if (numberB == 0)
    {
        line = line + " " + startNumber;
    }
    startNumber++;
}
Console.WriteLine(line);
}