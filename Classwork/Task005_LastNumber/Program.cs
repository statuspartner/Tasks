// Программа на входе принимает трехзначное число и 
// на выходе показывает последнюю цифру этого числа.
Console.Write("Введите трехзначное целое число: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N >= 100 && N <= 999)
{
    int lastNumber = N % 10;
    Console.WriteLine("Последняя цифра трехзначного числа: " + lastNumber);
}
else
{
    Console.WriteLine("Это не трехзначное число!");
}