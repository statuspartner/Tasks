// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> 1, 2, 3, 4, 5

Console.Clear();

int n = InputNumbers("Задайте значение N: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void RecursionNumbers(int i)
{
    if (i == n) Console.Write(i);
    else 
    {
        Console.Write($"{i} ");
        i++;
        RecursionNumbers(i);
    }
}

int recNum = 1;
RecursionNumbers(recNum);