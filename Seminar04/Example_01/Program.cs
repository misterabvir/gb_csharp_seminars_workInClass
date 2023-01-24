/****************************************************
* Задача 24: Напишите программу, которая принимает  *
* на вход число (А) и выдаёт сумму чисел от 1 до А. *
*****************************************************/

int Sum(int lim)
{
    int sum = 0;
    for (int i = 1; i <= lim; i++) sum += i;
    return sum;
}

Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers from 1 to {number} equal {Sum(number)}");

