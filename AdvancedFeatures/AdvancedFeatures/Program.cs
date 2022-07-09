// See https://aka.ms/new-console-template for more information

using System.Collections;

// Get user input
Console.WriteLine("Enter package(s) delimited by comma");
string package = Console.ReadLine();
Console.WriteLine("The package name(s) are: " + package);

string[] arrCol = new string[] { };

if (package != null)
{
    arrCol = package.Split(',');

    foreach (var item in arrCol)
    {
        Console.WriteLine(item);
    }
}

Console.ReadLine();