// Задача 46: Задайте двумерный массив размером m x n,
// заполненный случайными целыми числами. 
// m = 3, n = 4.
// 1  4  8 19
// 5  -2 33  -2
// 77  3  8   1

Console.Clear();
Console.Write("Введите высоту массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int n = int.Parse(Console.ReadLine());


int[,] array = new int[m, n];

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr [i, j] = new Random().Next (-9,40);
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

FillArray(array);
PrintArray(array);