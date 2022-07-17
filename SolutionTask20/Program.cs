// Метод считывает точки и возвращает массив
int[,] readPoint()
{
    string inputLine = Console.ReadLine();
    // A(3,6);B(2,1)
    
    string pointALine = inputLine.Substring(0, inputLine.IndexOf(";"));
    // A(3,6)
    string pointAX = pointALine.Substring(0, pointALine.IndexOf(","));
    pointAX = pointAX.Substring(pointAX.IndexOf("(") + 1);
    string pointAY = pointALine.Substring(0, pointALine.IndexOf(")"));
    pointAY = pointAY.Substring(pointAY.IndexOf(",") + 1);

    string pointBLine = inputLine.Substring(inputLine.IndexOf(";"));
    // B(2,1)
    string pointBX = pointBLine.Substring(0, pointBLine.IndexOf(","));
    pointBX = pointBX.Substring(pointBX.IndexOf("(") + 1);
    string pointBY = pointBLine.Substring(0, pointBLine.IndexOf(")"));
    pointBY = pointBY.Substring(pointBY.IndexOf(",") + 1);

    //Console.WriteLine(pointAX + ' ' + pointAY);
    //Console.WriteLine(pointBX + ' ' + pointBY);

    int AX = int.Parse(pointAX);
    int AY = int.Parse(pointAY);
    int BX = int.Parse(pointBX);
    int BY = int.Parse(pointBY);

    int[,] arrayOut = new int[2, 2];
    arrayOut[0, 0] = AX;
    arrayOut[1, 0] = AY;
    arrayOut[0, 1] = BX;
    arrayOut[1, 1] = BY;

    return arrayOut;
}

// Метод расситывает по формуле и выводит расстояние между точками
void printLength(int[,] arrayLength)
{
    double powXAB = Math.Pow(arrayLength[0, 1] - arrayLength[0, 0], 2);
    double powYAB = Math.Pow(arrayLength[1, 1] - arrayLength[1, 0], 2);
    double length = Math.Sqrt(powXAB + powYAB);
    Console.WriteLine(Math.Round(length, 2));
}

int[,] arrayLength = readPoint();
printLength(arrayLength);