Console.WriteLine("Välj vad du vill göra");
Console.WriteLine("Multiplicera");
Console.WriteLine("Addera");
Console.WriteLine("Subtrahera");
Console.WriteLine("Dividera");

string choice = Console.ReadLine().ToLower();

Console.WriteLine("Skriv in 2 nummer efter varandra");

int nummer1 = Convert.ToInt32(Console.ReadLine());
int nummer2 = Convert.ToInt32(Console.ReadLine());

if (choice == "addera")
{
    int resultat = addera(nummer1, nummer2);
    printer(resultat);
}

if (choice == "multiplicera")
{
    int resultat = multiplikation(nummer1, nummer2);
    printer(resultat);
}

if (choice == "subtrahera")
{
    int resultat = subtrahera(nummer1, nummer2);
    printer(resultat);
}

if (choice == "dividera")
{
    int resultat = dividera(nummer1, nummer2);
    printer(resultat);
}


int multiplikation(int nummer1, int nummer2)
{
    int summa = nummer1 * nummer2;
    return summa;
}

int addera(int nummer1, int nummer2)
{
    int summa = nummer1 + nummer2;
    return summa;
}

int subtrahera(int nummer1, int nummer2)
{
    int summa = nummer1 - nummer2;
    return summa;
}

int dividera(int nummer1, int nummer2)
{
    int summa = nummer1 / nummer2;
    return summa;
}

void printer(int värde)
{
    Console.WriteLine(värde);
}