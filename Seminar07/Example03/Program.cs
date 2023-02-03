/*
 Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса не чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
 Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
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

int[,] ModifyArray(int[,] data)
{
    for (int row = 0; row < data.GetLength(0); row++)
    {
        for (int col = 0; col < data.GetLength(1); col++)
        {
            if (row % 2 == 1 && col % 2 == 1)
                data[row, col] = data[row, col] * data[row, col];
        }
    }
    return data;
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

Console.WriteLine();

int[,] modArray = ModifyArray(array);
PrintArray(modArray);