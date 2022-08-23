// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3, 7, 22, 2, 78] -> 76

double[] array = new double [5];
int len = array.Length;
int i = 0;
double min = 100;
double max = 0;

Console.Write("Массив: ");
while (i < len)
{
    // array[i] = new Random().NextDouble() * 200 - 100;
    array[i] = new Random().NextDouble() * 100;
    Console.Write(Math.Round(array[i], 2) + "| ");
    i++;
}
for (i = 0; i < len; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

Console.Write(" \n");
Console.Write("Max result: " + Math.Round(max,2));
Console.Write(" \n");
Console.Write("Min result: " + Math.Round(min,2));
Console.Write(" \n");
Console.WriteLine("Разница: " + Math.Round(max - min, 2));
