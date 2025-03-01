int x = 1001, y = 0;
int result;

try
{
    if (x > 1000)
    {
        throw new ArgumentException("x", "x must be 1000 or less");
    }
    result = x / y;
    Console.WriteLine("Result of division is {0}", result);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("An error occurred during division");
    Console.WriteLine(e.Message);
}
catch (ArgumentException e)
{
    Console.WriteLine("Error Message: {0}", e.Message);
}
finally
{
    Console.WriteLine("This code block will always execute");
}