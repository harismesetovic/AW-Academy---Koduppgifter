class Ogre : Monster
{
    internal Ogre() : base("Ogre", _MonsterType.Ogre)
    {
        Health = 50;
        Strength = 10;
    }

    public override int Attack(CoreStats opponent)
    {
        opponent.Health -= Strength;
        return Strength;
    }
}
