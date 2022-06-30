Console.WriteLine("Введите номер четверти");
int x = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
// else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
// else Console.WriteLine("Введены некоректные координаты");

switch(x)
{
    case 1: Console.WriteLine("Значение координаты x>0,y>0");break;
    case 2: Console.WriteLine("Значение координаты x<0,y>0");break;
    case 3: Console.WriteLine( "Значение координаты x<0,y<0");break;
    case 4: Console.WriteLine( "Значение координаты x>0,y<0");break;
    default: Console.WriteLine("Введены некоректные координаты");break;
}
