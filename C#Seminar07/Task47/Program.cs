// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.Write("Введите высоту массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr [i, j] =  Math.Round((new Random().NextDouble() * 20 - 10), 1);
    }
}

void PrintArray(double[,] arr)
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