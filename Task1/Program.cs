﻿// Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using static System.Console;
Clear();

Write("Введите число: ");
Num(int.Parse(ReadLine()!));

void Num(int n)
{
    if(n > 0)
    {
        Write($"{n} ");
        Num(n - 1);
    }
}
