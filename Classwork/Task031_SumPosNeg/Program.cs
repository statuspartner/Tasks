// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Напр, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1,6] сумма положительных чисел равна 29,
// а сумма отрицательных числел равна 20.

int[] array = new int[12];
int length = array.Length;
int i = 0;
int pos = 0;
int neg = 0;

while(i < length)
{
    array[i] = new Random().Next(-9, 9);
    i++;
}

for (int j = 0; j < length; j++)
{   
    if (array[j] > 0)
    {
        pos = pos + array[j];
    }
    else
    {
        neg = neg + array[j];
    }
    Console.Write(array[j] + " ");
}
Console.Write(" \n");
Console.WriteLine($"Сумма положительных чисел массива: {pos}");
Console.WriteLine($"Сумма отрицательных чисел массива: {neg}");

