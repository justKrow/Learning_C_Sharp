int[] quarters = { 1, 2, 3, 4 };
int[] sales = { 100000, 140000, 200000, 225000 };
double[] intlMixPct = { .234, .123, .454, .456 };
String str1 = "Test String";
int val1 = 1234;
decimal val2 = 1234.4567m;

// Basic Formatting information
Console.WriteLine("{0}", str1);

// TODO: Specifying Numerical formatting
// General format is {index[,alignment]:[format]}
// Common types are N (Number), G (General), F (Fixed-point), 
// E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
// C (Currency in local format)
Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", val1);
Console.WriteLine("{0:E}, {0:N}, {0:F}, {0:G}", val2);

// TODO: Add a number after the format to specify precision
Console.WriteLine("{0:D6}, {0:N2}, {0:F1}, {0:G3}", val1);


// TODO: Formatting with alignment and spacing
// TODO: Formatting with currency symbol and thousand separator
Console.WriteLine("{0,12}, {1,12},{2,12},{3,12}", quarters[0], quarters[1], quarters[2], quarters[3]);
Console.WriteLine("{0,12:P0}, {1,12:P0},{2,12:P1},{3,12:P3}", sales[0], sales[1], sales[2], sales[3]); 2