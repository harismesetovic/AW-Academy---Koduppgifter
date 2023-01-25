using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    internal class Fruit
    {
        private double weight;

        public void SetWeight(double aWeight)
        {
            if (aWeight >= 0.1 && aWeight <= 0.5) //Validation
                weight = aWeight;
            else
                throw new ArgumentOutOfRangeException();
        }

        public double GetWeight()
        {
            return weight;
        }
    }
}
