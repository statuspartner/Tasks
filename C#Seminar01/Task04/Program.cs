/*
Напишите программу, которая принимает на вход три числаи выдает
максимальное из этих чисел.
2,3,7 -> 7
44,5,78 -> 78
22,3,9 -> 22
*/

/*
Console.Write("Введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if(numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}

Console.Write("Максимальное число: ");
Console.WriteLine(max);
*/

// Решение Преподавателя

Console.WriteLine("Введите три целых числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(b > max) max = b;
if(c > max) max = c;

Console.WriteLine($"Максимальное число: {max}");