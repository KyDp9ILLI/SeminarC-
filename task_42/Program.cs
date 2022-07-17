// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите число:");
// int num1 = Convert.ToInt32(Console.ReadLine());

// int ConvertToBinary(int num)
// {
//     if (num == 1)
//         return 1;
//     if (num == 2)
//         return 0;
//     return num % 2 + 10 * ConvertToBinary(num / 2);
// }

// Console.WriteLine(ConvertToBinary(num1));


// Console.Write("Введите целое число: ");
// int number = int.Parse(Console.ReadLine());

// Console.Write("Введите основание системы счисления: ");
// int baseNum = int.Parse(Console.ReadLine());

// int d10 = 1;
// int result = 0;
// while (number != 0)
// {
// result = result + number % baseNum * d10;
// number = number / baseNum;
// d10 = d10 * 10;
// }
// Console.WriteLine(result);


Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
void ToBin(int n)
{
if (n == 0) return;
ToBin(n / 2);
Console.Write(n % 2);
}
ToBin(a);