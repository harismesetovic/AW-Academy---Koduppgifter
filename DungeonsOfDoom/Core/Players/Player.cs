class Player : CoreStats
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsAlive { get { return Health > 0; } }
    public Player(int health, int x, int y)
    {
        Inventory = new List<Item>();
        Strength = 10;
        Armor = 5;
        Health = health;
        X = x;
        Y = y;
        string randomName = RandomLists.MakeLists("name");
        string randomAttributes = RandomLists.MakeLists("attribute");
        Name = $"{randomName} the {randomAttributes}";
    }
    public void AddToInventory(Item item)
    {
        Inventory.Add(item);
        Strength += item.AttackPower;
        Armor += item.Armor;
    }


}
