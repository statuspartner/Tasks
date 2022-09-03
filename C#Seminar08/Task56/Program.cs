// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Задайте размер прямоугольного массива: ");

int m = int.Parse(Console.ReadLine());
int[,] array = new int[m, m];

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i, j] = new Random().Next (0,9);     
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            {Console.Write($"{arr[i, j]} ");}
        Console.WriteLine();
    }
}

int SumRowElements(int[,] arr, int i)
{
  int sumRow = arr[i,0];
  for (int j = 1; j < arr.GetLength(1); j++)
  {
    sumRow += arr[i,j];
  }
  return sumRow;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();

int minSumRow = 0;
int sumLine = SumRowElements(array, 0);
for (int i = 0; i < array.GetLength(0); i++)
{
  int tempSumRow = SumRowElements(array, i);
  if (sumLine > tempSumRow)
  {
    sumLine = tempSumRow;
    minSumRow = i;
  }
}

Console.WriteLine($"Строка № {minSumRow+1} с первой наименьшей суммой элементов: {sumLine}.");