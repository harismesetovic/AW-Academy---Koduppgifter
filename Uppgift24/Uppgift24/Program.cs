using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Uppgift24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new();

            string[] fileStrings = File.ReadAllLines("C:\\Users\\haris\\Documents\\names.csv", Encoding.UTF7);

            foreach (string line in fileStrings) 
            {
                string[] splitStringLines = line.Split(";");
                string name = splitStringLines[0];
                DateTime date = DateTime.Parse(splitStringLines[1]);
                bool hasLongHairedDog = Random.Shared.Next(1, 100) < 40;
                people.Add(new Person { Name = name, NameDay = date, HasDogWithLongHair = hasLongHairedDog });
            }

            people = people.Distinct().ToList();

            //foreach (var item in people)
            //{
            //    Console.WriteLine($"Name: {item.Name.PadRight(20)} NameDay: {item.NameDay} Has dog with long hair: {item.HasDogWithLongHair}");
            //}

            //FilterNames(people, "An");
            //FilterNameDays(people, new DateTime(2015, 10, 2));
            //FilterNamesAndMonth(people, "H", 2);

        }
        public static void FilterNames(List<Person> people, string letterCombination)
        {
            var q = people
                .Where(p => p.Name.StartsWith(letterCombination, StringComparison.OrdinalIgnoreCase)).ToList();

            foreach (var item in q)
            {
                Console.WriteLine($"Name: {item.Name.PadRight(20)} NameDay: {item.NameDay} Has dog with long hair: {item.HasDogWithLongHair}");
            }
        }

        public static void FilterNameDays(List<Person> people, DateTime date)
        {
            var q = people
                .Where(p => p.NameDay.Date == date.Date).ToList();

            foreach (var item in q)
            {
                Console.WriteLine($"Name: {item.Name.PadRight(20)} NameDay: {item.NameDay} Has dog with long hair: {item.HasDogWithLongHair}");
            }
        }

        public static void FilterNamesAndMonth(List<Person> people, string letterCombination, int month)
        {
            var q = people
                .Where(p => p.Name.StartsWith(letterCombination, StringComparison.OrdinalIgnoreCase) && p.NameDay.Month == month).ToList();

            foreach (var item in q)
            {
                Console.WriteLine($"Name: {item.Name.PadRight(20)} NameDay: {item.NameDay} Has dog with long hair: {item.HasDogWithLongHair}");
            }

        }
    }
}