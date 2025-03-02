using System;

// Functions are used to group re-usable code together in a single
// unit that can be customized with parameters.

// TODO: Functions have a return type, name, and optional parameters
float MilesToKM(float miles)
{
    return miles * 1.60934f;
}

// TODO: A function with no return value has a 'void' type
void PrintWithPrefix(string str)
{
    Console.WriteLine($"::>{str}");
}

// TODO: Call first function
Console.WriteLine($"Result is : {MilesToKM(12f)}");
Console.WriteLine($"Result is : {MilesToKM(2.21f)}");

// TODO: Call second function
PrintWithPrefix("This is a test");
PrintWithPrefix("Another test");
