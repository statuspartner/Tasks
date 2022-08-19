// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9012 -> 12.

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sumDigit = 0;

while (num != 0)
{
    sumDigit = sumDigit + (num % 10);
    num /= 10;
}
Console.WriteLine(sumDigit);