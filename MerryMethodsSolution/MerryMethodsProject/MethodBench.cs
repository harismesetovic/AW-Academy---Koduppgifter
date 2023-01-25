using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerryMethodsProject
{
    public class MethodBench
    {
        public void FirstMethod()
        {
            Console.WriteLine("Merry Methods");
        }

        public void SecondMethod(string message)
        {

            Console.WriteLine(message);
        }



        public void ThirdMethod(string message, bool toUpperCase)
        {
            if (toUpperCase)
                message = message.ToUpper();
            else
                message = message.ToLower();

            SecondMethod(message);
        }

        public bool FourthMethod()
        {
            bool toScream = false;
            ConsoleKey choice;
            choice = Console.ReadKey(true).Key;

            if (choice == ConsoleKey.S)
                toScream = true;
            return toScream;
        }

    }
}