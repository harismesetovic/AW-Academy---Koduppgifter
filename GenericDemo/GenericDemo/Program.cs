namespace GenericDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericList<Company> names = new GenericList<Company>();
            names.Add(new Company("Brights", 2015));
            names.Add(new Company("Academic Work", 1998));
            names.Add(new Company("ACME Ltd", 1953));

            names[1].Name = "Academic Work Sweden AB";

            PrintElements(names);

            names.Sort((x, y) => x.Established < y.Established);

            foreach (Company item in names)
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintElements(GenericList<Company> names)
        {
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("------------------------------");
        }

        //static void Main(string[] args)
        //{
        //    GenericList<string> names = new GenericList<string>();
        //    names.Add("Brights");
        //    names.Add("Academic Work");
        //    names.Add("ACME LTD");

        //    string name = names[1];
        //    names[1] = "Academic Work Sweden AB";

        //    PrintElements(names);

        //    names.Sort((s1, s2) => string.Compare(s1, s2, true) < 0);

        //    foreach (string item in names)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //private static void PrintElements(GenericList <string> names)
        //{
        //    for (int i = 0; i < names.Count; i++)
        //    {
        //        Console.WriteLine(names[i]);
        //    }

        //    Console.WriteLine("-----------------------");
        //}

    }
}