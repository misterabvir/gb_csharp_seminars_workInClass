/*
double
*/

double number = new Random().NextDouble(); // 0...1
Console.WriteLine("{0:0.##}", number);

double number1 = new Random().NextDouble() * 10; // 0...10
Console.WriteLine("{0:0.##}", number1);