/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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
    Console.Write("[");
    for (int i = 0; i < data.Length; i++)
    {
        Console.Write($"{data[i],2}, ");
    }
    Console.WriteLine("\b\b] ");
}

int IndexOf(int[] data, int number)
{
    int index = -1;
    for (int i = 0; i < data.Length; i++)
    {
        if(Math.Abs(number) == Math.Abs(data[i]))
        {
            index = i;
            break;
        }
    }
    return index;
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////
int[] array = GetArray();
Print(array);

Console.Write("Enter number for search: ");
int number = Convert.ToInt32(Console.ReadLine());

int index = IndexOf(array, number);

Console.WriteLine("Value |{0}| {1}", number, index == -1 ? "not found" : $"was found at {index} position" );
