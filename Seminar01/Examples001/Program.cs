/******************************************************
*Задача №0: написать программу считающую квадрат числа*
*******************************************************/
Console.Write("Input your number: ");
if(int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine($"{number} ^ 2 = {number * number}");
}
else
{
    Console.WriteLine("Wrong input");
}