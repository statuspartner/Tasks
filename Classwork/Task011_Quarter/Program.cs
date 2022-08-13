/*
Напишите программу, которая принимает на вход координаты точки (X и Y)
и выдает номер четверти плоскости, в которой находится эта точка.
*/
Console.Write("Введите X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("1-я четверть");
}
if (X < 0 && Y > 0)
{
    Console.WriteLine("2-я четверть");
}
if (X < 0 && Y < 0)
{
    Console.WriteLine("3-я четверть");
}
if (X > 0 && Y < 0)
{
    Console.WriteLine("4-я четверть");
}