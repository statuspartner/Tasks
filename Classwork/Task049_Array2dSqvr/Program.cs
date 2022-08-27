// Задача 49: Задайте двумерный массив.
// Найдите элементы, у которых оба индекса четные
// и замените эти элементы на их квадраты.
// 6 4 7 2      36 4 49 2
// 5 9 2 3       5 9  2 3
// 8 4 2 4      64 4  4 4

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());


int[,] array = new int[m, n];

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr [i, j] = new Random().Next (1,10);
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            {Console.Write($"{arr[i, j]}\t");}
        Console.WriteLine();
    }
}

void SqrEven(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i += 2)
    {
        for (int j = 0; j < arr.GetLength(1); j += 2)
        {
            arr [i, j] = arr [i, j] * arr [i, j];
        } 
    }
}

FillArray(array);
PrintArray(array);
SqrEven(array);
Console.WriteLine();
PrintArray(array);