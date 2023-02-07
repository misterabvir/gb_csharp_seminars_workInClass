/*
Задача 53: Задайте двумерный массив. 
Напишите программу, которая поменяет местами 
первую и последнюю строку массива.
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

int[,] Modify(int[,] data)
{
    int last = data.GetLength(0) - 1;

    for (int col = 0; col < data.GetLength(1); col++)
    {
        (data[0, col], data[last, col]) = (data[last, col], data[0, col]); //обмен значениями
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

 


