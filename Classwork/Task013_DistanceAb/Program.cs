/*
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/
Console.WriteLine("Введите координаты точки A: ");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xa-xb, 2) + Math.Pow(ya-yb, 2));
Console.WriteLine(Math.Round(distance, 3));