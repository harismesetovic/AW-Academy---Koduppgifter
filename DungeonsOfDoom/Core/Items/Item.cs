abstract class Item
{
    public string Name { get; set; }
    public int AttackPower { get; set; }
    public int Armor { get; set; }
    public Item(string name)
    {
        Name = name;
    }
    public Item()
    {

    }
    virtual public void CheckForStats(string name)
    {
        switch (name.ToLower())
        {
            case "mirror shield":
                Armor = 15;
                break;
            case "elite shield":
                Armor = 11;
                break;
            default:
                Armor = 5;
                break;
        }
    }
}
