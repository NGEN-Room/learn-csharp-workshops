Console.WriteLine("Enter a Value");
int value = Convert.ToInt32(Console.ReadLine());

if (0 <= value < 60)
{
    Console.WriteLine("F Tier");
}
else if (60 =< value < 70){
    Console.WriteLine("D Tier");
}
else if (70 =< value < 80){
    Console.WriteLine("C Tier");
}
else if (80 =< value < 90){
    Console.WriteLine("B Tier");
}
else if (90 =< value < 100)
{
    Console.WriteLine("A Tier");
}
else if (value = 100)
{
    Console.WriteLine("S Tier");
}
else {
    Console.WriteLine("Error, Not a valid input");
}