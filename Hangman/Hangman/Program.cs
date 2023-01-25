

namespace Hangman
{
    class Program
    {
        static string correctWord = "hangman";
        static char[] letters;
        static string name;
        static int numberOfGuesses;

        static void Main(string[] args)
        {
            StartGame();
            PlayGame();
            EndGame();
        }

        private static void StartGame()
        {
            letters = new char[correctWord.Length];
            for (int i = 0; i < correctWord.Length; i++)
                letters[i] = '-';
            
            AskForUsersName();
        }

        static void AskForUsersName()
        {
            Console.WriteLine("Enter your name: ");
            string input = Console.ReadLine();

            if (input.Length >= 2)
                //The user entered a valid name
                name = input;
            else
            {
                //The user entered a invalid name
                AskForUsersName();
            }
        }

        private static void PlayGame()
        {
            DisplayMaskedWord();
            AskForLetter();
        }

        static void DisplayMaskedWord()
        {
            foreach (char c in letters)
            
                Console.Write(c);
            
            Console.WriteLine();
        }

        static char AskForLetter()
        {
            string input;
            do
            {
                Console.WriteLine("Enter a letter:");
                input = Console.ReadLine();
            } while (input.Length !=1);

            numberOfGuesses++;

            return input[0];
        }

        private static void EndGame()
        {
            Console.WriteLine("Game over...");
            Console.WriteLine($"Thanks for playing {name}!");
            Console.WriteLine($"Guesses: {numberOfGuesses}");


        }
    }
}