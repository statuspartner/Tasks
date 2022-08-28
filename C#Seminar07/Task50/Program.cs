// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите высоту массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите значение элемента массива: ");
int element = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
bool FindIt = false;

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (element == arr[i, j])
            {
                FindIt = true;
            }
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();

if (FindIt)
    Console.WriteLine($"Число {element} найдено в массиве.");
else
    Console.WriteLine($"Числа {element} в массиве нет.");