namespace Uppgift6
{
    class Program
    {
        static decimal currentBalance = 0;
        static void Main(string[] args)
        {

            while (true)
            {
                WelcomeMessage();
                ConsoleKey choice = GetMenuChoice();
                switch (choice)
                {
                    case ConsoleKey.W:
                        Withdrawal();
                        break;
                    case ConsoleKey.D:
                        Deposit();
                        break;
                    case ConsoleKey.B:
                        Balance();
                        break;
                    case ConsoleKey.E:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Input is not recognized, please see the options above");
                        break;
                        Console.Clear();
                        break;
                }

            }
        }

        private static ConsoleKey GetMenuChoice()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            Console.Clear();
            return cki.Key;
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the bank of Haris!");
            Console.WriteLine("\nTo [W]ithdraw money, press 'W'");
            Console.WriteLine("To [D]eposit money, press 'D'");
            Console.WriteLine("To view your [B]alance, press 'B'");
            Console.WriteLine("To [E]xit, press 'E'");
            Console.Write("Input: ");
        }

        private static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Press any key to exit...");
        }

        private static void Balance()
        {
            Console.WriteLine($"Current balance is {currentBalance} kr \n Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void Deposit()
        {
            Console.Write("Please input the amount you'd like to deposit: ");
            decimal addedBalance = decimal.Parse(Console.ReadLine());

            currentBalance += addedBalance;

            Console.WriteLine($"\n{addedBalance} kr has been deposited to your account. Your new balance is {currentBalance} kr \nPress any key to continue..");
            Console.ReadKey();
            Console.Clear();
        }
        private static void Withdrawal()
        {
            Console.Write("Please input the amount you'd like to withdraw: ");
            decimal withdrawBalance = decimal.Parse(Console.ReadLine());

            currentBalance -= withdrawBalance;

            Console.WriteLine($"\n{withdrawBalance} kr has been withdrawn from your account. Your new balance is {currentBalance} kr \nPress any key to continue..");
            Console.ReadKey();
            Console.Clear();

        }

    }
}