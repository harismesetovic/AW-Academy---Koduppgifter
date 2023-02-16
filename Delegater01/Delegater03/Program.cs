namespace Delegater03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func <int, int, bool> c = IsLessThan;
            Console.WriteLine(c(10, 25));
        }

        static bool IsLessThan (int a, int b)
        {
            return (a < b);
        }
    }
}