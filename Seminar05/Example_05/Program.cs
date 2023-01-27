/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] GetArray()
{
    Random rand = new Random();
    int[] data = new int[rand.Next(5, 10)];
    for (int i = 0; i < data.Length; i++)
    {
        data[i] = rand.Next(-9, 10);
    }
    return data;
}

int[] GetMultipliers(int[] data)
{
    bool flag = data.Length % 2 != 0;
    int length = data.Length / 2 + (flag ? 1 : 0);
    int[] array = new int[length];
    for (int i = 0; i < length - 1; i++)
    {
        array[i]= data[i] * data[data.Length - 1 - i];
    }
    if (flag) array[array.Length - 1] = data[data.Length/2];
    return array;
}

int[] array = GetArray();
int[] multiArray = GetMultipliers(array);
Console.Write($"[{string.Join(", ", array)}] --> ");
Console.Write($"[{string.Join(", ", multiArray)}]");






