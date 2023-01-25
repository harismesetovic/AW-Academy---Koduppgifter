


string name = "Bo";
int age = 30;
bool isOlder25 = PrintOut(name, age);

if (isOlder25)
{
    Console.WriteLine("Older than 25 years");
}
else
{
    Console.WriteLine("25 years or younger");
}


bool PrintOut(string name_, int age_)
{
    Console.WriteLine("Name: " + name_);
    Console.WriteLine("Age: " + age_);

    if (age_ > 25)
    {
        return true;
    }
    else
    {
        return false;
    }
}

