
var ingredients = new List<Tuple<string, int>>();
ingredients.Add(new Tuple<string, int>("Garlic", 1));

AddIngridient();
ListRecipe();

void information()
{

}

void AddIngridient()
{
    string ingredients_ = Console.ReadLine();
    int price = Convert.ToInt32(Console.ReadLine());
    ingredients.Add(new Tuple<string, int>(ingredients_, price));
}

void RemoveIngridient()
{

}

void ListRecipe()
{
    Console.WriteLine();
    Console.WriteLine("Here are your current ingredients:");
    foreach (var item in ingredients)
    {
        Console.WriteLine(item);
    }
}

void Done()
{

}