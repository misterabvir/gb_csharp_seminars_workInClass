/****************************************************************
* Задача 14: Напишите программу, которая принимает на           *
* вход число и проверяет, кратно ли оно одновременно 7 и 23.    *
* 14 -> нет                                                     * 
* 46 -> нет                                                     *
* 161 -> да                                                     *
*****************************************************************/
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 7 == 0 && number % 23 == 0) 
    Console.WriteLine($"{number} is a multiple of 7 and a multiple of 23");
else 
    Console.WriteLine($"{number} is not a multiple of 7 AND a multiple of 23 at the same time");