/******************************************************************
*  Задача №3.Напишите программу,                                  *
*  которая будет выдавать название дня недели по заданному номеру.*
*  3 -> Среда                                                     *
*  5 -> Пятница                                                   *
*******************************************************************/

Console.Write("Input count day of week: ");
int dayOfWeekNumber = Convert.ToInt32(Console.ReadLine());

if(dayOfWeekNumber == 1) Console.WriteLine("Monday");
else if(dayOfWeekNumber == 2) Console.WriteLine("Tuesday");
else if(dayOfWeekNumber == 3) Console.WriteLine("Wednesday");
else if(dayOfWeekNumber == 4) Console.WriteLine("Thursday");
else if(dayOfWeekNumber == 5) Console.WriteLine("Friday");
else if(dayOfWeekNumber == 6) Console.WriteLine("Saturday");
else if(dayOfWeekNumber == 7) Console.WriteLine("Sunday");
else Console.WriteLine("Wrong input");

