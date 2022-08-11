/*
Напишите программу, которая выводит случайное трехзначное число
и удаляет вторую цифру этого числа.
*/

/*
int randomDigit = new Random().Next(100, 999);

Console.WriteLine($"Случайное число: {randomDigit}");

int firstDigit = (randomDigit / 100) * 10;
int thirdDigit = randomDigit % 10;
int digit = firstDigit + thirdDigit;

Console.WriteLine("Магия удаления второй цифры: " + digit);

*/

// Решение Преподавателя

int n = new Random().Next(100,1000);
Console.WriteLine(n);

int withoutsecond(int n)
{
    int first = n / 100;
    int third = n % 10;
    return first * 10 + third;
}
Console.WriteLine(withoutsecond(n));