// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();

Write("Задайте значение M: ");
int M = int.Parse(ReadLine()!);
Write("Задайте значение N: ");
int N = int.Parse(ReadLine()!);

int SumFromMToN(int start, int end)
{
    if (start == end) return start;
    return end + SumFromMToN(start, end - 1);
}
WriteLine($"Сумма натуральных элементов в промежутке от M до N = {SumFromMToN(M, N)}");
