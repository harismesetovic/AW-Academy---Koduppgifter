using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core
{
    internal static class RandomUtils
    {
        static Random random = new Random();

        public static bool Percentage()
        {
            int number = random.Next(0, 101);
            if (number >= 50)
            {
                return true;
            }
            return false;
        }

        public static int Dice()
        {
            return random.Next(1, 7);
        }
    }
}
