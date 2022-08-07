Console.Write("Введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int i = -numberA;

while(i <= numberA)
{
    Console.WriteLine(i);
    i++;
}