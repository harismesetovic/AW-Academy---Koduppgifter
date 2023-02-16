class Sword : Item
{
    internal Sword() : base(RandomLists.MakeLists("sword") + " Sword")
    {
        CheckForStats(Name);
    }
    override public void CheckForStats(string name)
    {
        switch (name.ToLower())
        {
            case "master sword":
                AttackPower = 15;
                break;
            case "sharp sword":
                AttackPower = 11;
                break;
            default:
                AttackPower = 5;
                break;
        }
    }
}
