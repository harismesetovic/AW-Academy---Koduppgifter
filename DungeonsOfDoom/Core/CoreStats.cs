
abstract class CoreStats
{
    public string? Name { get; set; }
    public int Health { get; set; }
    public int Strength { get; set; } = 6;
    public int Armor { get; set; } = 0;

    public List<Item> Inventory { get; set; }

    public virtual int Attack(CoreStats opponent)
    {
        int damage = Strength - opponent.Armor;
        opponent.Health -= damage;

        return damage;
    }

    public virtual void IncreaseDifficulty()
    {

    }
}
