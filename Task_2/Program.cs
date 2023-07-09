// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int PrintNumber(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return PrintNumber(m - 1, 1);
    }
    else
    {
        return (PrintNumber(m - 1, PrintNumber(m, n - 1)));
    }

}
int sum = PrintNumber(3, 2);
Console.WriteLine(sum);