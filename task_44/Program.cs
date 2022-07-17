// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

int[] Fibonachi(int a) 
{
   int[] arr = new int [a];
   for (int i = 0; i < a; i++)
   {
        if(i == 0) arr[i] = 0;
        if(i == 1) arr[i] = 1;
        if(i>1) arr[i] = arr[i-1] + arr[i-2];
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
int[] array = Fibonachi(a); 
PrintArray(array);