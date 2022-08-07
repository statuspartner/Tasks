Console.Write("Введите целое число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberB*numberB == numberA)
{
    Console.WriteLine("Число A - квадрат числа B");
}
else
{
    Console.WriteLine("Число A - не квадрат числа B");
}