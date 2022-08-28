// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали    
// 1 4 7 2
// 5 9 2 3   ->  1 + 9 + 2 = 12
// 8 4 2 4
Console.Clear();
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

void SumDiagonal(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j) arr[i, j] = arr[i, j] * arr[i, j];
        }
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
SumDiagonal(array);
Console.WriteLine();
PrintArray(array);