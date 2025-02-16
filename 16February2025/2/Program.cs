Console.Write("Enter the index of day : ");

byte index = byte.Parse(Console.ReadLine());

index %= 7;

switch (index)
{
    case 0:
        Console.WriteLine("Monday");
        break;
    case 1:
        Console.WriteLine("Tuesday");
        break;
    case 2:
        Console.WriteLine("Wednesday");
        break;
    case 3:
        Console.WriteLine("Thursday");
        break;
    case 4:
        Console.WriteLine("Friday");
        break;
    case 5:
        Console.WriteLine("Saturday");
        break;
    case 6:
        Console.WriteLine("Sunday");
        break;
}