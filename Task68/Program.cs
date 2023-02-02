/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumber(string message)
{
    int result = 0;

    Console.Write(message);

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
            Console.WriteLine("Введено не число. Повторите ввод.");
    }

    return result;
}

int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;

    if (m > 0 && n == 0) return AckermanFunction(m - 1, 1);

    if (m > 0 && n > 0) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));

    return AckermanFunction(m, n);
}

int m = GetNumber("Введите значение для числа m: ");
int n = GetNumber("Введите значение для числа n: ");

int function = AckermanFunction(m, n);

Console.WriteLine($"Значение функции Аккермана A({m}, {n}) = {function} ");