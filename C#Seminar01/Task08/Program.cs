Console.Write("Введите целое положительное число: ");
int x = Convert.ToInt32(Console.ReadLine());
int i = 2;
int even = 0;

while(i <= x)
{
    if(i % 2 == 0)
    {
        Console.Write(even + i);
        Console.WriteLine(" ");
    }
    i += 2;

}