// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Задайте число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте степень:");
int number2 = Convert.ToInt32(Console.ReadLine());

// void NaturalNumber(int proiz, int power, int num)
// {
//     if (power == 1)
//     {
//         Console.WriteLine($"{num}");
//         return;
//     }
//     if (1 < power)
//     {
//         num *= proiz;
//         NaturalNumber(proiz, power - 1, num);
//         return;
//     }
// }

int SquareNumber(int a, int b)
{
    if (b == 0) return 1;
    return SquareNumber(a,b-1)*a;
}

Console.WriteLine(SquareNumber(number,number2));

// NaturalNumber(number, number2, number);
