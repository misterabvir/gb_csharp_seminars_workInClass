/*
Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
 */

int[,] Get2DArray()
{
    Random rand = new Random();
    int[,] array = new int[rand.Next(5, 10), rand.Next(5, 10)];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            array[row, col] = rand.Next(10, 100);
        }
    }
    return array;
}

void Print(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col],5}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

(int minIndexRow, int minIndexCol) GetMin(int[,] data)
{
    int min = data[0, 0], minRow = 0, minCol = 0;

    for (int row = 0; row < data.GetLength(0); row++)
    {
        for (int col = 0; col < data.GetLength(1); col++)
        {
            if (data[row, col] < min)
            { 
                min = data[row, col]; 
                minRow = row;
                minCol= col;
            }
        }
    }
    return (minRow, minCol);
}

int[,] GetModifiedArray(int[,] data, (int r, int c) ind)
{
    int[,] array = new int[data.GetLength(0) - 1, data.GetLength(1) - 1];
    for (int row = 0; row < data.GetLength(0); row++)
    {
        for (int col = 0; col < data.GetLength(1); col++)
        {
            if (row > ind.r && col > ind.c) array[row - 1, col - 1] = data[row, col];
            else if (row > ind.r) array[row - 1, col] = data[row, col];
            else if (col > ind.r) array[row, col - 1] = data[row, col];
            else array[row, col] = data[row, col];
        }
    }
    return array;
}


/////////////////////////////////////////////////////////////

int[,] matrix = Get2DArray();
Print(matrix);
(int minRow, int minCol) indexes = GetMin(matrix);
int[,] modified = GetModifiedArray(matrix, indexes);
Print(modified);

