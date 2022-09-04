// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N (используйте рекурсию).

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();

int m = InputNumbers("Задайте значение M: ");
int n = InputNumbers("Задайте значение N: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int sum = n;
void BetweenNumbers(int i)
{
    if (i == n) Console.Write(i);
    else 
    {
        Console.Write($"{i} ");
        sum += i;
        i++;
        BetweenNumbers(i);
    }  
}

Console.Write($"\nРяд вычисляемых элементов: ");
BetweenNumbers(m);
Console.Write($"\nСумма этих элементов: {sum}. ");