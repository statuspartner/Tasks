/*
Напишите программу, которая по заданному номеру четверти показывает
диапазон возможных координат точек (x и y).
*/
Console.Write("Введите номер четверти от 1 до 4: ");
int q = Convert.ToInt32(Console.ReadLine());

switch (q)
{
case 1:
    {
        Console.WriteLine("Диапазон возможных координат: X > 0 и Y > 0");
        break;
    }
case 2:
    {
        Console.WriteLine("Диапазон возможных координат: X < 0 и Y > 0");
        break;
    }
case 3:
    {
        Console.WriteLine("Диапазон возможных координат: X < 0 и Y < 0");
        break;
    }
case 4:
    {
        Console.WriteLine("Диапазон возможных координат: X > 0 и Y < 0");
        break;
    }
default:
    {
        Console.WriteLine("Неверно ввели число.");
        break;
    }
}

