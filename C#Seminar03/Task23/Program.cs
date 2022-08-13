/*
Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125.
*/

Console.Write("Введите целое число: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Write("Ряд кубов чисел: ");

for (int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i,3));
    if (i < N)
    {
        Console.Write(", ");
    }
    else
    {
        Console.WriteLine(".");
    }
}
