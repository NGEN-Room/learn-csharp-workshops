// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Age:");
int age = Convert.ToInt32(Console.ReadLine());



if (age >= 18)
{
    Console.WriteLine("Access Granted, Welcome to the Just B Club");

}

else 
{
    Console.WriteLine("Do you have a valid ticket?");
    string Boolean = Console.ReadLine();
    if (Boolean.Contains("yes", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Access Granted, Welcome to the Just B Club");
    }
    else if (Boolean.Contains("no", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Access Denied, Sorry but your under the age, come back when your older");
    }
    

}
