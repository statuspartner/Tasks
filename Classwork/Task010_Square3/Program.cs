/*
Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно квадратом другого.
5, 25 -> да
-4, 16  -> да
25, 5 -> да
8, 9 -> нет
*/

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if((numberA * numberA == numberB) || (numberB * numberB == numberA))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}