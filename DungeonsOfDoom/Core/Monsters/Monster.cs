abstract class Monster : CoreStats
{

    public _MonsterType MonsterType { get; set; }
    public enum _MonsterType
    {
        Slime, Skeleton, Ogre, Snake
    }
    public string Type { get; set; }
    public Monster(string name, _MonsterType monsterType)
    {
        Name = $"{RandomLists.MakeLists(name)} {name}";
        MonsterType = monsterType;
        Inventory = new List<Item>();
        string randomItem = RandomLists.MakeLists("monsteritem");
        Inventory.Add(new MonsterItem($"{randomItem}"));
        MonsterCounter++;
    }

    public static int MonsterCounter { get; set; }

    public override void IncreaseDifficulty()
    {
        Strength += 5;
        Armor += 2;
    }
}
