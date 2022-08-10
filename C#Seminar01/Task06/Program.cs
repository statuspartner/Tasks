/*
Напишите программу, которая на вход принимает число и выдает
является ли число четным (делится ли оно на 2 без остатка)
4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите целое число: ");
int x = Convert.ToInt32(Console.ReadLine());

if(x % 2 == 0)
{
    Console.Write("Число ");
    Console.Write(x);
    Console.WriteLine(" - чётное.");
}
else
{
    Console.Write("Число ");
    Console.Write(x);
    Console.WriteLine(" - нечётное.");
}