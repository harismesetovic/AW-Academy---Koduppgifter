using System.Drawing;

namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cups = new Cup[]
            {
                new Cup { Id = 11, Volume = 45, Color = Color.Transparent, HasHandle = false, },
                new Cup { Id = 215, Volume = 20, Color = Color.White, HasHandle = true, },
                new Cup { Id = 77, Volume = 25, Color = Color.White, HasHandle = true, },
            };

            int lineNr = 1;
            var q1 = cups
                .Where(c => c.Volume > 20)
                .OrderByDescending(c => c.Id)
                .Select(c => new
                {
                    Nr = lineNr++,
                    CupID = c.Id,
                    FancyColor = c.Color
                })
                .Skip(0)
                .Take(100)
                .ToArray();



            foreach (var item in q1)
                Console.WriteLine(item);

            foreach (var item in q1)
                Console.WriteLine(item);

            var maxVolume = cups.Max(c => c.Volume);
            var MaxVolumeCup = cups.MaxBy(c => c.Volume);
            var firstWhiteCup = cups.First(c => c.Color == Color.White);
            var singleTransparentCup = cups.Single(c => c.Color == Color.Transparent);
            var whiteCupCount = cups.Count(c => c.Color == Color.White);
        }
    }

    class Cup
    {
        public required int Id { get; set; }
        public required int Volume { get; set; }
        public required Color Color { get; set; }
        public required bool HasHandle { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Volume: {Volume}, Color: {Color}, Has handle?: {HasHandle}";
        }
    }

    enum Color
    {
        Red, Green, Blue, White, Transparent
    }
}