// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, Obi! It's time to drill into some advanced features of C# 10.0");

string[] names = { "Obi", "Mark", "Erfan" };

Array.Sort(names);

foreach (var item in names)
{
    Console.WriteLine(item);
}
Console.WriteLine("Enter a package");
string packages = Console.ReadLine();
Console.WriteLine(packages);


