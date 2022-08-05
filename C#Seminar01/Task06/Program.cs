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