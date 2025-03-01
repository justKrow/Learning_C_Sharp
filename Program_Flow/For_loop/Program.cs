int val = 15;
int[] nums = new int[] { 2, 5, 34, 7, 3 };
string str = "hi i am kind of dumb";

Console.WriteLine("----------Basic Loop----------------");
for (int i = 0; i < val; i++)
{
    Console.WriteLine("i is currently " + i);
}

Console.WriteLine("----------For each Loop----------------");
foreach (int i in nums)
{
    Console.WriteLine("i is currently " + i);
}

Console.WriteLine("----------String Loop----------------");
var count = 0;
foreach (char c in str)
{
    if (c == 'a')
    {
        count++;
    }
}
Console.WriteLine("Number of 'a' characters: " + count);