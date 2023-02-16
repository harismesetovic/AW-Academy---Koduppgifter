using System;

namespace LinqLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new Person[]
            {
                new Person { Name = "Bo", Age = 20 },
                new Person { Name = "Li", Age = 30 },
                new Person { Name = "An", Age = 40 },
                new Person { Name = "Anna", Age = 50 },
            };

            //a
            var q1 = people
                .Where(p => p.Age > 25)
                .OrderBy(p => p.Name)
                .ThenBy(p => p.Age);

            foreach (var item in q1)
                Console.WriteLine(item.Name);
                Console.WriteLine("-----------------");

            //b
            var q2 = people
                .Count(p => p.Age < 25);

                Console.WriteLine(q2);
                Console.WriteLine("-----------------");

            //c
            var q3 = people
                .Max(p => p.Age);

                Console.WriteLine(q3);
                Console.WriteLine("-----------------");

            //d
            var q4 = people
                .MinBy(p => p.Age);

                Console.WriteLine(q4.Name);
                Console.WriteLine("-----------------");

            //e
            var q5 = people
                .Average(p => p.Age);

                Console.WriteLine(q5);
                Console.WriteLine("-----------------");

            //f
            var q6 = people
                .MaxBy(p => p.Name.Length);

            Console.WriteLine(q6);
            Console.WriteLine("-----------------");

            //g
            if (people.Any(p => p.Name.Length > 3))
                Console.WriteLine("At least 1 person");
            else
                Console.WriteLine("No one with more then 3 letters in their name");
            Console.WriteLine("-----------------");

            //h
            var q8 = people
                .FirstOrDefault(p => p.Name == "An");

            Console.WriteLine(q8.Name);
            Console.WriteLine("-----------------");

            //i
            var q9 = people.GroupBy(p => p.Name.Length);

            foreach (var g in q9)
            {
                Console.WriteLine($"Letters: {g.Key}, People: {g.Count()}");
                foreach (var p in g)
                {
                    Console.WriteLine($"\t{p}");
                }
            }

            Console.WriteLine("-----------------");
        }
    }
}