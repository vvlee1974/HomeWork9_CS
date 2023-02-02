/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string message)
{
    int result = 0;

    Console.Write(message);

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Введённое число не является натуральным.");
        }
    }

    return result;
}

(int, int) CheckNumbers(int m, int n)
{
    int p = 0, q = 0;

    if (n < m)
    {
        Console.WriteLine("Введённые данные не соответствуют условиям задачи.");
    }
    else
    {
        p = m;
        q = n;
    }
    return (p, q);
}

int GetSum(int p, int q)
{
    int sum = p;

    if (p == q)
        return p;

    if (q > p)
        sum += GetSum(p + 1, q);

    return sum;
}

int m = GetNumber("Введите число M - начало числового ряда: ");
int n = GetNumber("Введите число N - конец числового ряда: ");

(int p, int q) = CheckNumbers(m, n);

int sum = GetSum(p, q);
Console.WriteLine($"Сумма всех чисел от {p} до {q} = {sum}");