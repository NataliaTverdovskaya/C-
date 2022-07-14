System.Random numberSintezator = new Random();


void variant1 (System.Random numberSintezator)
{
int number = numberSintezator.Next(10, 100);
 Console.WriteLine(number);

int firstNumber = number/10;
int secondNumber = number%10;

if(firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}
}

variant1 (numberSintezator);
