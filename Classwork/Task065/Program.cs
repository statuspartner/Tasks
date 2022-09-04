// Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();

int m = InputNumbers("Задайте значение M: ");
int n = InputNumbers("Задайте значение N: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void BetweenNumbers(int i)
{
    if (i == n) Console.Write(i);
    else 
    {
        Console.Write($"{i} ");
        i++;
        BetweenNumbers(i);
    }
}

BetweenNumbers(m);