/*
* Program for calculate sqrt any integer number 
* created 𝖒𝖎𝖘𝖙𝖊𝖗𝖆𝖇𝖛𝖎𝖗
*/
Console.Write("Input your number: ");
if(int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine($"{number} ^ 2 = {number * number}");
}
else
{
    Console.WriteLine("Wrong input");
}