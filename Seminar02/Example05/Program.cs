/***********************************************************************
* Задача 16: Напишите программу, которая принимает на                  *
* вход два числа и проверяет, является ли одно число квадратом другого.*
*                                                                      *
*  5, 25  ->  да                                                       *
* -4, 16  ->  да                                                       *
* 25,  5  ->  да                                                       *
*  8,  9  ->  нет                                                      *
************************************************************************/
Console.WriteLine("Enter two numbers separated by a space");
string[] strArray = (Console.ReadLine() ?? "").Split(' '); 

int num1 = Convert.ToInt32(strArray[0]);
int num2 = Convert.ToInt32(strArray[1]);

if(num1 == num2 * num2 || num2 == num1 * num1)
{ 
    Console.WriteLine("one of the numbers is a square of the other");
}
else 
{
    Console.WriteLine("neither number is the square of the other");
}
