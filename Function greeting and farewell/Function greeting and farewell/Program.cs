namespace Function_greeting_and_farewell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Add(a, b);
        }

        private static void Add(int a, int b)
        {
           Console.WriteLine(a + b);
        }
    }
}