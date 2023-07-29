// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void FinedNumber(int[,] matrix, int number)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number) count++;
        }
    }
    if (count > 0) Console.Write($" Число {number} есть в  массиве");
    else Console.Write($"Числа {number} нет в  массиве");
}

void PrintToDimensionalarray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] GenerateTwoDimensionalArray(int m, int n, int start, int finish)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(start, finish + 1);
        }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк ");
int n = GetInput("Введите количество столбцов ");
int start = GetInput("Введите минимальное значение ");
int finish = GetInput("Введите максимальное значение ");
Console.WriteLine();
int[,] matrix = GenerateTwoDimensionalArray(m, n, start, finish);

Console.WriteLine();

PrintToDimensionalarray(matrix);
Console.WriteLine();

int number = GetInput("Введите искомое значение: ");

FinedNumber(matrix, number);
