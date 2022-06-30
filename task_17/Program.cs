



Console.WriteLine("Введите координаты точки");
Console.Write("X=");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y=");
int y = Convert.ToInt32(Console.ReadLine());


// if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
// else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
// else Console.WriteLine("Введены некоректные координаты");

string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return"Четвертая четверть";
    return "Введены некоректные координаты";
}

Console.WriteLine(Quarter(x,y));