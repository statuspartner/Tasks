// Напишите программу, которая задает массив из 8 элементов и выводит их на экран. 
// 1,2,5,7,19 -> [1,2,5,7,19]; 6,1,33 -> [6,1,33]

Console.Write("Введите количество элементов массива: ");
int arrDigits = int.Parse(Console.ReadLine());

int[] array = new int [arrDigits];
int len = array.Length;
int i = 0;
while (i < len)
{
    Console.Write($"Введите {i+1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
Console.WriteLine();
Console.Write("Готовый массив с элементами: ");
for (int j = 0; j < len; j++)
{
    Console.Write(array[j] + " ");
}
Console.WriteLine();