// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1 (используйте рекурсию).
// N = 5 -> 5, 4, 3, 2, 1

Console.Clear();

int n = InputNumbers("Задайте целое положительное число: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

if(n < 0) Console.WriteLine("Введите положительное число!");

void RecursionNumbers(int n)
{
    if (n > 0)
    {
        Console.Write("{0} ", n);
        RecursionNumbers(n - 1);
    }
}

int recNum = n;
RecursionNumbers(recNum);

