// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
// 3,5 -> 243; 2,4 -> 16

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите степень числа: ");
int b = int.Parse(Console.ReadLine());
double n = 1;
if (b >= 0)
{
    for (int i = 0; i < b; i++)
    {
        n = n * a;
    }
    Console.WriteLine($"Результат возведения числа в положительную степень: {n}");
}
else
{
    for (int i = 0; i < -b; i++)
    {
        n = n * a;
    }
    n = 1 / n;
    Console.WriteLine($"Результат возведения числа в отрицательную степень: {n}");
}