Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

// int a = 1;
// while (a<=n)
// {
//     Console.WriteLine(Math.Pow(a,2) + " ");
//     a++;
// }

for (int i = 1; i<=n; i++)
{
    Console.WriteLine($"|Квадрат числа {i} = |{i*i,4}| ");
}