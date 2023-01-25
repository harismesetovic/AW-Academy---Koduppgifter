namespace ArrayDemo2
{
    internal class Program
    {
        static void Main(string[] args)
            //UTÖKA ARRAY
        {
            //string[] names = new string[3];
            //names[0] = "Anna";
            //names[1] = "Bertil";
            //names[2] = "Cecilia";


            //string[] temp = new string[names.Length+1];

            //for (int i = 0; i < names.Length; i++)
            //{
            //    temp[i] = names[i];
            //}

            //temp[names.Length] = "David";
            //names = temp;

            string[] names = new string[2];
            names[0] = "Adam";
            names[1] = "Eva";
            PrintOut(names);
            Console.Clear();
            names = AddName(names);



            Console.Write("Skriv in namnet du vill ta bort: ");
            PrintOut(names);
            string nameToRemove = Console.ReadLine();
            RemoveName(names, nameToRemove);

            

        }

        private static void RemoveName(string[] names, string name)
        {
            int count = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] != name)
                {
                    names[count++] = names[i];
                }
            }

            Array.Resize(ref names, count);
        }

        private static string[] AddName(string[] names)
        {
            string[] addNames = new string[names.Length + 1];

            for (int i = 0; i < names.Length; i++)
            {
                addNames[i] = names[i];
            }

            Console.Write("Lägg till ett valfritt namn i Array:en: ");
            addNames[names.Length] = Console.ReadLine();
            names = addNames;
            return names;
        }

        private static void PrintOut(string[] names)
        {
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}