// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void PrintNumber(int number)
{
    Console.Write($"{number} ");
    if (1 < number) PrintNumber(number - 1);

}

PrintNumber(8);