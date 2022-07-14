int randomNumber = new Random().Next(100, 999);
Console.WriteLine(randomNumber);

//Variant 1
char[] charArray = randomNumber.ToString().ToCharArray();

string charFirst = charArray[0].ToString();
string charThird = charArray[2].ToString();
Console.WriteLine(charFirst+charThird);

//Variant 2
int number1 = randomNumber/100;
int number2 = randomNumber%10;
int finalNumber = number1*10+number2;

Console.WriteLine(finalNumber);
