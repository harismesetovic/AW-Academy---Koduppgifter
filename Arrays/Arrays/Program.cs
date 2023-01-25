

string[] names = new string[2];
names[0] = "Bo";
names[1] = "Li";

PrintFirst(names);
PrintLast(names);

static void PrintFirst(string[] values)
{
    Console.WriteLine(values[0]);
}

static void PrintLast(string[] values)
{
    Console.WriteLine(values[values.Length - 1]);
}