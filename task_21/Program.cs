Console.WriteLine("Введите координаты первой точки");
Console.Write("X=");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y=");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X=");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y=");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = (Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)));
Console.WriteLine(Math.Round(result,2));