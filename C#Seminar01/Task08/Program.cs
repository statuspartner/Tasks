/*
Напишите программу, которая на вход принимает число (N),
а на выходе показывает все четные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*
Console.Write("Введите целое положительное число: ");
int x = Convert.ToInt32(Console.ReadLine());
int i = 2;
int even = 0;

while(i <= x)
{
    if(i % 2 == 0)
    {
        Console.Write(even + i);
        Console.WriteLine(" ");
    }
    i += 2;
}
*/

// Версия Преподавателя

Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i}");
    }
}