int[] siffror = new int[5];
Console.WriteLine("Välj 5 värden nedan:");
siffror[0] = Convert.ToInt32(Console.ReadLine());
siffror[1] = Convert.ToInt32(Console.ReadLine());
siffror[2] = Convert.ToInt32(Console.ReadLine());
siffror[3] = Convert.ToInt32(Console.ReadLine());
siffror[4] = Convert.ToInt32(Console.ReadLine());

foreach (int siffra in siffror)
{
    Console.WriteLine(siffra);
}







/*
int[] siffror = new int[5];

siffror[0] = 5;
siffror[1] = 6;
siffror[2] = 10;
siffror[3] = 15;
siffror[4] = 16;

foreach (int siffra in siffror)
{
    if (siffra == 10)  
    {
        Console.WriteLine("Exakt 10");
    }
    else if (siffra > 10)
    {
        Console.WriteLine("Över 10");
    }
    else
    {
        Console.WriteLine("Siffran under 10");
    }
}
*/

/*
 List<string> frukter = new();

frukter.Add("Banan");
frukter.Add("Äpple");
frukter.Add("Citron");
frukter.Add("Apelsin");
frukter.Add("Ananas");

foreach (string frukt in frukter)
{
    Console.WriteLine(frukt);
}

Console.WriteLine();

string[] djur = new string[5];
djur[0] = "Hund";
djur[1] = "Katt";
djur[2] = "Råtta";
djur[3] = "Lejon";
djur[4] = "Varg";

foreach (string djuren in djur)
{
    Console.WriteLine(djuren);
}
*/