// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void StringSumMux(int[] array)
{
    int min = array[0];
    int minI = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minI = i;
        }
    }
    Console.WriteLine("Минимальная сумма элементов  в строке: " + minI);
    Console.WriteLine(min);// для проверки расчета
}

int[] SumString(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        array[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i] = array[i] + matrix[i, j];
        }
    }
    return array;
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
int[] array = SumString(matrix);
Console.WriteLine();
StringSumMux(array);
