// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMassive(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write($"0{matrix[i, j]}\t");
            else Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
int[,] SpiralArray(int row, int column)
{
    int start = 1;
    int[,] matrix = new int[row, column];
    int size = matrix.GetLength(0);
    for (int count = 0; count < size / 2; count++)
    {
        for (int j = count; j <= size - count - 1; j++)
        {
            matrix[count, j] = start;
            start++;
        }
        for (int i = count + 1; i < size - count; i++)
        {
            matrix[i, size - count - 1] = start;
            start++;
        }
        for (int j = size - count - 2; j >= count; j--)
        {
            matrix[size - count - 1, j] = start;
            start++;
        }
        for (int i = size - count - 2; i >= count + 1; i--)
        {
            matrix[i, count] = start;
            start++;
        }
    }
    return matrix;
}

int[,] matrix = SpiralArray(4, 4);

PrintMassive(matrix);

