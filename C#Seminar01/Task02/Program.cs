Console.Write("Введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max;

if(numberA > numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}

Console.Write("Максимальное число: ");
Console.WriteLine(max);