// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.


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

int[,] SqrtElem(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i += 2)
    {
        for (int j = 0; j < arr.GetLength(0); j += 2)
        {
            arr[i, j] *= arr[i, j];
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

int[,] array = CreateMatrixRndInt(sizeM, sizeN, minimal, maximal);
PrintMatrix(array);
Console.WriteLine();
int[,] arrayResult = SqrtElem(array);
PrintMatrix(arrayResult);
