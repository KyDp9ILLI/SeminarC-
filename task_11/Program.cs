// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int rndNum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100-999 => {rndNum}");

int newNum (int num)
{
    return num/100*10 + num%10;
}

int Num = newNum(rndNum);
Console.WriteLine(Num);
