﻿// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число"); 
int num = Convert.ToInt32(Console.ReadLine());


string result = num%7 == 0 && num%23 == 0 ? $"Число {num} кратно 7 и 23" : $"Число {num} не кратно 7 и 23";
Console.WriteLine(result); 