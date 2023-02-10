/*
    Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
 */

Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
Print(number);

void Print(int num)
{
    if (num == 1)
    {
        Console.Write(num);
        return;
    }
    Print(num - 1);
    Console.Write(", " + num);
}