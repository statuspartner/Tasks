// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива
// значения которых лежат в отрезке [10,99]
// Пример для массива из 5-ти: [5,18,23,6,2] -> 1; [1,2,3,6,2] -> 0; [10,11,12,13,14] -> 5

int[] array = new int[123];
int length = array.Length;
int i = 0;
int count = 0;

while(i < length)
{
    array[i] = new Random().Next(0, 200);
    Console.Write(array[i] + " ");
    i++;    
}
Console.WriteLine(" \n");

for (int j = 0; j < length; j++)
{
    if(array[j] > 9 & array[j] < 100)
    {
        count++;
        Console.Write(array[j] + " ");
    }
}
Console.WriteLine(" \n");
Console.Write("Количество найденных элементов массива: " + count);
Console.WriteLine(" \n");