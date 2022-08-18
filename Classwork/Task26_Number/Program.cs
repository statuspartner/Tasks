// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 456 -> 3; 78 -> 2; 89126 -> 5.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (num != 0)
{
    count++;
    num = num / 10;
}

Console.WriteLine(count);