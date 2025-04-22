// See https://aka.ms/new-console-template for more information


Console.WriteLine("Enter first number");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number");
double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Choose Operator: +, -, *, /");
string Operator = Console.ReadLine();

double sum = 0;

 if (Operator == "+")
{
    sum = firstNumber + secondNumber;
} else if (Operator == "-")
{
    sum = firstNumber - secondNumber;
} else if (Operator == "*")
{
    sum = firstNumber * secondNumber;
} else if (Operator == "/")
{
    sum = firstNumber / secondNumber;
}

Console.WriteLine(sum);