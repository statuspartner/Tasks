/*
Напишите программу, которая принимает на вход 5-ти значное число
и проверяет, является ли оно палиндромом
14212 -> нет
12821 -> да
23432 -> да
*/

/* Console.Write("Введите число из 5-ти знаков (кандидата на Палиндром): ");
string palindrome = Console.ReadLine();
int length = palindrome.Length;
if(palindrome.Length == 5)
{
    for(int i = 0; i < length/2; ++i)
    {
    	if(palindrome[i] != palindrome[length-i-1])
    	{
    		Console.WriteLine(palindrome + " - это не палиндром.");
    		break;
    	}
    	else
    	{
    	    Console.WriteLine(palindrome + " - это палиндром.");
    		break;
    	}
    }
}
else
{
    Console.WriteLine("Введите пятизначное число!");
} */

// Решение преподавателя

int a = int.Parse(Console.ReadLine());

if (a < 99999 & a >= 10000) // условие для проверки, является ли число пятизначным
{
	int xx = a / 1000;	// 1,2 цифры
	int num1 = xx / 10; // 1 цифра
	int num2 = xx % 10; // 2 цифра
	int yy = a % 100;   // 4,5 цифры
	int num4 = yy / 10; // 4 цифра
	int num5 = yy % 10; // 5 цифра

	if (num1 == num5 & num2 == num4)
	{
		Console.WriteLine($"Число {a} - палиграм.");
	}
	else
	{
		Console.WriteLine($"Число {a} - не палиграм.");
	}
}
else
{
	Console.WriteLine($"Число {a} - не является пятизначным.");
}