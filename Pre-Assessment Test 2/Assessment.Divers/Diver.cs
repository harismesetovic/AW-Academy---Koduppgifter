using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment.Divers
{
    public class Diver
    {

        public List<string> Fishes { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public int Direction { get; set; }

        public Diver(string name)
        {
            Name = name;
            Fishes = new List<string>();
        }

        public void AddFish(string newFish)
        {
            Fishes.Add(newFish);
        }

        public string GetDescription()
        {
            if (Fishes.Any())
                return $"{Name} likes {String.Join(",", Fishes).ToLower()}";
            else
                return $"{Name} doesn't like any fish";

            //Assert.Equal("John likes shark", desc);

        }

        public object FishesSortedAlphabetically(int length)
        {
            List<string> sortedAlphabetically= new List<string>();
            foreach (string fish in Fishes)
            {
                if (fish.Length >= length)
                {
                    sortedAlphabetically.Add(fish);
                }
            }
            sortedAlphabetically.Sort();
            return sortedAlphabetically;
        }

        public object FishesSortedAlphabetically_Linq(int letterCount)
        {
            return Fishes
                .Where(f => f.Length >= letterCount)
                .OrderBy(f => f)
                .ToList();
        }

        public int GetPosition()
        {
            return Position;
        }

        public void SetDirectionDown()
        {
            Direction = -1;
        }

        public void Swim()
        {
            Position += Direction;
        }

        public void SetDirectionUp()
        {
            Direction = 1;
        }
    }
}
