/*
Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
 */

int[,] Get2DArray(int min, int max)
{
    Random rand = new Random();
    int length = rand.Next(5, 10);
    int[,] array = new int[length, length];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            array[row, col] = rand.Next(min, max);
        }
    }
    return array;
}

void Counting(int[,] data, int[] counter, int min)
{
    for (int row = 0; row < data.GetLength(0); row++)
    {
        for (int col = row + 1; col < data.GetLength(1); col++)
        {
            counter[data[row,col] + (0 - min)]++; 
        }
    }
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

void PrintSimple(int[] data, int min)
{
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i] != 0)
            Console.WriteLine($"{i + min} repeat {data[i]} times");
    }
}

/////////////////////////////////////////////////////////////
int min = -10;
int max = 11;

int[,] matrix = Get2DArray(min, max);
Print(matrix);
int[] counter = new int[max - min];
Counting(matrix, counter, min);
PrintSimple(counter, min);


