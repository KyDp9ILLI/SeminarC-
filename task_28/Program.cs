// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());



int Proiz(int number)
{
    int proiz = 1;


    for (int i = 1; i <= num; i++)
    {
        try
        {
            checked
            {
                proiz *= i;
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Переполнение типа!");
            break;
        }
    }
    return proiz;
}

int result = Proiz(num);
Console.WriteLine($"Произведение чисел от 1 до {num} равна {result}");