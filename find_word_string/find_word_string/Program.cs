// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the no. of words ");
int n = Convert.ToInt32(Console.ReadLine());
string[] city = new string[n];
for (int i = 0; i < city.Length; i++)
{
    city[i] = Console.ReadLine();

}
bool find1=false;
string find=Console.ReadLine();
for (int i = 0; i < city.Length; i++)
{
    if (city[i] == find)
    {
        find1 = true;
        break;
    }
}
if (find1==true)
{
    Console.WriteLine($"The word is present in the list is {find}");
}else
{
    Console.WriteLine($"The word is not present in the list is {find}");
}