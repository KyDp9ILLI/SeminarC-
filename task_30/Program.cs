// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] arr = new int[8];

// for (int i = 0; i < arr.Length - 1; i++)
// {
//     arr[i] = new Random().Next(0, 2);
//     Console.Write(arr[i] + " ");
// }

void ArrayChar(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
PrintArray(arr);
ArrayChar(arr);
Console.WriteLine();
PrintArray(arr);