﻿// Задача 39. Напишите программу, которая 
// перевернет одномерный массив (последний элемент
// будет на первом месте, первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// Array.Reverse - метод, который это делает за нас. 
// Но нам нужно сделать это руками.

int[] ReverseArray(int[] input) 
{
    int[] result = new int[input.Length];

    for (int i = 0, j = input.Length - 1; i < input.Length; i++, j--)
    {
        result[i] = input[j];
    }

    return result;
}

void PrintArray(int[] input)
{
    for (var i = 0; i < input.Length; i++)
        Console.Write(input[i] + " ");
}

int[] input = new int[] {6, 7, 3, 6};
var result = ReverseArray(input);
PrintArray(result);