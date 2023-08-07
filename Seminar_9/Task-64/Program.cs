// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// string PrintNumber(int n)
// {
//     if (n == 1) return n.ToString();
//     return PrintNumber(n - 1) + ", " + n;
// }

// int GetInput(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int n = GetInput("Введите число ");
// Console.WriteLine($"{PrintNumber(n)}");



int PrintNumber(int n)
{
    if (n > 1)
    {
        Console.Write((n)+" ");
        n--;
        return PrintNumber(n);
    }
    return (n);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int n = GetInput("Введите число ");
Console.Write(PrintNumber(n));
