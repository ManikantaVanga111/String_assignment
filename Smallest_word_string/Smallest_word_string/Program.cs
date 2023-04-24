// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;

Console.WriteLine("Enter the no. of words ");
int n=Convert.ToInt32(Console.ReadLine());
string[] city = new string[n];
string shortest=String.Empty;
for (int i = 0; i < city.Length; i++)
{
    city[i] = Console.ReadLine();
    shortest = city[i];
}
for(int i=0; i < city.Length; i++)
{
    if (city[i].Length < shortest.Length)
    {
        shortest = city[i];
    }
    
}
Console.WriteLine($"The shortest word is {shortest}");

