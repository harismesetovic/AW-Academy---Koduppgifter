namespace ListOfTDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();
            strings.Add("Brights");
            strings.Add("Academic Work");
            strings.Add("ACME");
            PrintElementsInList(strings);
            strings.Remove("Academic Work");

            strings.Sort();
            PrintElementsInList(strings);

            foreach (string word in strings)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();

            for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine(strings[i]);
            }

        }

        private static void PrintElementsInList(List<string> strings)
        {
            foreach (string word in strings)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("-------------------");
        }
    }
}