// See https://aka.ms/new-console-template for more information

using System.Collections;

Console.WriteLine("Hello, Obi! It's time to drill into some advanced features of C# 10.0");

string[] names = { "Obi", "Mark", "Erfan" };

Array.Sort(names);

foreach (var item in names)
{
    Console.WriteLine(item);
}
Console.ReadLine();

// Get user input
Console.WriteLine("Enter package(s) delimited by comma");
string package = Console.ReadLine();
Console.WriteLine("The package name(s) are: " + package);

string[] arrCol = new string[5];
if (package != null)
{
    arrCol = package.Split(',');

    foreach (var item in arrCol)
    {
        Console.WriteLine(item);
    }
}

Console.ReadLine();