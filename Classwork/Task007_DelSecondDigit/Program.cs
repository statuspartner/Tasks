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