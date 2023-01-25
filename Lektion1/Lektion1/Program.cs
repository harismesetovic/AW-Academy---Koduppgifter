Console.Write("What is your name? ");
string userName = Console.ReadLine();

Console.Write("What is your shoe size? ");
int shoeSize = Convert.ToInt32(Console.ReadLine());

if (shoeSize < 34 || shoeSize> 46)
{
    Console.Write("No shoes of that size available");
}
else
{
    Console.Write("We have shoes available in your size");
}