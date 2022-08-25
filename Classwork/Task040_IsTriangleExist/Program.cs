// Задача 40. Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

bool IsTriangleExist(int A, int B, int C)
{
    if (A < B + C && B < A + C && C < A + B) return true;
    return false;
}

Console.Clear();
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.Write("Введите число C: ");
int C = int.Parse(Console.ReadLine()!);

if (IsTriangleExist(A, B, C)) Console.WriteLine("Треугольник существует!");
else Console.WriteLine("Увы, такого треугольника не существует!");