using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    internal class Fruit
    {
        //public Fruit() //Läggs till automatiskt i CIL utav C# kompilatorn om den saknas.
        //{

        //}

        private double weight;

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 0.1 || value > 0.5)
                    throw new ArgumentException();

                weight = value;
            }
        }

        private string fruitName;

        public string FruitName
        {
            get { return fruitName; }
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException();

                fruitName = value;
            }
        }


        public Fruit(string fruitName, double weight)
        {
            FruitName= fruitName;
            Weight = weight;
        }
    }
}
