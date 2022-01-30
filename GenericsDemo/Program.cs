// See https://aka.ms/new-console-template for more information
using GenericsDemo;

Console.WriteLine("Generic method");
int[] intArray = { 2, 4, 5, 6, 8 };
char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
double[] doubleArray = { 1.1, 3.3, 5.5, 8.7 };

Class1.Display<int>(intArray);
Class1.Display<char>(charArray);
Class1.Display<double>(doubleArray);
Console.ReadKey();

