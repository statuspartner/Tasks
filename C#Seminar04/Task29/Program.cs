// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1,2,5,7,19 -> [1,2,5,7,19]; 6,1,33 -> [6,1,33]

int[] array = new int [8];
int len = array.Length;
int i = 0;
while (i < len)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
for (int j = 0; j < len; j++)
{
    Console.Write(array[j] + " ");
}
Console.WriteLine();