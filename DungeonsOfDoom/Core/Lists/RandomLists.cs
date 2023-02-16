public class RandomLists
{
    public static string MakeLists(string list)
    {
        List<string> strings;
        switch (list.ToLower())
        {
            case "monsteritem":
                strings = new List<string> { "Left Shoe", "Coin", "Hat", "Slime Powder", "Trash", "Potion" };
                break;
            case "name":
                strings = new List<string> { "John", "Jeff", "Jeremiah", "Robin", "Goliath" };
                break;
            case "attribute":
                strings = new List<string> { "Strong", "Stunning", "Handsome", "Evil", "Pretty" };
                break;
            case "monsterattribute":
                strings = new List<string> { "BigAssStrongLookingOne", "Evil", "Scary", "Dark", "Weak" };
                break;
            case "slime":
                strings = new List<string> { "Black", "White", "Blue", "Green", "Red" };
                break;
            case "skeleton":
                strings = new List<string> { "Bony", "White", "Tiny", "Giant", "Weak" };
                break;
            case "ogre":
                strings = new List<string> { "Hairy", "Pretty", "Gigantic", "Elite", "Strong" };
                break;
            case "sword":
                strings = new List<string> { "Magic", "Elite", "Iron", "Wooden", "Master", "Sharp", "Broken" };
                break;
            case "shield":
                strings = new List<string> { "Teleport Potion" };
                break;
            case "chest":
                strings = new List<string> { "Cape", "Helmet", "Pants", "Candle", "Torch" };
                break;
            default:
                return "CandleStick";
        }
        return Randomize(strings);
    }
    private static string Randomize(List<string> strings)
    {
        Random random = new Random();
        int number = random.Next(0, strings.Count);
        string item = strings[number];
        return item;
    }
}
