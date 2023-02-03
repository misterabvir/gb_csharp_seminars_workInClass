/*
**   Задача 46: Задайте двумерный массив размером m×n, 
**  заполненный случайными целыми числами.
**  m = 3, n = 4.
**  1 4 8 19
**  5 -2 33 -2
**  77 3 8 1   
*/

int[,] GetArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            array[row, col] = new Random().Next(-99, 100);
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

Console.Write("Input count of row   : ");
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input count of column: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, cols);
PrintArray(array);