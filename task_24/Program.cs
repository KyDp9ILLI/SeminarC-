// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());



int Sum(int number)
{
    int sum = 0;


    for (int i = 0; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int result = Sum(num);
Console.WriteLine($"Сумма чисел от 1 до {num} равна {result}");