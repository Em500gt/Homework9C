// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();

Write("Задайте значения M и N: ");
string[] parameter = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine(Summ(int.Parse(parameter[0]), int.Parse(parameter[1]), 0));

int Summ(int m, int n, int sum)
{
    return m >= n + 1? sum: Summ(m + 1, n, sum + m);
}