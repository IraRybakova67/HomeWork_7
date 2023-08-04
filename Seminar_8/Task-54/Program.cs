// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] SortMassive(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int count = 0; count < matrix.GetLength(1) - 1; count++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int sort = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = sort;
                }
            }
        }
    }
    return matrix;
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

int[,] GenerateTwoArray(int m, int n, int start, int finish)
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
int finish = GetInput("Введите максимальное значени ");
Console.WriteLine();
int[,] matrix = GenerateTwoArray(m, n, start, finish);
PrintToDimensionalarray(matrix);
Console.WriteLine();
int[,] sort = SortMassive(matrix);

PrintToDimensionalarray(sort);