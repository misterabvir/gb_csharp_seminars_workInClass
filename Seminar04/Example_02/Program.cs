/****************************************************
* Задача 26: Напишите программу, которая принимает  *
* на вход число и выдаёт количество цифр в числе.   *
*****************************************************/

int CountOfNumber(int number)
{
    int count = 0;
    while(number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

Console.Write("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Count of digits in number {num} equal {CountOfNumber(num)}");
