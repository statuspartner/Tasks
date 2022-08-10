Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if((numberA * numberA == numberB) || (numberB * numberB == numberA))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


/*
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if(numberA % 7 == 0 && numberA % 23 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


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
*/