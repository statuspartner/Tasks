// Напишите программу замены элементов массива: положительные элементы замените на 
// соответствующие отрицательные и наоборот.
// [-4, -8, 4, 2] -> [4, 8, -4, -2]

int[] array = new int[4];
int length = array.Length;
int i = 0;
int reverse = 0;

while(i < length)
{
    array[i] = new Random().Next(-8, 8);
    Console.Write(array[i] + " ");
    i++;
}
Console.Write(" \n");
for (int j = 0; j < length; j++)
{
    reverse = array[j] * -1;
    Console.Write(reverse + " ");
}