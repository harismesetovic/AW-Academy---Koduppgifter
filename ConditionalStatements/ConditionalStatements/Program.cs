

bool isYes = true;
int age = 20;
if (isYes || age > 40)
    Console.WriteLine("Yes");
else if (!isYes)
    Console.WriteLine("!");
else
{
    Console.WriteLine("No");
    Console.WriteLine("No");

}

switch (age)
{
    case 10: Console.WriteLine("Ten"); break;
    case 20: Console.WriteLine("Twenty"); break;
    default: Console.WriteLine("Anything else..."); break;
}
