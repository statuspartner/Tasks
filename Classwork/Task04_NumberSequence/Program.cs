/*Программа на вход принимает одно число, а на выходе показывает 
все целые числа в промежутке от -N до N*/
Console.Write("Введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

for(int i = -numberA; i <= numberA; i++)
{
    Console.WriteLine(i + " ");
}