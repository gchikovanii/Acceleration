Console.WriteLine(CountVariants(5));
Console.WriteLine(CountVariants(2));
Console.WriteLine(CountVariants(1));
static int CountVariants(int stairCount)
{
    int c = 1;
    int temp = 1;
    int current;
    for (int i = 2; i <= stairCount; i++)
    {
        current = c + temp;
        temp = c;
        c = current;
    }
    return c;
}

