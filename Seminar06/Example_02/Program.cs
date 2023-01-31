/*
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

Console.Write("Enter length of array: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter min: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] GetArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void Print(int[] data)
{
    for (int i = 0; i < data.Length; i++)
        Console.Write($"[{i}] = {data[i],2}    ");
    Console.WriteLine();
}

int[] Reverse(int[] data)
{
    int[] reverse = new int[data.Length];
    for (int i = 0; i < data.Length; i++)
    {
        reverse[i] = data[data.Length - 1 - i];
    }
    return reverse;
}



int[] array = GetArray(number, min, max);
Print(array);
int[] reversedArray = Reverse(array);
Print(reversedArray);


