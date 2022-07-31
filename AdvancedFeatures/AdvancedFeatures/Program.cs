// See https://aka.ms/new-console-template for more information

using System.Collections;
using System;

// Get package name
Console.WriteLine("Enter package(s) delimited by comma");
string package = Console.ReadLine();

// Get Client Id
Console.WriteLine("Enter ClientID");
string? clientId = Console.ReadLine();

if (package != null)
{
    Console.WriteLine("The value cannot be null! Please enter a package name.");
}
Console.WriteLine("The package name(s) are: " + package);

Console.WriteLine($"The Client Id is: {clientId}");
 
/// <summary>
/// dynamic array to story any number of values
/// </summary>
string[] arrCol = new string[] { };

if (package != null)
{
    arrCol = package.Split(',');

    foreach (var item in arrCol)
    {
        Console.WriteLine(item);
    }
}
else
{
    Console.WriteLine("Packages cannot be blank!");
}
Console.ReadLine();