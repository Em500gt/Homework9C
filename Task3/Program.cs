// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;
Clear();
Write("Введите два неотрицательных числа m и n: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int a = int.Parse(parameters[0]);
int b = int.Parse(parameters[1]);
if(a < 0 || b < 0) return;
WriteLine(Aker(a,b));

int Aker(int m, int n)
{
    return m == 0? n + 1: (m > 0 && n == 0)? Aker(m - 1, 1): Aker(m - 1, Aker(m, n - 1));
}
