// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumMN(int m, int n)
{
    if (m == n) return m;
    return m + SumMN(m + 1, n);
}
    
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int m = GetInput("Введите  минимальное число: ");
int n = GetInput("Введите  максимальное число: ");

Console.WriteLine("M = {0}; N = {1}; -> {2}", m,n, SumMN(m,n));

