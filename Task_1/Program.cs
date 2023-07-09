// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int PrintNumber(int m, int n)
{
    if (m < n) m += PrintNumber(m + 1, n);
    return m;
}
int sum = PrintNumber(4, 8);
Console.WriteLine(sum);