// See https://aka.ms/new-console-template for more information

using System.Collections;
using System;

// Get package name
Console.WriteLine("Enter package(s) delimited by comma");
string package = Console.ReadLine();

if (package != null)
{
    Console.WriteLine("The value cannot be null! Please enter a package name.");
}
Console.WriteLine("The package name(s) are: " + package);
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