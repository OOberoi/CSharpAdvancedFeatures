// See https://aka.ms/new-console-template for more information

using System;


Console.WriteLine("Enter a list of packages delimitted by ','");
string[] packages = new string[] { };

for (int i = 0; i < packages.Length; i++)
{ 
    packages[i] = Console.ReadLine();
    Console.WriteLine("You have entered: " + packages[i]);
}