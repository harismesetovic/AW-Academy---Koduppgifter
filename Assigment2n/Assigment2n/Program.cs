

Dictionary<string, double> ingredients = new Dictionary<string, double>();

Information();

while (true)
{
    Console.Write("What would you like to do: ");
    string input = Console.ReadLine();

    if (input.ToLower() == "add")
    {
        AddIngredient();
    }
    else if (input.ToLower() == "remove")
    {
        RemoveIngredient();
    }
    else if (input.ToLower() == "list")
    {
        ListRecipe();
    }
    else if (input.ToLower() == "done")
    {
        Done();
        break;
    }
}


void Information()
{
    Console.WriteLine("Welcome to the Recipe Manager!");
    Console.WriteLine("You can now begin building your own recipe using the following commands.");
    Console.WriteLine("To add a new ingredient, type Add");
    Console.WriteLine("To remove a ingredient, type Remove");
    Console.WriteLine("To show your current recipe, type List");
    Console.WriteLine("If you have completed your recipe type Done. The recipe will print and will also show you the most expensive and cheapest ingredients.");
}

void AddIngredient()
{
    Console.WriteLine("Please enter the name of the ingredient that you would like to add");
    string ingredientName = Console.ReadLine().ToLower();

    Console.WriteLine("Enter the cost of the ingredient: ");
    double price = double.Parse(Console.ReadLine());

    ingredients.Add(ingredientName, price);
    Console.WriteLine("Ingredient added.");
    Console.WriteLine();
}

void RemoveIngredient()
{
    Console.WriteLine("Please enter the name of the ingredient that you would like to remove");
    string ingredientName = Console.ReadLine().ToLower();

    ingredients.Remove(ingredientName);
    Console.WriteLine("Ingredient removed.");
    Console.WriteLine();
}

void ListRecipe()
{
    Console.WriteLine();
    Console.WriteLine("Here are your current ingredients");

    foreach (var ingredient in ingredients)
    {
        Console.WriteLine($"{ingredient.Key}, {ingredient.Value} kr");
    }
}

void Done()
{
    double totalCost = 0;
    double cheapestCost = double.MaxValue;
    string cheapestIngredient = "";
    double mostExpensiveCost = 0;
    string mostExpensiveIngredient = "";

    Console.WriteLine();
    Console.WriteLine("Here is your completed shopping list");
    foreach (var ingredient in ingredients)
    {
        Console.WriteLine($"{ingredient.Key}, {ingredient.Value} kr");

        totalCost += ingredient.Value;
        if (ingredient.Value < cheapestCost)
        {
            cheapestCost = ingredient.Value;
            cheapestIngredient = ingredient.Key;
        }
        if (ingredient.Value > mostExpensiveCost)
        {
            mostExpensiveCost = ingredient.Value;
            mostExpensiveIngredient = ingredient.Key;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Total cost: {totalCost} kr");
    Console.WriteLine($"Cheapest ingredient: {cheapestIngredient} {cheapestCost} kr");
    Console.WriteLine($"Most expensive ingredient: {mostExpensiveIngredient} {mostExpensiveCost} kr");
}
