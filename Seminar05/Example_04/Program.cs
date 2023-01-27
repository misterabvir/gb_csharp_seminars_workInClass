/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
int[] GetArray(int length)
{
    Random rand = new Random();
    int[] data = new int[length];
    for (int i = 0; i < length; i++)
    {
        data[i] = rand.Next(-9, 10);
    }
    return data;
}

int GetCount(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= min && array[i] <= max) count++;
    }
    return count;
}

int[] array = GetArray(123);
int amount = GetCount(array, 10, 99);

Console.WriteLine("Amount elements of array: {0}", amount);