/*
Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 5
78  -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 100)
{
    int k = (int)Math.Log10(n)-2;
    Console.WriteLine("Третья слева цифра числа: " + (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}