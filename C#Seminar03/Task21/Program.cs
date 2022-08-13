/*
Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5,0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты точки A: ");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xa-xb, 2) + Math.Pow(ya-yb, 2) + Math.Pow(za-zb, 2));
Console.WriteLine("Расстояние между точками А и В в 3D пространстве: " + Math.Round(distance, 3));