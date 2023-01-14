/*
Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8
*/
int number;
do{
    Console.Clear();
    Console.Write("Input number: ");
    number = Convert.ToInt32(Console.ReadLine());
}while(number < 100 || number >= 1000);

Console.WriteLine($"Result: {number%10}");