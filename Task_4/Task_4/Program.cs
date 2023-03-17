Console.WriteLine(IsProperly("(()())"));
Console.WriteLine(IsProperly("()())"));
Console.WriteLine(IsProperly("(5*5(3+4))"));

static bool IsProperly(string sequence)
{
    int count = 0;
    for (int i = 0; i < sequence.Length; i++)
    {
        if (sequence[i] == '(')
            count++;
        if (sequence[i] == ')') 
            count--;
        if (count < 0)
            return false;
    }
    return true;
   
}
