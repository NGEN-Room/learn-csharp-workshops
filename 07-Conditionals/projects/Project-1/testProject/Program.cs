Console.WriteLine("Enter a Value");
int value = Convert.ToInt32(Console.ReadLine());

if (value >= 0 && value <= 100)
{




    if (100 == value)
    {
        Console.WriteLine("S Tier");
    }
        else if (90 <= value)
    {
        Console.WriteLine("A Tier");
    }
        else if (80 <= value){
        Console.WriteLine("B Tier");
    }
        else if (70 <= value){
        Console.WriteLine("C Tier");
    }
        else if (60 <= value){
        Console.WriteLine("D Tier");
    }
    else
    {
        Console.WriteLine("F Tier");
    }
    
}
else{
    Console.WriteLine("Error");
}