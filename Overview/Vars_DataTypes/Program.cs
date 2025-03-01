int i = 2;
float f = 2.5f;
decimal d = 10.4m;
bool b = true;
char c = 'A';
string s = "Hello, World!";
var x = 33;
var z = "reckless";

// array
int[] vals = new int[3];
string[] fruits = { "apple", "orange", "grape", "melon" };

// print formatted string
Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", i, f, d, b, c, s, x, z);

// null == no value
object obj = null;
Console.WriteLine(obj);

// implicit convert (eg. long -> int)
long bignum;
bignum = i;

// explicit convert
float i_to_f = (float)i;
Console.WriteLine("{0}", i_to_f);

int f_to_i = (int)f;
Console.WriteLine("{0}", f_to_i);