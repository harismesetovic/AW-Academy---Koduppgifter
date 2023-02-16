namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Övning 1
            //StringPrint("Print this");

            //Övning 2
            //string input = AskForInput();
            //StringPrint(input);

            //Övning 3
            string input = AskForInput();
            if (input.ToLower() == "exit") 
            {
                Environment.Exit(0);
            }
            StringPrint(input);
        }

        private static string AskForInput()
        {
            Console.WriteLine("Enter smth:");
            return Console.ReadLine();
        }

        private static void StringPrint(string input)
        {
            Console.WriteLine(input);
        }
    }
}
