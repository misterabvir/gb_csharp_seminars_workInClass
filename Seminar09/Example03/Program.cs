/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
 */

Print(5, 10);

void Print(int M, int N)
{
    if (M == N)
    {
        Console.Write(M);
        return;
    }
    Console.Write(M + ", ");
    Print(M + 1, N);
}