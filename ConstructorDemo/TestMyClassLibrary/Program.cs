using MyClassLibrary;

namespace TestMyClassLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOdd = Utilities.isOdd(3);
            Console.WriteLine(isOdd);
        }
    }
}