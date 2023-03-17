int[] numbers = { 12, 1, 2, -19, 3,4,5, 6, 7, 8, 9 };
Console.WriteLine($"Min number which is not in massive is: {NotContains(numbers)}");
static int NotContains(int[] array)
{
    int number = 1;
    while (true)
    {
        if (!array.Any(i => i == number))
            return number;
        number++;
    }
}
