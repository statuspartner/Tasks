/*
Напишите программу, которая принимает на вход 5-ти значное число
и проверяет, является ли оно палиндромом
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите число из 5-ти знаков (кандидата на Палиндром): ");
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
}