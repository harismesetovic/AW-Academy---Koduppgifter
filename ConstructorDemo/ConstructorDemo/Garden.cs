using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    internal class Garden
    {
        public string GardenName { get; set; }
        List<Fruit> fruits = new List<Fruit>()
        {
            new Fruit ("Pear", 0.25),
            new Fruit ("Pineapple", 0.5),
            new Fruit ("Banana", 0.15)
        };

        public Garden(string gardenName)
        {
            GardenName = gardenName;
        }
    }
}
