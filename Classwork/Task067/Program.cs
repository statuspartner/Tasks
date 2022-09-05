// Задача 67. Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12; 45 -> 9

Console.Clear();

int n = InputNumbers("Задайте число: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int Sum(int n)
{
    if (n == 0) return 0;
    else return (n % 10) + Sum(n / 10);
}

Console.Write($"\nСумма цифр числа: {Sum(n)}. ");