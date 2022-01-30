// See https://aka.ms/new-console-template for more information
using FindMaximumNumber;

//Console.WriteLine("Hello, World!");
//Console.WriteLine("Find max Number");
//int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
//Console.WriteLine(output);
//double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(111.2, 22.45, 78.56);
//Console.WriteLine(doubleoutput);
//string strigoutput = MaximumNumberCheck.MaximumStringNumber("22", "33", "44");
//Console.WriteLine(strigoutput);
int[] intarray = { 112, 344, 432, 555, 678 };
GenericMaximum<int> generic = new GenericMaximum<int>(intarray);
generic.PrintMaxValue();
double[] doublearray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
GenericMaximum<double> genericdouble = new GenericMaximum<double>(doublearray);
genericdouble.PrintMaxValue();
string[] stringarray = { "111", "222", "333", "55", "999" };
GenericMaximum<string> genericstring = new GenericMaximum<string>(stringarray);
//genericmaximum<employee> genericstring = new genericmaximum<string>(stringarray);
genericstring.PrintMaxValue();
Console.ReadKey();
