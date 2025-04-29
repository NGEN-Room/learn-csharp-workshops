// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter First name:");
string firstName = Console.ReadLine();

Console.WriteLine("Enter Last name:");
string lastName = Console.ReadLine();

Random rng = new Random();
int RanNum = rng.Next(100);

Console.WriteLine(firstName.Substring(0,1) + lastName.ToLower() + RanNum);

