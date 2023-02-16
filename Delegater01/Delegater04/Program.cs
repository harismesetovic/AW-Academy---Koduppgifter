namespace Delegater04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeMethod("BrigHts", AskAppUser);
        }

        private static bool AskAppUser()
        {
            Console.Write("Press [U] for uppercase, or any other key for lowercase: ");
            return Console.ReadKey().Key == ConsoleKey.U;
        }

        static void SomeMethod(string message, Func<bool> method)
        {
            if (method())
                Console.WriteLine($"\n{message.ToUpper()}");
            else
                Console.WriteLine($"\n{message.ToLower()}");

        }
    }
}