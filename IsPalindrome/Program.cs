// See https://aka.ms/new-console-template for more information

/* 
The code creates a console application where the user is prompted
to enter a string. It defines a method called IsPalindrome to 
check if the string is a palindrome. The method removes spaces 
and converts the string to lowercase before comparing it to its
reversed version. If the original string matches the reversed
string, it prints that the string is a palindrome; otherwise,
it indicates that the string is not a palindrome.
*/

string[] words =  {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}
bool IsPalindrome(string word)
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
    }
    return true;
}