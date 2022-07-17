// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Write("Введите размер массива:");
int sizeArr = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива:");
int minimal = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива:");
int maximal = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

void Reverse(int[] array)
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size - 1;
    while (index1<index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
        index1++;
        index2--;
    }
}

int[] array = CreateArrayRndInt(sizeArr, minimal, maximal);
PrintArray(array);
Reverse(array);

PrintArray(array);
Array.Reverse(array);
PrintArray(array);
