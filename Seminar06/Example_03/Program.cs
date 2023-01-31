/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

Console.WriteLine("Enter your size of side A: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your size of side B: ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your size of side C: ");
int sideC = Convert.ToInt32(Console.ReadLine());

bool IsExist(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

if(IsExist(sideA, sideB, sideC)) Console.WriteLine("triangle exist");
else Console.WriteLine("triangle is not exist");

