Console.WriteLine("Enter money in tetri: ");
int tetri = Int32.Parse(Console.ReadLine());
Console.WriteLine($"Min count of coins are: {MinSplit(tetri)}");

static int MinSplit(int amount)
{
	int count = 0;
    int[] tetrebi = { 1, 5, 10, 20, 50 };
	int index = tetrebi.Length - 1;
	int result;
	while(amount != 0)
	{
		result = amount / tetrebi[index];
		if(result > 0)
		{
            count += result;
            amount -= result * tetrebi[index];
            index--;
        }
		else if(result == 0)
		{
            index--;
        }
        else
			return result;
    }
	return count;
}
