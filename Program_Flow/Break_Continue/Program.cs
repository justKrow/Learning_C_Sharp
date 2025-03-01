int[] values = { 15, 24, 5, 89, 43, 12 };

Console.WriteLine("---------------Using break and continue----------");

foreach (int val in values)
{
    if (val <= 50)
    {
        continue;
    }

    Console.WriteLine("Val is currently {0}", val);

    if (val > 30)
    {
        break;
    }
}