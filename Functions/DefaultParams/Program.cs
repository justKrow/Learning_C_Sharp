using System;

// TODO: Functions can provide default values for their parameters
void PrintWithPrefix(string thestr, string prefix = "")
{
    Console.WriteLine($"{prefix} {thestr}");
}

// TODO: Test the default parameters
PrintWithPrefix("Hello, there");
PrintWithPrefix("Hello, there", "Yo!");

// TODO: Call with named params
PrintWithPrefix(prefix: "Yo!", thestr: "Hello, there");
