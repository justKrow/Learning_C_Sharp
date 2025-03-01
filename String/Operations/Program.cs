string outstr;
string str1 = "Thick thighs save lives";
string str2 = "ThiS is a Thigh";
string str3 = "THIS is a THIGH";
string[] strs = { "one", "two", "three", "four" };

// lenght of string 
Console.WriteLine("Length of str1: " + str1.Length);

// access individual characters
Console.WriteLine("Character at index 5 of str2: " + str2[5]);

// iterate over string
foreach (char c in str1)
{
    if (c == 'i')
    {
        continue; // skip i characters
    }
    Console.Write(c);
}

// string concatenation
outstr = String.Concat(strs);
Console.WriteLine("\narray to string: " + outstr);

// join strings with join
outstr = String.Join(",", strs);
Console.WriteLine("Array to string with join: " + outstr);

outstr = String.Join("---", strs);
Console.WriteLine("Array to string with join: " + outstr);

//String comparison
// 0 : same position in same order
// < 0 : first string come before second in sort order
// > 0 : first string come after second in sort order
int result = String.Compare(str2, "ThiS is a Thigh");
Console.WriteLine("Comparison result: " + result);

// Equal return bool
bool isEqual = str2.Equals(str3);
Console.WriteLine("Is str2 equal to str3: " + isEqual);

// string searching
Console.WriteLine("Index of first 'i' in str1: " + str1.IndexOf('i'));
Console.WriteLine("Index of first 'g' in str2: " + str2.IndexOf('g'));

Console.WriteLine("Index of last 'i' in str1: " + str1.LastIndexOf('i'));
Console.WriteLine("Index of last 'g' in str2: " + str2.LastIndexOf('g'));

outstr = str1.Replace("Thick", "Puffy");
Console.WriteLine("Replace 'Thick' with 'Puffy': " + outstr);
Console.WriteLine("Index of 'save' : " + outstr.IndexOf("save"));