/******************************************************
* Задача 28: Напишите программу, которая принимает на *
* вход число N и выдаёт произведение чисел от 1 до N. *
*******************************************************/

int Multiply(int lim)
{
    int mult = 1;
    for (int i = 1; i <= lim; i++) mult *= i;
    return mult;
}

Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Multiply of numbers from 1 to {number} equal {Multiply(number)}");

