int[] D = new int[5];
int i = 0;
int length = 0;

//Вводим номер
int[] inputNumber()
{
    Console.Write("Введите 5-значное число: ");
    string? inputLine = Console.ReadLine();
    //int[] D = new int[5];
    if (inputLine != null)
    {
        int P = int.Parse(inputLine);
        D[0] = P / 10000;
        D[1] = (P / 1000) % 10;
        D[2] = (P / 100) % 10;
        D[3] = (P / 10) % 10;
        D[4] = P % 10;
    }
    return D;
}
 
void check5 (int[] D)
{
    while (D[i] != null)
    {
        length = length + 1;
        i++;
    }
    if (i != 5)
    Console.WriteLine("Вы ввели не 5-значное число");
}
inputNumber();
check5(D);

if (D[0] == D[4] && D[1] == D[3])
    Console.WriteLine("Палиндром");
else
    Console.WriteLine("Не палиндром");



//    Console.Write("Введите 5-значное число: ");
//   string? inputLine = Console.ReadLine();

//   //  int[] D = new int[5];
// //
//     if (inputLine != null)
//     {
//         int P = int.Parse(inputLine);
//         int i = 0;
//         int num = P;
//         while (num > 0)
//         {
//             i++;
//             num /= 10;
//         }
//         if (i == 5)
//         {
//             D[0] = P / 10000;
//             D[1] = (P / 1000) % 10;
//             D[2] = (P / 100) % 10;
//             D[3] = (P / 10) % 10;
//             D[4] = P % 10;




