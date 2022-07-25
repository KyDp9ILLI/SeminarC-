// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.Write("Введите количество строк:");
int sizeN = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов:");
int sizeM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива:");
int minimal = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива:");
int maximal = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write("|");
            if (j < arr.GetLength(1) - 1)
                Console.Write($"{arr[i, j], 3} | ");
            else
                Console.Write($"{arr[i, j], 3} | ");
        }
        Console.WriteLine();
    }
}

int[,] arrayResult = CreateMatrixRndInt(sizeM, sizeN, minimal, maximal);
PrintMatrix(arrayResult);
