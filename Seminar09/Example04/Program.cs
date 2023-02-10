/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 
 */

int number = 354;
int result = SumOfDigits(number);
Console.WriteLine($"Amount of digits in number ({number}) = {result}");  


int SumOfDigits(int num)
{ 
    if(num == 0) return 0;
    return num % 10 + SumOfDigits(num / 10); 
}