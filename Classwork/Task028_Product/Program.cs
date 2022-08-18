// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
// 4 -> 24; 5 -> 120.
/* Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
int product = 1;

while (count <= N)
{
    product = product * count;
    count++;
}
Console.WriteLine(product); */

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int mul = 1;
for (int i = 1; i <= N; i++)
{
    mul *= i;
}
Console.WriteLine(mul);