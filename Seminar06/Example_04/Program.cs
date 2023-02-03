/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/
int[] GetBinaryArray(int[] data, int number)
{
    int index = 0;
    while(number > 0)
    {
        data[index++] = number % 2;
        //if(num % 2 == 1) num -= 1;
        number /= 2;      
    }
    return data;
}

void PrintBinary(int[] data)
{
    bool flag = false;
    for (int i = data.Length - 1; i >= 0; i--)
    {
        if(data[i] == 1) flag = true;
        if(flag) Console.Write(data[i]);
    }
}

//////////////////////////////////////////////////////////////

int[] arr = new int[32]; // max length for integer in binary
Console.Write("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine()); 
arr = GetBinaryArray(arr, num);
PrintBinary(arr);