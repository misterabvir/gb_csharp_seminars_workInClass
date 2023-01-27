/*
Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

int[] GetArray()
{
    Random rand = new Random();
    var length = rand.Next(5, 11);
    int[] data = new int[length];
    for (int i = 0; i < length; i++)
    {
        data[i] = rand.Next(-9, 10);
    }
    return data;
}

void Print(int[] data)
{
    for (int i = 0; i < data.Length; i++)
    {
        Console.Write($"{data[i],3}, ");
    }
    Console.WriteLine("\b\b  ");
}

int[] Reverse(int[] data)
{
    for (int i = 0; i < data.Length; i++)
    {   
        data[i] *= -1;
    }
    return data;
}

///////////////////////////////////////////////////
int[] array = GetArray();
Print(array);
int[] revArray = Reverse(array);
Print(revArray);