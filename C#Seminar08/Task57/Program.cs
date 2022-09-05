// Задача 57 Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

Console.Clear();
int a = InputNumbers("Введите число строк массива: ");
int b = InputNumbers("Введите число столбцов массива: ");

int[,] array = new int[a, b];

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1, 9);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            {Console.Write($"{arr[i, j]} ");}
        Console.WriteLine();
    }
}

void SortArray(int[,] arr) // Сортируем массив от максимума к минимуму.
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)

            for (int a = 0; a < array.GetLength(0); a++)
                for (int b = 0; b < array.GetLength(1); b++)
                    if (array[a, b] > array[i, j])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[a, b];
                        array[a, b] = temp;
                    }

}

Console.WriteLine("Наш массив: ");

FillArray(array);
PrintArray(array);
SortArray(array);
Console.WriteLine("Частотный анализ массива: ");

int temp = array[0, 0];
int count = 0;

for (int i = 0; i < array.GetLength(0); i++) // Непосредственно сам частотный анализ.
    for (int j = 0; j < array.GetLength(1); j++)
        if (array[i, j] == temp) count++;
        else
        {
            Console.WriteLine($"Число {temp} встречается {count:00} раз(а), частота {count * 100 / (a * b)}%.");
            count = 1;
            temp = array[i, j];
        }

Console.WriteLine($"Число {array[array.GetLength(0) - 1, array.GetLength(1) - 1]} встречается {count:00} раз(а), частота {count * 100 / (a * b)}%.");
Console.WriteLine();