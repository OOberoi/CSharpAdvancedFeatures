// See https://aka.ms/new-console-template for more information

//DateTime types
DateTime birthDate = new DateTime(1975, 1, 11, 8, 38, 0);
double hours = 0;
int rate = 0;


Console.WriteLine($"Enter your birthdate:  { birthDate}");
Console.ReadLine();

Console.WriteLine($"Enter hours worked: {hours}" );
Console.ReadLine();

Console.WriteLine($"Enter you rate: {rate}");
Console.ReadLine();

Console.WriteLine($"Your wages are: {hours * (Convert.ToDouble(rate)) }");