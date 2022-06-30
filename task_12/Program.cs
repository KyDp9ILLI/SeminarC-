// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


// var rnd = new Random();
// int n1 = rnd.Next(0,100);
// int n2 = rnd.Next(0,100);
// Console.WriteLine(n1);
// Console.WriteLine(n2);

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

string result = num1%num2 == 0 ? $"{num1} кратно {num2}" : $"остаток от деления {num1} и {num2} = {num1%num2}";
Console.WriteLine(result);
