﻿/* Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int Numbers(int n)
{
    int result = 0;

    if (n == 1) return 1;

    Console.Write($"{n}  ");

    result = Numbers(n - 1);

    return result;
}

int numbers = Numbers(8);

Console.WriteLine(numbers);
