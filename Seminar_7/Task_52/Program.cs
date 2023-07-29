// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 
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

void ArithmeticMean(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum =0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        double mean = Math.Round(sum /matrix.GetLength(0), 1);
        
        Console.Write(mean +"; ");
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
int finish = GetInput("Введите максимальное значени ");
Console.WriteLine();
int[,] matrix = GenerateTwoDimensionalArray(m, n, start, finish);

PrintToDimensionalarray(matrix);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца:  ");
ArithmeticMean(matrix);

Console.WriteLine();
