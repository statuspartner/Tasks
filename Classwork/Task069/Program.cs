// Задача 69. Напишите программу, которая на вход принимает два числа A и B
// и возводит число А в целую степень В с помощью рекурсии.
// A = 2; B = 3 -> 8
// A = 3; B = 5 -> 243 (3 в степени 5)

Console.Clear();

int a = InputNumbers("Задайте значение A: ");
int b = InputNumbers("Задайте значение B: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int PowerRecursion(int a, int b)
{
if (b == 0) return 1;
else return (a * PowerRecursion(a, b-1));
}

Console.WriteLine(PowerRecursion(a, b));