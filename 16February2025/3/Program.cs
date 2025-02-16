Console.Write("Enter first number : ");

double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second number : ");

double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter operation ( +, -, *, / ) : ");

char operation = Convert.ToChar(Console.ReadLine());

switch (operation)
{
    case '+':
        Console.WriteLine("Result : " + (num1 + num2));
        break;
    case '-':
        Console.WriteLine("Result : " + (num1 - num2));
        break;
    case '*':
        Console.WriteLine("Result : " + (num1 * num2));
        break;
    case '/':
        Console.WriteLine("Result : " + (num1 / num2));
        break;
}