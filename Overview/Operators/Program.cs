int x = 5, y = 10;
string a = "abcd", b = "efg";

// basic math
Console.WriteLine("Basic math");
Console.WriteLine(x + y); // 15
Console.WriteLine(x - y); // -5
Console.WriteLine(x * y); // 50
Console.WriteLine(x / y); // 0.5
Console.WriteLine(x % y); // 5 
Console.WriteLine((x / y) * x); // 0.5

// increment decrement
Console.WriteLine("Increment decrement");
x++; // x = 6
Console.WriteLine(x);
x--; // x = 5
Console.WriteLine(x);

// adding string (a += b) == (a = a+ b)
a = a + b;
Console.WriteLine("Added string: " + a);

// logical operators
Console.WriteLine("Logical operators");
Console.WriteLine(x > y); // False
Console.WriteLine(x < y); // True
Console.WriteLine(x == y); // False
Console.WriteLine(x != y); // True
Console.WriteLine(x >= y); // False
Console.WriteLine((x > y) || (y >= 5));  // True
Console.WriteLine((x > y) && (y >= 5)); // False

// null-coalescing operator ?? and ??= operator assign value on the right if the left variable is null
string str = null;
Console.WriteLine("the string str is : " + (str ?? "default not null"));
str ??= "default new string";
Console.WriteLine("the string str is : " + str);