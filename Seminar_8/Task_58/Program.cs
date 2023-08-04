// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18 
int[,] RezaltMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix3;
}

void PrintMassive(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(" " + matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] GenerateMassive(int row, int column, int start, int finish)
{
    int[,] matrix = new int[row, column];
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

int row1 = GetInput("Введите количество строк первой матрицы ");
int columnl1row2 = GetInput("Введите количество столбцов первой матрицы ");
int column2 = GetInput("Введите количество столбцов второй матрицы ");
int start1 = GetInput("Введите минимальное значение для первой матрицы ");
int finish1 = GetInput("Введите максимальное значение  для первой матрицы ");
int start2 = GetInput("Введите минимальное значение для второй матрицы ");
int finish2 = GetInput("Введите максимальное значение  для второй матрицы ");
Console.WriteLine();
int[,] matrix1 = GenerateMassive(row1, columnl1row2, start1, finish1);
int[,] matrix2 = GenerateMassive(columnl1row2, column2, start2, finish2);
Console.WriteLine(" Первая матрица: ");
PrintMassive(matrix1);
Console.Write(" Вторая матрица: ");
Console.WriteLine();
PrintMassive(matrix2);
Console.WriteLine();
int[,] matrix3 = RezaltMultiplication(matrix1, matrix2);
Console.Write(" Результирующая матрица: ");
Console.WriteLine();
PrintMassive(matrix3);
