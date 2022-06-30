// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int rndNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {rndNum}");

// if (firstDigit> secondDigit) Console.WriteLine($"Наибольшая цифра числа {rndNum} => {firstDigit}");
// else if (firstDigit < secondDigit) Console.WriteLine($"Наибольшая цифра числа {rndNum} => {secondDigit}");
// else Console.WriteLine("Цифры числа {rndNum} равны");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(rndNum);
string result = maxDigit > 0 ? maxDigit.ToString() : "числа равны";
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {result}");