// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Введите высоту массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
double[] array2 = new double[n];

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i, j] = new Random().Next (1,9);     
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

void AverageNumbers(int[,] arr)
{
    for (int j = 0, k = 0; j < arr.GetLength(1); j++)
    {
        double Average = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Average += arr[i, j];
        }
        array2[k] = Math.Round((Average / arr.GetLength (0)), 2);
        Console.WriteLine("Сумма чисел в столбце №" + (j+1) + " равно " + Average + ".\tСреднее арифметическое столбца равно: " + array2[k] + ".");
        k++;

    }
}

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
AverageNumbers(array);