// See https://aka.ms/new-console-template for more information

using System.Globalization;

//DateTime types
DateTime birthDate = new DateTime(1975, 1, 11, 8, 38, 0);




Console.WriteLine($"Enter your birthdate:  { birthDate}");
Console.ReadLine();

Console.WriteLine("Enter hours worked: " );
string hours = Console.ReadLine();

Console.WriteLine("Enter you rate:");
string rate = Console.ReadLine();

double wages = Convert.ToDouble(Convert.ToDecimal(hours) * Convert.ToDecimal(rate));

Console.WriteLine($"Your wages are: {wages.ToString("C", CultureInfo.CurrentCulture)}");