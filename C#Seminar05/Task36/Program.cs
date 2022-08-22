// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

int[] array = new int [6];
int len = array.Length;
int i = 0;
int sumNegIndexes = 0;
int count = 0;

Console.Write("Массив: ");
while (i < len)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write(array[i] + " ");
    i++;
}
Console.Write(" \n");
Console.Write("Элементы, удовлетворящие условию задачи: ");
for (int j = 0; j < len; j++)
{
    if (j % 2 != 0)
    {
        sumNegIndexes = sumNegIndexes + array[j];
        count++;
        Console.Write(array[j] + " ");
    }
}
Console.Write(" \n");
Console.WriteLine("Сумма элементов с нечетными индексами массива: " + sumNegIndexes);
