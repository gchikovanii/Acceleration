Console.Write("Enter text : ");
string text = Console.ReadLine();
bool isPalindrome = IsPalindrome(text);
Console.WriteLine($"Is Palindrome? {isPalindrome}");

static bool IsPalindrome(string text)
{
    if (text.Length <= 1)
        return true;
    else
    {
        if (text[0] != text[text.Length - 1])
            return false;
        return IsPalindrome(text.Substring(1, text.Length - 2));
    }

}