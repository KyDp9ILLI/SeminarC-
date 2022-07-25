// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[] FindLineColumn(int[,] arr)
{
    int[] minMaxArr = new int[2];
    int min = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                minMaxArr[0] = i;
                minMaxArr[1] = j;
            }
        }
    }
    return minMaxArr;
}

int[,] DeleteLineColumn(int[,] arr, int[] linecolumn)
{
    int[,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i != linecolumn[0] & j != linecolumn[1])
            {
                newArr[i, j] = arr[i, j];
            }
        }
    }
    return newArr;
}

void PrintMatrixNoMin(int[,] matrix, int[] matrixMin)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != matrixMin[0])
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != matrixMin[1])
                {
                    if (j == 0)
                        Console.Write("|");
                    if (j < matrix.GetLength(1) - 1)
                        Console.Write($"{matrix[i, j], 3}| ");
                    else
                        Console.Write($"{matrix[i, j], 3}|");
                }
            }
            Console.WriteLine();
        }
    }
}

int[,] array = CreateMatrixRndInt(sizeM, sizeN, minimal, maximal);
PrintMatrix(array);
Console.WriteLine();
int[] line = FindLineColumn(array);
PrintMatrixNoMin(array,line);
