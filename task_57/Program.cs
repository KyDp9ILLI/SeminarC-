// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


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
int[] ConvertToOneDimensionArray(int[,] in_array)
{
    int[] arrayForMethod = new int[in_array.Length];
    int count = 0;
    Console.WriteLine($"in_array.Length = {in_array.Length}");
    Console.WriteLine($"in_array.GetLength(0) = {in_array.GetLength(0)}");
    Console.WriteLine($"in_array.GetLength(1) = {in_array.GetLength(1)}");

    for (int i = 0; i < in_array.GetLength(0); i++)
    {
        for (int j = 0; j < in_array.GetLength(1); j++)
        {
            arrayForMethod[count] = in_array[i, j];
            count++;
        }
    }

    return arrayForMethod;
}

int[] SummUniqValuesInArray(int[] in_array, int[] in_array2)
{
    int count = 0;
    int actualValue = in_array[0];
    int iForSecondArray = 0;

    for (int i = 0; i < in_array.Length; i++)
    {
        if (actualValue == in_array[i])
        {
            count++;
        }
        else
        {
            actualValue = in_array[i];
            in_array2[iForSecondArray] = count;
            count = 1;
            iForSecondArray++;
        }

        if (i == in_array.Length - 1)
        {
            in_array2[iForSecondArray] = count;
        }
    }

    return in_array2;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ",");
        else
            Console.Write(arr[i] + "]");
    }
    Console.WriteLine();
}


int[,] arrayForTask = CreateMatrixRndInt(sizeM, sizeN, minimal, maximal);

PrintMatrix(arrayForTask);


int[] arrayResul = ConvertToOneDimensionArray(arrayForTask);
Array.Sort(arrayResul);

int[] uniqArray = arrayResul.Distinct().ToArray();
Console.WriteLine("массив основной");
PrintArray(arrayResul);
Console.WriteLine("массив отсортированный");
PrintArray(uniqArray);

uniqArray = SummUniqValuesInArray(arrayResul,uniqArray);
Console.WriteLine("массив с количеством повторений");
PrintArray(uniqArray);
