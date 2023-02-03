/*
 Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
    m = 3, n = 4.
    0 1 2 3
    1 2 3 4
    2 3 4 5
 */
int[,] GetArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            array[row, col] = row + col;
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