// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the no. of words ");
int n = Convert.ToInt32(Console.ReadLine());
string[] city = new string[n];
string shortest = String.Empty;
for (int i = 0; i < city.Length; i++)
{
    city[i] = Console.ReadLine();
}
Array.Sort(city);
for (int i = 0; i < city.Length; i++)
{
    Console.WriteLine(city[i]);
}