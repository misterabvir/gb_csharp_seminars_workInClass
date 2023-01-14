/* Задача №3.Напишите программу, которая будет выдавать название дня недели по заданному номеру.
*  3 -> Среда 
*  5 -> Пятница
*/
Console.Write("Input count day of week: ");
int countOfWeek = Convert.ToInt32(Console.ReadLine());



if(countOfWeek == 1){Console.WriteLine("Monday");}
else if (countOfWeek == 2) {Console.WriteLine("Tuesday");}
else if (countOfWeek == 3) {Console.WriteLine("Wednesday");}
else if (countOfWeek == 4) {Console.WriteLine("Thursday");}
else if (countOfWeek == 5) {Console.WriteLine("Friday");}
else if (countOfWeek == 6) {Console.WriteLine("Saturday");}
else if (countOfWeek == 7) {Console.WriteLine("Sunday");}
else {Console.WriteLine("Wrong input");}

