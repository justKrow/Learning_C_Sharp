int val = 50;

switch (val)
{
    case 50:
        Console.WriteLine("Value is 50");
        break;
    case 40:
        Console.WriteLine("Value is 40");
        break;
    case 55:
    case 56:
    case 57:
        Console.WriteLine("Value is 55, 56, or 57");
        break;
    default:
        Console.WriteLine("Value is not 40 or 50");
        break;
}