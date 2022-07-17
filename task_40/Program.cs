// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первую сторону треугольника:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треугольника:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону треугольника:");
int num3 = Convert.ToInt32(Console.ReadLine());

void TrueTreyg(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        Console.WriteLine("Треугольник существует");
    else
        Console.WriteLine("Треугольник не существует");
}

TrueTreyg(num1, num2, num3);
