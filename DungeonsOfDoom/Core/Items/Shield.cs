class Shield : Item
{
    internal Shield() : base(RandomLists.MakeLists("shield"))
    {
        CheckForStats(Name);
    }

}
