/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

void Fibonacci(int num)
{
    int num1 = 0;
    int num2 = 1;

    Console.Write(num1 + " " + num2 + " ");
    for (int i = 2; i < num; i++)
    {
        int temp = num1 + num2;
        Console.Write(temp + " ");
        num1 = num2;
        num2 = temp;
    }
}

Fibonacci(10);