// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the no. of words ");
int n = Convert.ToInt32(Console.ReadLine());
string[] word = new string[n];
string palindrome = String.Empty;
for (int i = 0; i < word.Length; i++)
{
    word[i] = Console.ReadLine();
}
int count = 0;
for (int i = 0; i < word.Length; i++)
{
    string reverse = String.Empty;

    for (int j = word[i].Length - 1; j >= 0; j--)
    {
        reverse = reverse + word[i][j];
    }
    if (word[i] == reverse)
    {
        count++;
        palindrome += word[i];

    }
    }
    if (count > 0)
    {
        Console.WriteLine($"The number of palindromes in the list is {count}");
        Console.WriteLine(palindrome);
}
    else
    {
        Console.WriteLine("No palindromes in the list");
    }

