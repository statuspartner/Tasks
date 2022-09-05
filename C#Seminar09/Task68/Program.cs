﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Функция Аккермана

// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int m = InputNumbers("Задайте значение m: ");
int n = InputNumbers("Задайте значение n: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int AckermannFunction(int n, int m)
{
if (n == 0) return m + 1;
else if ((n != 0) && (m == 0)) return AckermannFunction(n - 1, 1);
return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
}

Console.WriteLine(AckermannFunction(m, n));