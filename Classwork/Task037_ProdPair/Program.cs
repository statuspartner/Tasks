// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1,2,3,4,5] -> 5 8 3; [6,7,3,6] ->  36 21

int[] array = {1, 2, 3, 4, 5};
int len = array.Length;
int index = 0;

// Вывод массива.
Console.Write("Массив = ");
while (index < len)
{
    Console.Write(array[index]);
    Console.Write(" ");
    index++;
}
Console.WriteLine();

// Находим пары, перемножаем и выводим.
index = 0;
if (len % 2 == 0)
{
    while (index < len / 2)
    {
        Console.Write(array[index] * array[len - index - 1] + " ");
        index++;
    }
}
else
{
    while (index < len / 2)
    {
        Console.Write(array[index] * array[len - index - 1] + " ");
        index++;
    }
    Console.Write(array[index]);
}
Console.WriteLine();