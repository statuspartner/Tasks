/*
Напишите программу, которая на вход принимает два числа
и выдает, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3
*/

/*
Console.Write("Введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max;

if(numberA > numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}

Console.Write("Максимальное число: ");
Console.WriteLine(max);
*/

// Решение Преподавателя

Console.WriteLine("Введите первое число: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine();

if(a > b)
{
    Console.WriteLine(a + " больше, чем " + b);
}
else
{
    Console.WriteLine(b + " больше, чем " + a);
}