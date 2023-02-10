/*
   Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
    и возводит число А в целую степень B с помощью рекурсии.
   A = 3; B = 5 -> 243 (3⁵)
   A = 2; B = 3 -> 8
 */

int num = 3, pow = 4;

int result = Pow(num, pow);
Console.WriteLine($"{num}^{pow} = {result}");

int Pow(int number, int power)
{ 
    if(power == 1) return number;
    return number * Pow(number, power - 1);
}
