// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Fn=Fn-1+Fn-2
Console.Write("Введите количество чисел в ряду Фибоначчи: ");
int number = int.Parse(Console.ReadLine());

string Fibonnacci(int n)
{
    string answer = " ";
    if (n == 2)
    {
        answer = "0 1";
    }
    else
    {
        if (n == 1)
        {
            answer = "0";
        }
        else
        {
            int fn_1 = 1;
            int fn_2 = 0;
            int fn;
            for (int i = 0; i < n - 2; i++)
            {
                fn = fn_1 + fn_2;
                answer += " " + fn;
                fn_2 = fn_1;
                fn_1 = fn;
            }
        }
    }
    return answer;
}

void PrintAnswer(string answer)
{
    Console.Write(answer);
}

string answer = Fibonnacci(number);
PrintAnswer(answer);