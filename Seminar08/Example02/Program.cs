/*
Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.
 */



int[,] Get2DArray()
{
    Random rand = new Random();
    int length = rand.Next(5, 10);
    int[,] array = new int[length, length];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            array[row, col] = rand.Next(10, 100);
        }
    }
    return array;
}

int[,] Modify(int[,] data)
{
    for (int row = 0; row < data.GetLength(0); row++)
    {
        for (int col = row + 1; col < data.GetLength(1); col++)
        {
            (data[row, col], data[col, row]) = (data[col, row], data[row, col]); //обмен значениями
        }
    }
    return data;
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



/////////////////////////////////////////////////////////////
int[,] matrix = Get2DArray();
Print(matrix);
matrix = Modify(matrix);
Print(matrix);





