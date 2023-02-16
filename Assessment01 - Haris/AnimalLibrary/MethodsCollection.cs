using System;

namespace AnimalLibrary
{
    public class MethodsCollection
    {
        public static int AddThree(int n)
        {
            return n += 3;
        }

        public static int AddFourAndThenMultiplyByThree(int n)
        {
            return (n + 4) * 3;  
        }

        public static string MaybeUppercaseAndDecorateText(string s, bool uppercase, bool decorate)
        {
            if (uppercase)
            {
                s = s.ToUpper();

            }

            if (decorate)
            {
                s = "-:" + s + ":-";
            }

            return s;
        }


        public static string TellRelationToHundred(int number)
        {
            int diff = 100 - number;

            if (number < 0)
            {
                return $"{number} is a negative number";
            }

            else if (number == 100)
            {
                return "Add 0 to 100 and you get 100";
            }

            else if (number < 100)
            {
                return $"Add {diff} to {number} and you get 100";
            }
            else
            {
                return $"{number} is greater than 100";
            }

        }
    }
}
