// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6,7,19,345,3] -> нет
// -3; массив [6,7,19,345,3] -> нет

int[] array = new int[] {6,7,19, 345, 3};
Console.Write("Введите число: ");
int Dig = Convert.ToInt32(Console.ReadLine());
int length = array.Length;
bool isThere = false;

for (int i = 0; i < length; i++)
{
    if (array[i] == Dig)
    {
        isThere = true;
    }
}

if (isThere)
{
Console.Write("Число " + Dig + " является элементом массива");
}
else
{
Console.Write("Число " + Dig + " не является элементом массива");
}

