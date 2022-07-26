// See https://aka.ms/new-console-template for more information

using System.Globalization;

const double gstHst = 1.13;

//DateTime types
DateTime birthDate = new DateTime(1975, 1, 11, 8, 38, 0);

Console.WriteLine("Enter hours worked: " );
string hours = Console.ReadLine();

Console.WriteLine("Enter you rate:");
string rate = Console.ReadLine();

Console.WriteLine("Enter your expenses:");
string expenses = Console.ReadLine();   

double netWages = Convert.ToDouble(Convert.ToDecimal(hours) * Convert.ToDecimal(rate));
double grossWages = netWages * gstHst;
double takeHomeSalary = Convert.ToDouble(grossWages - Convert.ToDouble(expenses));
double gstRemittance = netWages * 0.0925;

Console.WriteLine($"Your Net Wages are: {netWages.ToString("C", CultureInfo.CurrentCulture)}");
Console.WriteLine($"Your Gross Wages are: {grossWages.ToString("C", CultureInfo.CurrentCulture)}");
Console.WriteLine($"Your Total Take Home Salary is: {takeHomeSalary.ToString("C", CultureInfo.CurrentCulture)}");
Console.WriteLine($"Your total remittance is: {gstRemittance.ToString("C", CultureInfo.CurrentCulture)}");
Console.ReadLine();