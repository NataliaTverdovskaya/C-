// Метод считывает точки и возвращает массив
int[,] readPoint()
{
    Console.Write("Введите координаты в формате A(x,y,z);B(x,y,z): ");
    string inputLine = Console.ReadLine();
    // A(3,6,8);B(2,1,-7)
    
    //возможно дальше некрасиво, но зато сама ))))
    string pointALine = inputLine.Substring(0, inputLine.IndexOf(";"));
    // A(3,6,8)
    string pointAX = pointALine.Substring(0, pointALine.IndexOf(","));
    pointAX = pointAX.Substring(pointAX.IndexOf("(") + 1);
    string pointAY = pointALine.Substring(0, pointALine.IndexOf(")"));
    pointAY = pointAY.Substring(pointAY.IndexOf(",") + 1);
    pointAY = pointAY.Substring(0, pointAY.IndexOf(","));
    string pointAZ = pointALine.Substring(pointALine.IndexOf(","));
    pointAZ = pointAZ.Substring(pointAZ.IndexOf(",") + 1);
    pointAZ = pointAZ.Substring(pointAZ.IndexOf(",") + 1);    
    pointAZ = pointAZ.Substring(0, pointAZ.IndexOf(")"));

    string pointBLine = inputLine.Substring(inputLine.IndexOf(";"));
    // B(2,1,-7)
    string pointBX = pointBLine.Substring(0, pointBLine.IndexOf(","));
    pointBX = pointBX.Substring(pointBX.IndexOf("(") + 1);
    string pointBY = pointBLine.Substring(0, pointBLine.IndexOf(")"));
    pointBY = pointBY.Substring(pointBY.IndexOf(",") + 1);
    pointBY = pointBY.Substring(0, pointBY.IndexOf(","));
    string pointBZ = pointBLine.Substring(pointBLine.IndexOf(","));
    pointBZ = pointBZ.Substring(pointBZ.IndexOf(",") + 1);
    pointBZ = pointBZ.Substring(pointBZ.IndexOf(",") + 1);    
    pointBZ = pointBZ.Substring(0, pointBZ.IndexOf(")"));  

    //Console.WriteLine(pointAX + ' ' + pointAY + ' ' + pointAZ);
    //Console.WriteLine(pointBX + ' ' + pointBY + ' ' + pointBZ );

    int AX = int.Parse(pointAX);
    int AY = int.Parse(pointAY);
    int AZ = int.Parse(pointAZ);
    int BX = int.Parse(pointBX);
    int BY = int.Parse(pointBY);
    int BZ = int.Parse(pointBZ);

    int[,] arrayOut = new int[3, 2];
    arrayOut[0, 0] = AX;
    arrayOut[1, 0] = AY;
    arrayOut[2, 0] = AZ;
    arrayOut[0, 1] = BX;
    arrayOut[1, 1] = BY;
    arrayOut[2, 1] = BZ;

    return arrayOut;
}

// Метод расситывает по формуле и выводит расстояние между точками
void printLength(int[,] arrayLength)
{
    double powXAB = Math.Pow(arrayLength[0, 1] - arrayLength[0, 0], 2);
    double powYAB = Math.Pow(arrayLength[1, 1] - arrayLength[1, 0], 2);
    double powZAB = Math.Pow(arrayLength[2, 0] - arrayLength[2, 1], 2);
    double length = Math.Sqrt(powXAB + powYAB + powZAB);
    Console.WriteLine(Math.Round(length, 2));
}

int[,] arrayLength = readPoint();
printLength(arrayLength);