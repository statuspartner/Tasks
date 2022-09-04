﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int n = InputNumbers("Введите число строк/столбцов массива: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[,] Array = new int[n, n];
int count = 1;
int i = 0;
int j = 0;

while (count <= Array.GetLength(0) * Array.GetLength(1))
{
    Array[i, j] = count;
    count++;
    if (i <= j + 1 && i + j < Array.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= Array.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > Array.GetLength(1) - 1)
        j--;
    else
        i--;
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] / 10 <= 0)
        Console.Write($"0{array[i,j]} ");

        else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

Console.WriteLine($"\nСпираль:");
PrintArray(Array);