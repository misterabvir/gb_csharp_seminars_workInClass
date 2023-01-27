/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] FillArray(int[] data)
{
    Random rand = new Random();
    for (int i = 0; i < data.Length; i++)
    {
        data[i] = rand.Next(-9, 10);
    }
    Console.WriteLine("{" + string.Join(", ", data) + "}");
    return data;
}

void Print(int[] data)
{
    Console.WriteLine("{" + string.Join(", ", data) + "}");
}


(int positive, int negative) GetAmounts(int[] data)
{
    int pos = 0, neg = 0;
    for (int i = 0; i < data.Length; i++)
    {
        if(data[i] > 0) pos+=data[i];
        if(data[i] < 0) neg+=data[i];
    }
    return (pos, neg);
}


//////////////////////////////////////////////////////////
int[] array = new int[12];
array = FillArray(array);
var result = GetAmounts(array);

Print(array);
Console.WriteLine($"Amount of positive: {result.positive,3}");
Console.WriteLine($"Amount of negative: {result.negative,3}");

