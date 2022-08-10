/*
Напишите программу, которая выводит случайное число из отрезка [10,99]
и показывает наибольшую цифру числа.
*/

int randomDigit = new Random().Next(10, 99);
Console.WriteLine($"Случайное число: {randomDigit}");
int firstDigit = randomDigit / 10;
int secondDigit = randomDigit % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра этого числа: {firstDigit}");
}
else
{
    Console.WriteLine($"Наибольшая цифра этого числа: {secondDigit}");
}
