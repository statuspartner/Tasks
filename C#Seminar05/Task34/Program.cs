// Задайте массив, заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int [10];
int len = array.Length;
int i = 0;
int count = 0;

Console.Write("Массив: ");
while (i < len)
{
    array[i] = new Random().Next(100, 999);
    Console.Write(array[i] + " ");
    i++;
}
Console.Write(" \n");
Console.Write("Положительные числа массива: ");
for (int j = 0; j < len; j++)
{
    if (array[j] % 2 == 0)
    {
        count++;
        Console.Write(array[j] + " ");
    }
}
Console.Write(" \n");
Console.WriteLine("Количество положительных чисел в массиве: " + count);