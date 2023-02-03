/*
 Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
 */

int[,] GetArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            array[row, col] = new Random().Next(-9, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col],5}");
        }
        Console.WriteLine();
    }
}

int SumOfElementsInMainDiagonal(int[,] array)
{
    int amount = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (col == row) amount += array[row, col];
        }
    }
    return amount;
}

Console.Write("Input count of row   : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of column: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, cols);
PrintArray(array);
int sum = SumOfElementsInMainDiagonal(array);
Console.WriteLine($"Amount: {sum}");