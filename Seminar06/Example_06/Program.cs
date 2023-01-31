/*
    Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

int[] GetRandom()
{
    int[] data = new int[new Random().Next(5, 10)];
    for (int i = 0; i < data.Length; i++)
    {
        data[i] = new Random().Next(10, 100);
    }
    return data;
}

int[] GetCopy(int[] source)
{
    int[] data = new int[source.Length];
    for (int i = 0; i < source.Length; i++)
    {
        data[i] = source[i];
    }
    return data;
}

void Print(int[] data)
{
    for (int i = 0; i < data.Length; i++)
        Console.Write($"[{i}] = {data[i],2}    ");
    Console.WriteLine();
}

/////////////////////////////////////////////////////////
int[] array = GetRandom();
Console.WriteLine(nameof(array));
Print(array);
int[] copy = GetCopy(array);
Console.WriteLine(nameof(copy));
Print(copy);

