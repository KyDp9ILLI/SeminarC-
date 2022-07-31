// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Задайте число:");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int num,int sum )
{ 
    sum += num % 10;
    if (num == 0)
    {
        Console.WriteLine($"{sum}");
        return;
    }
    NaturalNumber(num/10,sum);
}

// int NaturalNumber(int n)
// {
//     if(n!=0) return n%10 + NaturalNumber (n/10);
//     return 0;
// }

NaturalNumber(number,0);
