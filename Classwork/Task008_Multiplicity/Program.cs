/*
Напишите программу, которая будет принимать на вход два числа
и выводить, является ли второе число кратным первому.
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA % numberB == 0)
{
    Console.WriteLine("Число B кратно числу A");
}
else
{
    Console.WriteLine("Число B не кратно числу A с остатком " + numberA % numberB);
}